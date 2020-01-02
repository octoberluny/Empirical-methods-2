using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using DevExpress;
using System.IO;

namespace HomeWork
{
    public partial class MainWindow : Form
    {
        const int Size = 30;
        double[] array1 = new double[Size];
        double[] array2 = new double[Size];
        public List<double> LOC = new List<double>();
        public List<double> NOM = new List<double>();
        public List<double> NOP = new List<double>();
        public List<double> NDD = new List<double>();
        public List<double> HIT = new List<double>();
        public List<double> CM = new List<double>();
        public List<double> WOC = new List<double>();
        public List<double> FDP = new List<double>();
        public List<double> AMW = new List<double>();
        public List<double> ATFD = new List<double>();
        List<double> temp1 = new List<double>();
        List<double> temp2 = new List<double>();
        Loading loading = new Loading();
        Calculate calc = new Calculate();
        Regresia regresia = new Regresia();
        internal Loading Loading { get { throw new System.NotImplementedException(); } set { } }
        internal Regresia Regresia { get { throw new System.NotImplementedException(); } set { } }
        internal Calculate Calculate { get { throw new System.NotImplementedException(); } set { } }
        public MainWindow()
        {
            InitializeComponent();
            chart.Series.Clear();
            chart1.Series.Clear();
            Loading loading = new Loading();
            loading.LoadingFile(this);
        }
        public void _LOC()
        {
            for (int i = 0; i < LOC.Count; i++)
                label.Text += LOC[i].ToString() + "\n";
            this.resultMatSpod.Text = calc.MathSpod(LOC).ToString();
            this.resultDisp.Text = calc.Dispers(LOC).ToString();
            this.resultSerKv.Text = calc.SerKvad(LOC).ToString();
            this.resultKoefAsm.Text = calc.Asymetria(LOC).ToString();
            this.resultKoefExc.Text = calc.Excess(LOC).ToString();
            this.resultLaw.Text = calc.ZakonRozpodilu(LOC);
            this.label11.Text = calc.downLimit(LOC).ToString();
            this.label15.Text = calc.upLimit(LOC).ToString();
        }
        public void _NOM()
        {
            for (int i = 0; i < NOM.Count; i++)
                label.Text += NOM[i].ToString() + "\n";
            this.resultMatSpod.Text = calc.MathSpod(NOM).ToString();
            this.resultDisp.Text = calc.Dispers(NOM).ToString();
            this.resultSerKv.Text = calc.SerKvad(NOM).ToString();
            this.resultKoefAsm.Text = calc.Asymetria(NOM).ToString();
            this.resultKoefExc.Text = calc.Excess(NOM).ToString();
            this.resultLaw.Text = calc.ZakonRozpodilu(NOM);
            this.label11.Text = calc.downLimit(NOM).ToString();
            this.label15.Text = calc.upLimit(NOM).ToString();
        }
        public void _NOP()
        {
            for (int i = 0; i < NOP.Count; i++)
                label.Text += NOP[i].ToString() + "\n";
            this.resultMatSpod.Text = calc.MathSpod(NOP).ToString();
            this.resultDisp.Text = calc.Dispers(NOP).ToString();
            this.resultSerKv.Text = calc.SerKvad(NOP).ToString();
            this.resultKoefAsm.Text = calc.Asymetria(NOP).ToString();
            this.resultKoefExc.Text = calc.Excess(NOP).ToString();
            this.resultLaw.Text = calc.ZakonRozpodilu(NOP);
            this.label11.Text = calc.downLimit(NOP).ToString();
            this.label15.Text = calc.upLimit(NOP).ToString();
        }
        public void _NDD()
        {
            for (int i = 0; i < NDD.Count; i++)
                label.Text += NDD[i].ToString() + "\n";
            this.resultMatSpod.Text = calc.MathSpod(NDD).ToString();
            this.resultDisp.Text = calc.Dispers(NDD).ToString();
            this.resultSerKv.Text = calc.SerKvad(NDD).ToString();
            this.resultKoefAsm.Text = calc.Asymetria(NDD).ToString();
            this.resultKoefExc.Text = calc.Excess(NDD).ToString();
            this.resultLaw.Text = calc.ZakonRozpodilu(NDD);
            this.label11.Text = calc.downLimit(NDD).ToString();
            this.label15.Text = calc.upLimit(NDD).ToString();
        }
        public void _HIT()
        {
            for (int i = 0; i < HIT.Count; i++)
                label.Text += HIT[i].ToString() + "\n";
            this.resultMatSpod.Text = calc.MathSpod(HIT).ToString();
            this.resultDisp.Text = calc.Dispers(HIT).ToString();
            this.resultSerKv.Text = calc.SerKvad(HIT).ToString();
            this.resultKoefAsm.Text = calc.Asymetria(HIT).ToString();
            this.resultKoefExc.Text = calc.Excess(HIT).ToString();
            this.resultLaw.Text = calc.ZakonRozpodilu(HIT);
            this.label11.Text = calc.downLimit(HIT).ToString();
            this.label15.Text = calc.upLimit(HIT).ToString();
        }
        public void _CM()
        {
            for (int i = 0; i < CM.Count; i++)
                label.Text += CM[i].ToString() + "\n";
            this.resultMatSpod.Text = calc.MathSpod(CM).ToString();
            this.resultDisp.Text = calc.Dispers(CM).ToString();
            this.resultSerKv.Text = calc.SerKvad(CM).ToString();
            this.resultKoefAsm.Text = calc.Asymetria(CM).ToString();
            this.resultKoefExc.Text = calc.Excess(CM).ToString();
            this.resultLaw.Text = calc.ZakonRozpodilu(CM);
            this.label11.Text = calc.downLimit(CM).ToString();
            this.label15.Text = calc.upLimit(CM).ToString();
        }
        public void _WOC()
        {
            for (int i = 0; i < WOC.Count; i++)
                label.Text += WOC[i].ToString() + "\n";
            this.resultMatSpod.Text = calc.MathSpod(WOC).ToString();
            this.resultDisp.Text = calc.Dispers(WOC).ToString();
            this.resultSerKv.Text = calc.SerKvad(WOC).ToString();
            this.resultKoefAsm.Text = calc.Asymetria(WOC).ToString();
            this.resultKoefExc.Text = calc.Excess(WOC).ToString();
            this.resultLaw.Text = calc.ZakonRozpodilu(WOC);
            this.label11.Text = calc.downLimit(WOC).ToString();
            this.label15.Text = calc.upLimit(WOC).ToString();
        }
        public void _FDP()
        {
            for (int i = 0; i < FDP.Count; i++)
                label.Text += FDP[i].ToString() + "\n";
            this.resultMatSpod.Text = calc.MathSpod(FDP).ToString();
            this.resultDisp.Text = calc.Dispers(FDP).ToString();
            this.resultSerKv.Text = calc.SerKvad(FDP).ToString();
            this.resultKoefAsm.Text = calc.Asymetria(FDP).ToString();
            this.resultKoefExc.Text = calc.Excess(FDP).ToString();
            this.resultLaw.Text = calc.ZakonRozpodilu(FDP);
            this.label11.Text = calc.downLimit(FDP).ToString();
            this.label15.Text = calc.upLimit(FDP).ToString();
        }
        public void _AMW()
        {
            for (int i = 0; i < AMW.Count; i++)
                label.Text += AMW[i].ToString() + "\n";
            this.resultMatSpod.Text = calc.MathSpod(AMW).ToString();
            this.resultDisp.Text = calc.Dispers(AMW).ToString();
            this.resultSerKv.Text = calc.SerKvad(AMW).ToString();
            this.resultKoefAsm.Text = calc.Asymetria(AMW).ToString();
            this.resultKoefExc.Text = calc.Excess(AMW).ToString();
            this.resultLaw.Text = calc.ZakonRozpodilu(AMW);
            this.label11.Text = calc.downLimit(AMW).ToString();
            this.label15.Text = calc.upLimit(AMW).ToString();
        }
        public void _ATFD()
        {
            for (int i = 0; i < ATFD.Count; i++)
                label.Text += ATFD[i].ToString() + "\n";
            this.resultMatSpod.Text = calc.MathSpod(ATFD).ToString();
            this.resultDisp.Text = calc.Dispers(ATFD).ToString();
            this.resultSerKv.Text = calc.SerKvad(ATFD).ToString();
            this.resultKoefAsm.Text = calc.Asymetria(ATFD).ToString();
            this.resultKoefExc.Text = calc.Excess(ATFD).ToString();
            this.resultLaw.Text = calc.ZakonRozpodilu(ATFD);
            this.label11.Text = calc.downLimit(ATFD).ToString();
            this.label15.Text = calc.upLimit(ATFD).ToString();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label.Text = "";
            chart.Series.Clear();
            int index = comboBox1.SelectedIndex;
            if (index == -1)
            {
                System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show("Оберіть метрику", "Помилка", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            else
            {
                String s = comboBox1.SelectedItem.ToString();
                switch (s)
                {
                    case "LOC":
                        {
                            calc.DrawGist(LOC, chart, s);
                            _LOC();
                        }
                        break;
                    case "NOM":
                        {
                            calc.DrawGist(NOM, chart, s);
                            _NOM();
                        }
                        break;
                    case "NOP":
                        {
                            calc.DrawGist(NOP, chart, s);
                            _NOP();
                        }
                        break;
                    case "NDD":
                        {
                            calc.DrawGist(NDD, chart, s);
                            _NDD();
                        }
                        break;
                    case "HIT":
                        {
                            calc.DrawGist(HIT, chart, s);
                            _HIT();
                        }
                        break;
                    case "CM":
                        {
                            calc.DrawGist(CM, chart, s);
                            _CM();
                        }
                        break;
                    case "WOC":
                        {
                            calc.DrawGist(WOC, chart, s);
                            _WOC();
                        }
                        break;
                    case "FDP":
                        {
                            calc.DrawGist(FDP, chart, s);
                            _FDP();
                        }
                        break;
                    case "AMW":
                        {
                            calc.DrawGist(AMW, chart, s);
                            _AMW();
                        }
                        break;
                    case "ATFD":
                        {
                            calc.DrawGist(ATFD, chart, s);
                            _ATFD();
                        }
                        break;
                }
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            NormalMetrix.Text = "";
            String s = comboBox2.SelectedItem.ToString();
            switch (s)
            {
                case "LOC":
                    {
                        for (int i = 0; i < LOC.Count; i++)
                            NormalMetrix.Text += LOC[i].ToString() + "\n";
                        temp1 = LOC;
                        calculate();
                    }
                    break;
                case "NOM":
                    {
                        for (int i = 0; i < NOM.Count; i++)
                            NormalMetrix.Text += NOM[i].ToString() + "\n";
                        temp1 = NOM;
                        calculate();
                    }
                    break;
                case "NOP":
                    {
                        for (int i = 0; i < NOP.Count; i++)
                            NormalMetrix.Text += NOP[i].ToString() + "\n";
                        temp1 = NOP;
                        calculate();
                    }
                    break;
                case "NDD":
                    {
                        for (int i = 0; i < NDD.Count; i++)
                            NormalMetrix.Text += NDD[i].ToString() + "\n";
                        temp1 = NDD;
                        calculate();
                    }
                    break;
                case "HIT":
                    {
                        for (int i = 0; i < HIT.Count; i++)
                            NormalMetrix.Text += HIT[i].ToString() + "\n";
                        temp1 = HIT;
                        calculate();
                    }
                    break;
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            NotNormalMetric.Text = "";
            String s = comboBox3.SelectedItem.ToString();
            switch (s)
            {
                case "CM":
                    {
                        for (int i = 0; i < CM.Count; i++)
                            NotNormalMetric.Text += CM[i].ToString() + "\n";
                        temp2 = CM;
                        calculate();
                    }
                    break;
                case "WOC":
                    {
                        for (int i = 0; i < WOC.Count; i++)
                            NotNormalMetric.Text += WOC[i].ToString() + "\n";
                        temp2 = WOC;
                        calculate();
                    }
                    break;
                case "FDP":
                    {
                        for (int i = 0; i < FDP.Count; i++)
                            NotNormalMetric.Text += FDP[i].ToString() + "\n";
                        temp2 = FDP;
                        calculate();
                    }
                    break;
                case "AMW":
                    {
                        for (int i = 0; i < AMW.Count; i++)
                            NotNormalMetric.Text += AMW[i].ToString() + "\n";
                        temp2 = AMW;
                        calculate();
                    }
                    break;
                case "ATFD":
                    {
                        for (int i = 0; i < ATFD.Count; i++)
                            NotNormalMetric.Text += ATFD[i].ToString() + "\n";
                        temp2 = ATFD;
                        calculate();
                    }
                    break;
            }
        }
        public void calculate()
        {
            if (comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1)
            {
                this.resultKendal.Text = calc.Kendal(temp1, temp2).ToString();
                this.ZnachResult.Text = calc.Znachuszist(temp1, temp2).ToString();
                //виклик побудови поля регресії
                regresia.DrawRegresia(temp1, temp2, chart1);
                double a = regresia.calculateA(temp1, temp2, calc.MathSpod(temp1), calc.MathSpod(temp2), calc.Dispers(temp1));
                double b = regresia.calculateB(temp1, temp2, calc.MathSpod(temp1), calc.MathSpod(temp2), calc.Dispers(temp1));
                regresia.DrawLine(temp1, a, b, chart1);
                label7.Text = regresia.calculateA(temp1, temp2, calc.MathSpod(temp1), calc.MathSpod(temp2), calc.Dispers(temp1)).ToString();
                label12.Text = regresia.calculateB(temp1, temp2, calc.MathSpod(temp1), calc.MathSpod(temp2), calc.Dispers(temp1)).ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            String s = comboBox1.SelectedItem.ToString();
            switch (s)
            {
                case "LOC": calc.Anomal(LOC); break;
                case "NOM": calc.Anomal(NOM); break;
                case "NOP": calc.Anomal(NOP); break;
                case "NDD": calc.Anomal(NDD); break;
                case "HIT": calc.Anomal(HIT); break;
                case "CM": calc.Anomal(CM); break;
                case "WOC": calc.Anomal(WOC); break;
                case "FDP": calc.Anomal(FDP); break;
                case "AMW": calc.Anomal(AMW); break;
                case "ATFD": calc.Anomal(ATFD); break;
            }
            this.comboBox1_SelectedIndexChanged(sender, e);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label.Text = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                int j = 0;
                while (!streamReader.EndOfStream)
                {
                    array1[j] = Convert.ToDouble(streamReader.ReadLine());
                    chart.Series.Clear();
                    button2.Text = System.IO.Path.GetFileName(openFileDialog1.FileName).ToString();
                    j++;
                }
                for (int i = 0; i < array1.Length; i++)
                    label.Text += array1[i].ToString() + "\n";
                this.resultMatSpod.Text = calc.MathSpod(array1.ToList()).ToString();
                this.resultDisp.Text = calc.Dispers(array1.ToList()).ToString();
                this.resultSerKv.Text = calc.SerKvad(array1.ToList()).ToString();
                this.resultKoefAsm.Text = calc.Asymetria(array1.ToList()).ToString();
                this.resultKoefExc.Text = calc.Excess(array1.ToList()).ToString();
                this.resultLaw.Text = calc.ZakonRozpodilu(array1.ToList());
                this.label11.Text = calc.downLimit(array1.ToList()).ToString();
                this.label15.Text = calc.upLimit(array1.ToList()).ToString();
                String s = System.IO.Path.GetFileName(openFileDialog1.FileName).ToString();
                calc.DrawGist(array1.ToList(), chart, s);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            NormalMetrix.Text = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                int j = 0;
                while (!streamReader.EndOfStream)
                {
                    array1[j] = Convert.ToDouble(streamReader.ReadLine());
                    chart1.Series.Clear();
                    button4.Text = System.IO.Path.GetFileName(openFileDialog1.FileName).ToString();
                    j++;
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            NotNormalMetric.Text = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                int j = 0;
                while (!streamReader.EndOfStream)
                {
                    array2[j] = Convert.ToDouble(streamReader.ReadLine());
                    chart1.Series.Clear();
                    button5.Text = System.IO.Path.GetFileName(openFileDialog1.FileName).ToString();
                    j++;
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            temp1 = array1.ToList();
            temp2 = array2.ToList();
            this.resultKendal.Text = calc.Kendal(temp1, temp2).ToString();
            this.ZnachResult.Text = calc.Znachuszist(temp1, temp2).ToString();
            // виклик побудови поля регресії
            regresia.DrawRegresia(temp1, temp2, chart1);
            double a = regresia.calculateA(temp1, temp2, calc.MathSpod(temp1), calc.MathSpod(temp2), calc.Dispers(temp1));
            double b = regresia.calculateB(temp1, temp2, calc.MathSpod(temp1), calc.MathSpod(temp2), calc.Dispers(temp1));
            regresia.DrawLine(temp1, a, b, chart1);
            label7.Text = regresia.calculateA(temp1, temp2, calc.MathSpod(temp1), calc.MathSpod(temp2), calc.Dispers(temp1)).ToString();
            label12.Text = regresia.calculateB(temp1, temp2, calc.MathSpod(temp1), calc.MathSpod(temp2), calc.Dispers(temp1)).ToString();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            List<double> temp3 = new List<double>();
            temp3 = calc.Anomal(array1.ToList());
            label.Text = "";
            foreach (var metiric in temp3)
            {
                label.Text += metiric + "\n";
            }
        }
        private void label1_Click_1(object sender, EventArgs e){throw new NotImplementedException();}
        private void label10_Click(object sender, EventArgs e){throw new NotImplementedException();}
        private void label6_Click(object sender, EventArgs e){ throw new NotImplementedException();}
        private void pictureBox1_Click(object sender, EventArgs e){}
        private void Regression_Click(object sender, EventArgs e){}
        private void MainWindow_Load(object sender, EventArgs e){}
        private void groupBox1_Enter(object sender, EventArgs e){}
        private void chart1_Click_1(object sender, EventArgs e){}
        private void tabPage1_Click(object sender, EventArgs e){}
        private void label11_Click(object sender, EventArgs e){}
        private void chart_Click_1(object sender, EventArgs e){}
        private void chart1_Click(object sender, EventArgs e){}
        private void chart_Click(object sender, EventArgs e) {}
        private void label_Click(object sender, EventArgs e){}
    }
}