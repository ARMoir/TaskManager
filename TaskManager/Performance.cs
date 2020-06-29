using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using static TaskManager.TaskManager;

namespace TaskManager
{
    class Performance
    {
        public static void CPUChart()
        {

            Globals.CPUseriesArea.ChartType = SeriesChartType.Area;

            if (Globals.CPU[Globals.CPU.Length - 1] > 80)
            {
                Globals.CPUseriesArea.Color = Color.FromArgb(128, Color.PaleVioletRed);
            }
            else
            {
                Globals.CPUseriesArea.Color = Color.FromArgb(128, 230, 230, 250);
            }

            Globals.CPUseriesLine.ChartType = SeriesChartType.Line;

            if (Globals.CPU[Globals.CPU.Length - 1] > 80)
            {
                Globals.CPUseriesLine.Color = Color.Red;

            }
            else
            {
                Globals.CPUseriesLine.Color = Color.FromArgb(255, 65, 105, 225);

            }

            Globals.CPUseriesLine.Points.DataBindXY(Globals.Time, Globals.CPU);
            Globals.CPUseriesArea.Points.DataBindXY(Globals.Time, Globals.CPU);
        }

        public static void RamChart()
        {
            Globals.RAMseriesLine.ChartType = SeriesChartType.Line;
            Globals.RAMseriesLine.Color = Color.Purple;
            Globals.RAMseriesLine.Points.DataBindXY(Globals.Time, Globals.RAM);

            Globals.RAMseriesArea.ChartType = SeriesChartType.Area;
            Globals.RAMseriesArea.Color = Color.FromArgb(128, Color.Violet);
            Globals.RAMseriesArea.Points.DataBindXY(Globals.Time, Globals.RAM);
        }
    }
}
