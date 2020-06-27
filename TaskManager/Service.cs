using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class Service
    {
        public static void CreateServiceList()
        {
            TaskManager.Globals.SerTable.Clear();
            TaskManager.Globals.SerTable.Columns.Add("Service Name");
            TaskManager.Globals.SerTable.Columns.Add("Display Name");
            TaskManager.Globals.SerTable.Columns.Add("Status");
            TaskManager.Globals.SerTable.Columns.Add("Service Type");
            TaskManager.Globals.SerTable.Columns.Add("Start Type");
            
        }

        public static void RefreshServiceList()
        {
            TaskManager.Globals.SerTable.Clear();

            ServiceController[] services = ServiceController.GetServices();
            foreach (ServiceController service in services)
            {
                try
                {

                    TaskManager.Globals.SerTable.Rows.Add(service.ServiceName, service.DisplayName, service.Status,
                        service.ServiceType, service.StartType);

                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
