using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class Processes
    {
        public static void CreateProcessList()
        {
            TaskManager.Globals.ProTable.Clear();
            TaskManager.Globals.ProTable.Columns.Add("Icon", typeof(Bitmap));
            TaskManager.Globals.ProTable.Columns.Add("id");
            TaskManager.Globals.ProTable.Columns.Add("ProcessName");
            TaskManager.Globals.ProTable.Columns.Add("MainWindowTitle");
            TaskManager.Globals.ProTable.Columns.Add("Responding");
            TaskManager.Globals.ProTable.Columns.Add("UserProcessorTime");
            TaskManager.Globals.ProTable.Columns.Add("PrivateMemorySize64");
            
        }

        public static void RefreshProcessList()
        {
            TaskManager.Globals.ProTable.Clear();

            Process[] ProcessListArray = Process.GetProcesses();
            foreach (Process Pro in ProcessListArray)
            {
                try
                {
                    TaskManager.Globals.ProID = (Int32.Parse(Pro.Id.ToString()));
                    GetIcon();

                    TaskManager.Globals.ProTable.Rows.Add(TaskManager.Globals.Icon, Pro.Id, Pro.ProcessName, Pro.MainWindowTitle,
                    Pro.Responding, Pro.UserProcessorTime, Pro.PrivateMemorySize64);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        public static bool ThumbnailCallback() { return false; }

        public static void GetIcon()
        {
            try
            {
                Process proc = Process.GetProcessById(TaskManager.Globals.ProID);
                string fullPath = proc.MainModule.FileName;
                Bitmap Icon = (System.Drawing.Icon.ExtractAssociatedIcon(fullPath)).ToBitmap();
                int thumbSize = 20;
                TaskManager.Globals.Icon = new Bitmap(Icon.GetThumbnailImage(thumbSize, thumbSize, ThumbnailCallback, IntPtr.Zero));
                Icon.Dispose();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
            }
        }

        public static void UpdateProcessList()
        {

            Process[] ProcessListArray = Process.GetProcesses();
            foreach (Process Pro in ProcessListArray)
            {
                try
                {
                    foreach (DataRow row in TaskManager.Globals.ProTable.Rows)
                    {
                        if (row["id"].ToString() == Pro.Id.ToString())
                        {
                            row.SetField("ProcessName", Pro.ProcessName);
                            row.SetField("MainWindowTitle", Pro.MainWindowTitle);
                            row.SetField("Responding", Pro.Responding);
                            row.SetField("UserProcessorTime", Pro.UserProcessorTime);
                            row.SetField("PrivateMemorySize64", Pro.PrivateMemorySize64);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
