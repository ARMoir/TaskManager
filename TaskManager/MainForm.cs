using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TaskManager
{
    public partial class TaskManager : Form
    {
        public TaskManager()
        {
            
            InitializeComponent();
            Processes.CreateProcessList();
            ProcessGridView.DataSource = Globals.ProTable;
            Processes.RefreshProcessList();
            Processes.UpdateProcessList();
            ProcessGridView.Update();
            Service.CreateServiceList();
            ServiceGridView.DataSource = Globals.SerTable;
            Service.RefreshServiceList();
        }

        public static class Globals
        {
            public static string Name { get; set; } = "";
            public static int LoadPercentage { get; set; } = 0;
            public static int CurrentClockSpeed { get; set; } = 0;
            public static int MaxClockSpeed { get; set; } = 0;
            public static int NumberOfCores { get; set; } = 0;
            public static int NumberOfLogicalProcessors { get; set; } = 0;
            public static int L2CacheSize { get; set; } = 0;
            public static int FreePhysicalMemory { get; set; } = 0;
            public static int TotalVisibleMemorySize { get; set; } = 0;
            public static int TotalVirtualMemorySize { get; set; } = 0;
            public static int FreeVirtualMemory { get; set; } = 0;
            public static int NumberOfProcessors { get; set; } = 0;
            public static int ProID { get; set; } = 0;
            public static DataTable ProTable { get; set; } = new DataTable();
            public static DataTable SerTable { get; set; } = new DataTable();
            public static Bitmap Icon { get; set; } = new Bitmap(1,1);
            public static int[] CPU { get; set; } = Enumerable.Repeat(0, 60).ToArray(); 
            public static int[] RAM { get; set; } = Enumerable.Repeat(0, 60).ToArray();

            public static int[] Time { get; set; } = {
                -60, -59, -58, -57, -56, -55, -54, -53, -52, -51, -50, -49, -48, -47, -46,
                -45, -44, -43, -42, -41, -40, -39, -38, -37, -36, -35, -34, -33, -32, -31,
                -30, -29, -28, -27, -26, -25, -24, -23, -22, -21, -20, -19, -18, -17, -16,
                -15, -14, -13, -12, -11, -10, -9, -8, -7, -6, -5, -4, -3, -2, -1};
        }

        public void PopMainList()
        {
            MainList.Items.Clear();
            MainList.Items.Add("Name: " + Globals.Name);
            MainList.Items.Add("LoadPercentage: " + Globals.LoadPercentage + "%");
            MainList.Items.Add("CurrentClockSpeed: " + Globals.CurrentClockSpeed);
            MainList.Items.Add("MaxClockSpeed: " + Globals.MaxClockSpeed);
            MainList.Items.Add("NumberOfProcessors: " + Globals.NumberOfProcessors);
            MainList.Items.Add("NumberOfCores: " + Globals.NumberOfCores);
            MainList.Items.Add("NumberOfLogicalProcessors: " + Globals.NumberOfLogicalProcessors);
            MainList.Items.Add("TotalVisibleMemorySize: " + Globals.TotalVisibleMemorySize);
            MainList.Items.Add("FreePhysicalMemory: " + Globals.FreePhysicalMemory);
            MainList.Items.Add("L2CacheSize: " + Globals.L2CacheSize);
        }

        public void PopBars()
        {
            CpuBar.Visible = true;
            CpuBar.Maximum = 100;
            CpuBar.Value = Globals.CPU[Globals.CPU.Length - 1];

            RamBar.Visible = true;
            RamBar.Minimum = 1;
            RamBar.Maximum = Globals.TotalVisibleMemorySize;
            RamBar.Value = Globals.TotalVisibleMemorySize - Globals.FreePhysicalMemory;
        }

        public void PopChart()
        {
            MainChart.ChartAreas[0].AxisX.Maximum = 0;
            MainChart.ChartAreas[0].AxisX.Minimum = -60;
            MainChart.ChartAreas[0].AxisY.Maximum = 100;
            MainChart.ChartAreas[0].AxisY.Minimum = 0;

            var CPUseriesArea = new Series("CPUArea");
            CPUseriesArea.ChartType = SeriesChartType.Area;

            if (Globals.CPU[Globals.CPU.Length - 1] > 80)
            {
                CPUseriesArea.Color = Color.FromArgb(128, Color.PaleVioletRed);  
            }
            else
            {
                CPUseriesArea.Color = Color.FromArgb(128, 230, 230, 250);
            }

            CPUseriesArea.Points.DataBindXY(Globals.Time, Globals.CPU);

            var CPUseriesLine = new Series("CPULine");
            CPUseriesLine.ChartType = SeriesChartType.Line;

            if (Globals.CPU[Globals.CPU.Length - 1] > 80)
            {
                CPUseriesLine.Color = Color.Red;
                CPUcheck.ForeColor = Color.Red;
            }
            else
            {
                CPUseriesLine.Color = Color.FromArgb(255, 65, 105, 225);
                CPUcheck.ForeColor = Color.FromArgb(255, 65, 105, 225);
            }

            CPUseriesLine.Points.DataBindXY(Globals.Time, Globals.CPU);

            var RAMseriesLine = new Series("RAMLine");
            RAMseriesLine.ChartType = SeriesChartType.Line;
            RAMseriesLine.Color = Color.Purple;
            RAMseriesLine.Points.DataBindXY(Globals.Time, Globals.RAM);

            var RAMseriesArea = new Series("RAMArea");
            RAMseriesArea.ChartType = SeriesChartType.Area;
            RAMseriesArea.Color = Color.FromArgb(128, Color.Violet);
            RAMseriesArea.Points.DataBindXY(Globals.Time, Globals.RAM);

            RAMcheck.ForeColor = Color.Purple;

            MainChart.Series.Clear();

            if (RAMcheck.Checked)
            {
                MainChart.Series.Add(RAMseriesArea);
                MainChart.Series.Add(RAMseriesLine);
            }

            if (CPUcheck.Checked)
            {
                MainChart.Series.Add(CPUseriesArea);
                MainChart.Series.Add(CPUseriesLine);
            }

            MainChart.Legends["Legend1"].Enabled = false;
        }



        private void killToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            try
            {
                Process proc = Process.GetProcessById(Int32.Parse(ProcessGridView.CurrentRow.Cells[1].Value.ToString()));
                proc.Kill();
                Processes.RefreshProcessList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process proc = Process.GetProcessById(Int32.Parse(ProcessGridView.CurrentRow.Cells[1].Value.ToString()));
                string fullPath = proc.MainModule.FileName;
                Process.Start("explorer.exe", "/select, " + fullPath);
                Processes.RefreshProcessList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process proc = Process.GetProcessById(Int32.Parse(ProcessGridView.CurrentRow.Cells[1].Value.ToString()));
                string fullPath = proc.MainModule.FileName;
                ViewProperties.ViewProperties.ShowFileProperties(fullPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceController service = new ServiceController(ServiceGridView.CurrentRow.Cells[0].Value.ToString());
                service.Stop();
                Service.RefreshServiceList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceController service = new ServiceController(ServiceGridView.CurrentRow.Cells[0].Value.ToString());
                service.Start();
                Service.RefreshServiceList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Service.RefreshServiceList();
        }

        private void ProcessTimer_Tick(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedTab == MainTabControl.TabPages["ProcessesPage"])
            {
                Processes.UpdateProcessList();
                ProcessGridView.Update();
            }
        }

        private void PerformanceTimer_Tick(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => Win32.Win32_Processor());
            Task.Factory.StartNew(() => Win32.Win32_OperatingSystem());
            Task.Factory.StartNew(() => Win32.Win32_ComputerSystem());

            if (MainTabControl.SelectedTab == MainTabControl.TabPages["PerformancePage"])
            {
                PopMainList();
                PopChart();
            }
        }

        private void BarTimer_Tick(object sender, EventArgs e)
        {
            PopBars();

            using (Graphics Draw = CpuBar.CreateGraphics())
            {
                string CPU = "CPU " + Globals.CPU[Globals.CPU.Length - 1].ToString() + "%";
                Draw.DrawString(CPU, new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Regular, GraphicsUnit.Pixel, 128), Brushes.Black, (CpuBar.Width / 2 - CPU.Length * 2), (CpuBar.Height / 2 - 7));
            }

            using (Graphics Draw = RamBar.CreateGraphics())
            {
                string RAM = "RAM " + Globals.RAM[Globals.RAM.Length - 1].ToString() + "% " + Globals.FreePhysicalMemory + " / " + Globals.TotalVisibleMemorySize;
                Draw.DrawString(RAM, new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Regular, GraphicsUnit.Pixel, 128), Brushes.Black, (CpuBar.Width / 2 - RAM.Length * 2), (CpuBar.Height / 2 - 7));
            }
        }
    }
}

