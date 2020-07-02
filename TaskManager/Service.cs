using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using static TaskManager.TaskManager;

namespace TaskManager
{
    class Service
    {
        public static void CreateServiceList()
        {
            Globals.SerTable.Clear();
            Globals.SerTable.Columns.Add("Service Name");
            Globals.SerTable.Columns.Add("Display Name");
            Globals.SerTable.Columns.Add("Status");
            Globals.SerTable.Columns.Add("Service Type");
            Globals.SerTable.Columns.Add("Start Type");
            
        }

        public static void RefreshServiceList()
        {
            Globals.SerTable.Clear();

            ServiceController[] services = ServiceController.GetServices();
            foreach (ServiceController service in services)
            {
                try
                {

                    Globals.SerTable.Rows.Add(service.ServiceName, service.DisplayName, service.Status,
                        service.ServiceType, service.StartType);

                }
                catch (Exception)
                {
                }
            }
        }
    }
}
