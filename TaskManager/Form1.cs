using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
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

        }

        public static class Globals
        {

            public static string Name = "";
            public static int LoadPercentage = 0;
            public static int CurrentClockSpeed = 0;
            public static int MaxClockSpeed = 0;
            public static int NumberOfCores = 0;
            public static int NumberOfLogicalProcessors = 0;
            public static int L2CacheSize = 0;

            public static int FreePhysicalMemory = 0;
            public static int TotalVisibleMemorySize = 0;
            public static int TotalVirtualMemorySize = 0;
            public static int FreeVirtualMemory = 0;

            public static int NumberOfProcessors = 0;

            public static int[] CPU = { 
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            public static int[] RAM = {
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            public static int[] Time = {
                -60, -59, -58, -57, -56, -55, -54, -53, -52, -51, -50, -49, -48, -47, -46,
                -45, -44, -43, -42, -41, -40, -39, -38, -37, -36, -35, -34, -33, -32, -31,
                -30, -29, -28, -27, -26, -25, -24, -23, -22, -21, -20, -19, -18, -17, -16,
                -15, -14, -13, -12, -11, -10, -9, -8, -7, -6, -5, -4, -3, -2, -1};
        }

        public void Win32_Processor()
        {

            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_Processor");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();

            foreach (ManagementObject result in results)
            {
                Globals.Name = (result["Name"].ToString());
                Globals.LoadPercentage = (Convert.ToInt32(result["LoadPercentage"]));
                Globals.CurrentClockSpeed = (Convert.ToInt32(result["CurrentClockSpeed"]));
                Globals.MaxClockSpeed = (Convert.ToInt32(result["MaxClockSpeed"]));
                Globals.NumberOfCores = (Convert.ToInt32(result["NumberOfCores"]));
                Globals.NumberOfLogicalProcessors = (Convert.ToInt32(result["NumberOfLogicalProcessors"]));
                Globals.L2CacheSize = (Convert.ToInt32(result["L2CacheSize"]));
            }

            for (int i = 0; i < (Globals.CPU.Length - 1); i++)
            {
                Globals.CPU[i] = Globals.CPU[i + 1];
            }
            Globals.CPU[Globals.CPU.Length -1] = Globals.LoadPercentage;


        }

        public void Win32_OperatingSystem()
        {

            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();

            foreach (ManagementObject result in results)
            {
                Globals.TotalVisibleMemorySize = (Convert.ToInt32(result["TotalVisibleMemorySize"]));
                Globals.FreePhysicalMemory = (Convert.ToInt32(result["FreePhysicalMemory"]));
                Globals.TotalVirtualMemorySize = (Convert.ToInt32(result["TotalVirtualMemorySize"]));
                Globals.FreeVirtualMemory = (Convert.ToInt32(result["FreeVirtualMemory"]));
            }

            float RAMPercentageFloat = ((Globals.FreePhysicalMemory - Globals.TotalVisibleMemorySize) * 100) / Globals.TotalVisibleMemorySize;
            int RAMPercentage = Math.Abs(Convert.ToInt32(RAMPercentageFloat));

            for (int i = 0; i < (Globals.RAM.Length - 1); i++)
            {
                Globals.RAM[i] = Globals.RAM[i + 1];
            }
            Globals.RAM[Globals.RAM.Length -1] = RAMPercentage;

        }

        public void Win32_ComputerSystem()
        {

            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_ComputerSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();

            foreach (ManagementObject result in results)
            {
                Globals.NumberOfProcessors = (Convert.ToInt32(result["NumberOfProcessors"]));
            }
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

            if (RAMcheck.Checked == true)
            {
                MainChart.Series.Add(RAMseriesArea);
                MainChart.Series.Add(RAMseriesLine);
            }

            if (CPUcheck.Checked == true)
            {
                MainChart.Series.Add(CPUseriesArea);
                MainChart.Series.Add(CPUseriesLine);
            }

            MainChart.Legends["Legend1"].Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => Win32_Processor());
            Task.Factory.StartNew(() => Win32_OperatingSystem());
            Task.Factory.StartNew(() => Win32_ComputerSystem());

            PopMainList();
            PopBars();
            PopChart();
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            string CPU = "CPU " + Globals.CPU[Globals.CPU.Length - 1].ToString() + "%";
            CpuBar.CreateGraphics().DrawString(CPU, new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Regular, GraphicsUnit.Pixel, 128), Brushes.Black, (CpuBar.Width / 2 - CPU.Length * 2), (CpuBar.Height / 2 - 7));

            string RAM = "RAM " + Globals.RAM[Globals.RAM.Length - 1].ToString() + "% " + Globals.FreePhysicalMemory + " / " + Globals.TotalVisibleMemorySize;
            RamBar.CreateGraphics().DrawString(RAM, new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Regular, GraphicsUnit.Pixel, 128), Brushes.Black, (CpuBar.Width / 2 - RAM.Length * 2), (CpuBar.Height / 2 - 7));
 
        }

    }
}

