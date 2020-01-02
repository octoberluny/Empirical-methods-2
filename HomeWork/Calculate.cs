using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using DevExpress;
using DevExpress.Charts.ChartData;
using DevExpress.XtraCharts;
using System.Drawing;
using System.Windows.Forms;

namespace HomeWork
{
    class Calculate
    {
        //статистичний аналіз
        public double GetSumMetrix(double[] metrix)
        {
            double Sum = 0;
            for (int i = 0; i < metrix.Length; i++)
            {
                Sum = Sum + metrix[i];
            }
            return Sum;
        }
        public double MathSpod(List<double> list)
        {
            double Sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                Sum += list[i];
            }
            double math_spod = Sum / list.Count;
            return math_spod;
        }
        public double Dispers(List<double> list)
        {
            double temp = 0;
            double math_spod = MathSpod(list);
            for (int i = 0; i < list.Count; i++)
                temp += Math.Pow((list[i] - math_spod), 2);
            return Math.Floor((1.0 / (list.Count - 1.0) * temp) * 10000) / 10000.0;
        }
        public double SerKvad(List<double> list)
        {
            return Math.Sqrt(Dispers(list));
        }
        public double Asymetria(List<double> list)
        {
            double kof_a = 0;
            double math_spod = MathSpod(list);
            double sum3 = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum3 += (Math.Pow((list[i] - math_spod), 3.0));
            }
            kof_a = sum3 / (Math.Pow(SerKvad(list), 3.0) * list.Count);
            return kof_a;
        }
        public double Excess(List<double> list)
        {
            double kof_e = 0;
            double math_spod = MathSpod(list);
            double sum3 = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum3 += (Math.Pow((list[i] - math_spod), 4.0));
            }
            kof_e = sum3 / (Math.Pow(SerKvad(list), 4.0) * list.Count);
            return kof_e;
        }
        public double downLimit(List<double> list)
        {
            double d_limit = 0;
            d_limit = MathSpod(list) - (1.96 * SerKvad(list)) / Math.Sqrt(list.Count);
            return d_limit;
        }
        public double upLimit(List<double> list)
        {
            double u_limit = 0;
            u_limit = MathSpod(list) + (1.96 * SerKvad(list)) / Math.Sqrt(list.Count);
            return u_limit;
        }
        public string ZakonRozpodilu(List<double> list)
        {
            string Law = "не нормальний";
            double a = Asymetria(list), e = Excess(list);
            if (a < 0.3 && e < 0.3)
                Law = "нормальний";
            return Law;
        }
        //гістограма
        public int StepGist(List<double> list)
        {
            int size = list.Count, s = Convert.ToInt32(Math.Sqrt(size));
            if (s % 2 != 0)
                s -= 1;
            return s;
        }
        public double StepSizeGist(List<double> list, int s)
        {
            return (MaxGist(list) - MixGist(list)) / s;
        }
        public double MixGist(List<double> list)
        {
            double min = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (min > list[i])
                    min = list[i];
            }
            return min;
        }
        public double MaxGist(List<double> list)
        {
            double max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > max)
                    max = list[i];
            }
            return max;
        }
        public void DrawGist(List<double> list, Chart chart, string name)
        {
            Calculate calc = new Calculate();
            double point = 0;
            chart.Series.Add(name);
            chart.Series[name].ChartType = SeriesChartType.Area;
            chart.Series[name].Color = Color.LightPink;
            chart.Series[name].BorderWidth = 7;
            //Пошук мін елемента в списку
            point = calc.MixGist(list);
            //Установка мін значення
            chart.Series[name].Points.AddXY(point, 0);
            //Побудова гістограми
            for (int k = 0; k < calc.StepGist(list); k++)
            {
                //Значення наступоної точки (+крок)
                double nextPoint = point + calc.StepSizeGist(list, calc.StepGist(list));
                int y;
                //Кількість метрик в діапазоні
                if (k == calc.StepGist(list) - 1)
                    y = calc.NumMetrixInsideDiapazonAB(list, point, calc.MaxGist(list));
                else
                    y = calc.NumMetrixInsideDiapazonAB(list, point, nextPoint);
                //Ліва частина стовбця
                chart.Series[name].Points.AddXY(point, y);
                //Права частина стовбця
                chart.Series[name].Points.AddXY(nextPoint, y);
                chart.Series[name].Points.AddXY(nextPoint, 0);
                //Збільшуємо поточний інтервал кроку
                point = nextPoint;
            }
            //Права частина останнього стовбця гістограми
            chart.Series[name].Points.AddXY(point, 0);
        }
        public int NumMetrixInsideDiapazonAB(List<double> list, double a, double b)
        {
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                //Якщо елемент списка потрапляє в діапазон a і b, то збільшуємо кількість метрик в діапазоні
                if (list[i] >= a && list[i] <= b)
                    count++;
            }
            return count;
        }
        //кендал, значущість, аномальні значення
        public double Kendal(List<double> list1, List<double> list2)
        {
            int n = 0;
            bool b = true, c = true;
            double dhelper = 0;
            List<double> tempRang = new List<double>(list2);
            List<double> templist1 = new List<double>(list1);
            List<double> templist2 = new List<double>(list2);
            //Перевірка размірності списків
            if (list1.Count < list2.Count)
                n = list1.Count;
            else
                n = list2.Count;
            //Створюється масив з рангами
            int[] rang = new int[n];
            for (int i = 0; i < n; i++)
                rang[i] = i + 1;
            tempRang.Sort();
            int[] atemprang = rang;
            int sorthelper = n - 1;
            //Сортування непрямої метрики по прямій
            while (b)
            {
                for (int i = 0; i < n; i++)
                {
                    if (i != sorthelper)
                        if (templist1[i] > templist1[i + 1])
                        {
                            //Зміна значення в списку прямої метрики
                            dhelper = templist1[i + 1];
                            templist1[i + 1] = templist1[i];
                            templist1[i] = dhelper;
                            //Відповідна зміна в списку непрямої
                            dhelper = templist2[i + 1];
                            templist2[i + 1] = templist2[i];
                            templist2[i] = dhelper;
                            c = false;
                        }
                }
                if (c == true)
                    b = false;
                else
                    c = true;
            }
            //Разстановка рангів для непрямої метрики
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (templist2[j] > templist2[i])
                        count++;
                }
                atemprang[i] = count + 1;
                count = 0;
            }
            //Знаходження P(p) рівень значимості?, сума різниці між числом послідовностей і числом інверсій
            int S = 0;
            for (int i = 1; i < n; i++)
            {
                if (atemprang[i] > atemprang[i - 1])
                    S += atemprang[i] - atemprang[i - 1];
            }
            //Знаходження Кенделла
            double corCoef1 = 2 * S;
            double corCoef2 = n * (n - 1);
            double corCoef = (corCoef1 / corCoef2);
            return corCoef;
        }
        public double Znachuszist(List<double> list1, List<double> list2)
        {
            int n = 0;
            //Перевірка розмірності списків
            if (list1.Count < list2.Count)
                n = list1.Count;
            else
                n = list2.Count;
            double coef = Kendal(list1, list2);
            double temp1 = 3 * coef;
            double temp2 = Math.Sqrt(2 * (2 * n + 5));
            double temp3 = Math.Sqrt(n * (n - 1));
            double znach = (temp1 / temp2) * temp3;
            return znach;
        }
        public List<double> Anomal(List<double> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                //модуль різності елемента списку і мат.сподівання ділимо на корінь з дисперсії. Якщо результат більше 
                //1.96(квантеля розподілу Стьюдента), то видаляємо элемент
                if (Math.Abs(list[i] - MathSpod(list)) / Math.Sqrt(Dispers(list)) > 1.96)
                {
                    list.RemoveAt(i);
                }
            }
            return list;
        }
    }
}