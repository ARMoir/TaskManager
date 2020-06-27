using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class Win32
    {
        public static void Win32_Processor()
        {

            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_Processor");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();

            foreach (ManagementObject result in results)
            {
                TaskManager.Globals.Name = (result["Name"].ToString());
                TaskManager.Globals.LoadPercentage = (Convert.ToInt32(result["LoadPercentage"]));
                TaskManager.Globals.CurrentClockSpeed = (Convert.ToInt32(result["CurrentClockSpeed"]));
                TaskManager.Globals.MaxClockSpeed = (Convert.ToInt32(result["MaxClockSpeed"]));
                TaskManager.Globals.NumberOfCores = (Convert.ToInt32(result["NumberOfCores"]));
                TaskManager.Globals.NumberOfLogicalProcessors = (Convert.ToInt32(result["NumberOfLogicalProcessors"]));
                TaskManager.Globals.L2CacheSize = (Convert.ToInt32(result["L2CacheSize"]));
            }

            for (int i = 0; i < (TaskManager.Globals.CPU.Length - 1); i++)
            {
                TaskManager.Globals.CPU[i] = TaskManager.Globals.CPU[i + 1];
            }
            TaskManager.Globals.CPU[TaskManager.Globals.CPU.Length - 1] = TaskManager.Globals.LoadPercentage;
        }

        public static void Win32_OperatingSystem()
        {
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();

            foreach (ManagementObject result in results)
            {
                TaskManager.Globals.TotalVisibleMemorySize = (Convert.ToInt32(result["TotalVisibleMemorySize"]));
                TaskManager.Globals.FreePhysicalMemory = (Convert.ToInt32(result["FreePhysicalMemory"]));
                TaskManager.Globals.TotalVirtualMemorySize = (Convert.ToInt32(result["TotalVirtualMemorySize"]));
                TaskManager.Globals.FreeVirtualMemory = (Convert.ToInt32(result["FreeVirtualMemory"]));
            }

            float RAMPercentageFloat = ((TaskManager.Globals.FreePhysicalMemory - TaskManager.Globals.TotalVisibleMemorySize) * 100) / TaskManager.Globals.TotalVisibleMemorySize;
            int RAMPercentage = Math.Abs(Convert.ToInt32(RAMPercentageFloat));

            for (int i = 0; i < (TaskManager.Globals.RAM.Length - 1); i++)
            {
                TaskManager.Globals.RAM[i] = TaskManager.Globals.RAM[i + 1];
            }
            TaskManager.Globals.RAM[TaskManager.Globals.RAM.Length - 1] = RAMPercentage;
        }

        public static void Win32_ComputerSystem()
        {
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_ComputerSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();

            foreach (ManagementObject result in results)
            {
                TaskManager.Globals.NumberOfProcessors = (Convert.ToInt32(result["NumberOfProcessors"]));
            }
        }
    }
}
