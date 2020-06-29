using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using static TaskManager.TaskManager;

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
            Globals.CPU[Globals.CPU.Length - 1] = Globals.LoadPercentage;
        }

        public static void Win32_OperatingSystem()
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
            Globals.RAM[Globals.RAM.Length - 1] = RAMPercentage;
        }

        public static void Win32_ComputerSystem()
        {
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_ComputerSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();

            foreach (ManagementObject result in results)
            {
                Globals.NumberOfProcessors = (Convert.ToInt32(result["NumberOfProcessors"]));
            }
        }
    }
}
