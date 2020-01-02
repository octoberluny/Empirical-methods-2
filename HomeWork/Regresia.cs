using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using DevExpress.Charts.ChartData;
using DevExpress.XtraCharts;

namespace HomeWork
{
    class Regresia
    {
        public void DrawRegresia(List<double> list1, List<double> list2, Chart chart)
        {
            Calculate calc = new Calculate();
            chart.Series.Add("Field");
            chart.Series["Field"].ChartType = SeriesChartType.Point;
            chart.Series["Field"].Color = Color.LightPink;
            chart.Series["Field"].BorderWidth = 3;
            int n = 0;
            if (list1.Count < list2.Count) n = list1.Count;
            else n = list2.Count;
            for (int i = 0; i < n; i++)
                chart.Series["Field"].Points.AddXY(list1[i], list2[i]);
        }
        public void DrawLine(List<double> list1, double a, double b, Chart chart)
        {
            chart.Series.Add("Line");
            chart.Series["Line"].ChartType = SeriesChartType.Line;
            chart.Series["Line"].Color = Color.CadetBlue;
            chart.Series["Line"].BorderWidth = 3;
            for (int i = 0; i < list1.Count; i++)
            {
                chart.Series["Line"].Points.AddXY(list1[i], list1[i] * b + a);
            }
        }
        public double calculateB(List<double> a, List<double> b, double math_spod1, double math_spod2, double Dispers)
        {
            double Sum = 0;
            for (int i = 0; i < a.Count; i++)
                Sum += a[i] * b[i];
            Sum /= a.Count;
            double mn = math_spod1 * math_spod2;
            Sum -= mn;
            return Sum / Dispers;
        }
        public double calculateA(List<double> a, List<double> b, double math_spod1, double math_spod2, double Dispers)
        {
            return math_spod2 - calculateB(a, b, math_spod1, math_spod2, Dispers) * math_spod1;
        }
    }
}