using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TaskManager.TaskManager;

namespace TaskManager
{
    class Processes
    {
        public static void CreateProcessList()
        {
            Globals.ProTable.Clear();
            Globals.ProTable.Columns.Add("Icon", typeof(Bitmap));
            Globals.ProTable.Columns.Add("id");
            Globals.ProTable.Columns.Add("ProcessName");
            Globals.ProTable.Columns.Add("MainWindowTitle");
            Globals.ProTable.Columns.Add("Responding");
            Globals.ProTable.Columns.Add("UserProcessorTime");
            Globals.ProTable.Columns.Add("PrivateMemorySize64");
            
        }

        public static void RefreshProcessList()
        {
            Globals.ProTable.Clear();

            Process[] ProcessListArray = Process.GetProcesses();
            foreach (Process Pro in ProcessListArray)
            {
                try
                {
                    Globals.ProID = (Int32.Parse(Pro.Id.ToString()));
                    GetIcon();

                    Globals.ProTable.Rows.Add(Globals.Icon, Pro.Id, Pro.ProcessName, Pro.MainWindowTitle,
                    Pro.Responding, Pro.UserProcessorTime, Pro.PrivateMemorySize64);
                }
                catch (Exception)
                {
                }
            }
        }

        public static bool ThumbnailCallback() { return false; }

        public static void GetIcon()
        {
            try
            {
                Process proc = Process.GetProcessById(Globals.ProID);
                string fullPath = proc.MainModule.FileName;
                Bitmap Icon = (System.Drawing.Icon.ExtractAssociatedIcon(fullPath)).ToBitmap();
                int thumbSize = 20;
                Globals.Icon = new Bitmap(Icon.GetThumbnailImage(thumbSize, thumbSize, ThumbnailCallback, IntPtr.Zero));
                Icon.Dispose();
            }
            catch (Exception)
            {
            }
        }

        public static void UpdateProcessList()
        {

            Process[] ProcessListArray = Process.GetProcesses();
            foreach (Process Pro in ProcessListArray)
            {
                try
                {
                    foreach (DataRow row in Globals.ProTable.Rows)
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
                catch (Exception)
                {
                }
            }
        }
    }
}
