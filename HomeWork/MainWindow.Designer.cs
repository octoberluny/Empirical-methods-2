namespace HomeWork
{
    partial class MainWindow
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматично створений конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.Regression = new System.Windows.Forms.TabPage();
            this.NotNormalMetric = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NormalMetrix = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ZnachResult = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.resultKendal = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultKoefKendal = new System.Windows.Forms.Label();
            this.resultMatSpod = new System.Windows.Forms.Label();
            this.resultU = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultSerKv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.resultDisp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultLaw = new System.Windows.Forms.Label();
            this.resultKoefAsm = new System.Windows.Forms.Label();
            this.resultKoefExc = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Korelation = new System.Windows.Forms.TabControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Regression.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Korelation.SuspendLayout();
            this.SuspendLayout();
            // 
            // Regression
            // 
            this.Regression.Controls.Add(this.label12);
            this.Regression.Controls.Add(this.label7);
            this.Regression.Controls.Add(this.label6);
            this.Regression.Controls.Add(this.label5);
            this.Regression.Controls.Add(this.NotNormalMetric);
            this.Regression.Controls.Add(this.label10);
            this.Regression.Controls.Add(this.NormalMetrix);
            this.Regression.Controls.Add(this.button6);
            this.Regression.Controls.Add(this.button5);
            this.Regression.Controls.Add(this.button4);
            this.Regression.Controls.Add(this.ZnachResult);
            this.Regression.Controls.Add(this.chart1);
            this.Regression.Controls.Add(this.resultKendal);
            this.Regression.Controls.Add(this.comboBox3);
            this.Regression.Controls.Add(this.comboBox2);
            this.Regression.Controls.Add(this.label13);
            this.Regression.Controls.Add(this.label18);
            this.Regression.Controls.Add(this.label16);
            this.Regression.Controls.Add(this.label20);
            this.Regression.Controls.Add(this.label19);
            this.Regression.Controls.Add(this.pictureBox1);
            this.Regression.Location = new System.Drawing.Point(4, 22);
            this.Regression.Name = "Regression";
            this.Regression.Padding = new System.Windows.Forms.Padding(3);
            this.Regression.Size = new System.Drawing.Size(1228, 427);
            this.Regression.TabIndex = 1;
            this.Regression.Text = "Кореляційний та регресійний аналіз";
            this.Regression.UseVisualStyleBackColor = true;
            this.Regression.Click += new System.EventHandler(this.Regression_Click);
            // 
            // NotNormalMetric
            // 
            this.NotNormalMetric.AutoSize = true;
            this.NotNormalMetric.Location = new System.Drawing.Point(550, 10);
            this.NotNormalMetric.Name = "NotNormalMetric";
            this.NotNormalMetric.Size = new System.Drawing.Size(0, 13);
            this.NotNormalMetric.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 8;
            // 
            // NormalMetrix
            // 
            this.NormalMetrix.AutoSize = true;
            this.NormalMetrix.Location = new System.Drawing.Point(15, 12);
            this.NormalMetrix.Name = "NormalMetrix";
            this.NormalMetrix.Size = new System.Drawing.Size(0, 13);
            this.NormalMetrix.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(377, 72);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 24);
            this.button6.TabIndex = 22;
            this.button6.Text = "Обрахувати";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(342, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 21);
            this.button5.TabIndex = 20;
            this.button5.Text = "Обрати іншу непряму метрику";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(342, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 21);
            this.button4.TabIndex = 19;
            this.button4.Text = "Обрати іншу пряму метрику";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ZnachResult
            // 
            this.ZnachResult.AutoSize = true;
            this.ZnachResult.Location = new System.Drawing.Point(404, 378);
            this.ZnachResult.Name = "ZnachResult";
            this.ZnachResult.Size = new System.Drawing.Size(0, 13);
            this.ZnachResult.TabIndex = 17;
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(80, 104);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(433, 245);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // resultKendal
            // 
            this.resultKendal.AutoSize = true;
            this.resultKendal.Location = new System.Drawing.Point(197, 380);
            this.resultKendal.Name = "resultKendal";
            this.resultKendal.Size = new System.Drawing.Size(0, 13);
            this.resultKendal.TabIndex = 16;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "CM",
            "WOC",
            "FDP",
            "AMW",
            "ATFD"});
            this.comboBox3.Location = new System.Drawing.Point(80, 42);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(154, 21);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.Text = "Власна непряма метрика";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "LOC",
            "NOM",
            "NOP",
            "NDD",
            "HIT"});
            this.comboBox2.Location = new System.Drawing.Point(80, 14);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.Text = "Власна пряма метрика";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(189, 403);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label18.Location = new System.Drawing.Point(323, 378);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Значущість:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(395, 378);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label20.Location = new System.Drawing.Point(79, 380);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(110, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Коефіцієнт Кендала:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(212, 380);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 13);
            this.label19.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::HomeWork.Properties.Resources.no_translate_detected_1048_2144;
            this.pictureBox1.Location = new System.Drawing.Point(-14, -86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(622, 774);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.label);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.chart);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.resultKoefKendal);
            this.tabPage1.Controls.Add(this.resultMatSpod);
            this.tabPage1.Controls.Add(this.resultU);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.resultSerKv);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.resultDisp);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.resultLaw);
            this.tabPage1.Controls.Add(this.resultKoefAsm);
            this.tabPage1.Controls.Add(this.resultKoefExc);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1228, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Статистичний аналіз";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(297, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(246, 21);
            this.button8.TabIndex = 25;
            this.button8.Text = "Видалити аномальні значення іншої метрики";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Linen;
            this.label.Location = new System.Drawing.Point(553, 5);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 5;
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(160, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 21);
            this.button2.TabIndex = 23;
            this.button2.Text = "Обрати іншу метрику";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(3, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 57);
            this.button1.TabIndex = 16;
            this.button1.Text = "Видалити аномальні значення власних метрик";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label21.Location = new System.Drawing.Point(3, 187);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 13);
            this.label21.TabIndex = 21;
            this.label21.Text = "Верхня межа:";
            // 
            // chart
            // 
            chartArea6.BorderColor = System.Drawing.Color.White;
            chartArea6.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea6);
            this.chart.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            legend6.Name = "Legend1";
            this.chart.Legends.Add(legend6);
            this.chart.Location = new System.Drawing.Point(135, 210);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart.Series.Add(series6);
            this.chart.Size = new System.Drawing.Size(408, 214);
            this.chart.TabIndex = 6;
            this.chart.Text = "chart1";
            this.chart.Click += new System.EventHandler(this.chart_Click_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label17.Location = new System.Drawing.Point(3, 166);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "Нижня межа:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Linen;
            this.label15.Location = new System.Drawing.Point(88, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Linen;
            this.label11.Location = new System.Drawing.Point(87, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "LOC",
            "NOM",
            "NOP",
            "NDD",
            "HIT",
            "CM",
            "WOC",
            "FDP",
            "AMW",
            "ATFD"});
            this.comboBox1.Location = new System.Drawing.Point(3, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Обрати власну метрику";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Математичне сподівання:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // resultKoefKendal
            // 
            this.resultKoefKendal.AutoSize = true;
            this.resultKoefKendal.Location = new System.Drawing.Point(125, 208);
            this.resultKoefKendal.Name = "resultKoefKendal";
            this.resultKoefKendal.Size = new System.Drawing.Size(0, 13);
            this.resultKoefKendal.TabIndex = 15;
            this.resultKoefKendal.Click += new System.EventHandler(this.label10_Click);
            // 
            // resultMatSpod
            // 
            this.resultMatSpod.AutoSize = true;
            this.resultMatSpod.BackColor = System.Drawing.Color.Linen;
            this.resultMatSpod.Location = new System.Drawing.Point(146, 33);
            this.resultMatSpod.Name = "resultMatSpod";
            this.resultMatSpod.Size = new System.Drawing.Size(0, 13);
            this.resultMatSpod.TabIndex = 1;
            // 
            // resultU
            // 
            this.resultU.AutoSize = true;
            this.resultU.Location = new System.Drawing.Point(81, 243);
            this.resultU.Name = "resultU";
            this.resultU.Size = new System.Drawing.Size(0, 13);
            this.resultU.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дисперсія: ";
            // 
            // resultSerKv
            // 
            this.resultSerKv.AutoSize = true;
            this.resultSerKv.BackColor = System.Drawing.Color.Linen;
            this.resultSerKv.Location = new System.Drawing.Point(187, 77);
            this.resultSerKv.Name = "resultSerKv";
            this.resultSerKv.Size = new System.Drawing.Size(0, 13);
            this.resultSerKv.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(3, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Середнє квадратичне відхилення:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label9.Location = new System.Drawing.Point(3, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Закон розподілу: ";
            // 
            // resultDisp
            // 
            this.resultDisp.AutoSize = true;
            this.resultDisp.BackColor = System.Drawing.Color.Linen;
            this.resultDisp.Location = new System.Drawing.Point(75, 55);
            this.resultDisp.Name = "resultDisp";
            this.resultDisp.Size = new System.Drawing.Size(0, 13);
            this.resultDisp.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label8.Location = new System.Drawing.Point(3, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Коефіцієнт асиметрії: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Location = new System.Drawing.Point(3, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Коефіцієнь ексцесу:";
            // 
            // resultLaw
            // 
            this.resultLaw.AutoSize = true;
            this.resultLaw.BackColor = System.Drawing.Color.Linen;
            this.resultLaw.Location = new System.Drawing.Point(105, 144);
            this.resultLaw.Name = "resultLaw";
            this.resultLaw.Size = new System.Drawing.Size(0, 13);
            this.resultLaw.TabIndex = 8;
            // 
            // resultKoefAsm
            // 
            this.resultKoefAsm.AutoSize = true;
            this.resultKoefAsm.BackColor = System.Drawing.Color.Linen;
            this.resultKoefAsm.Location = new System.Drawing.Point(127, 122);
            this.resultKoefAsm.Name = "resultKoefAsm";
            this.resultKoefAsm.Size = new System.Drawing.Size(0, 13);
            this.resultKoefAsm.TabIndex = 6;
            // 
            // resultKoefExc
            // 
            this.resultKoefExc.AutoSize = true;
            this.resultKoefExc.BackColor = System.Drawing.Color.Linen;
            this.resultKoefExc.Location = new System.Drawing.Point(118, 100);
            this.resultKoefExc.Name = "resultKoefExc";
            this.resultKoefExc.Size = new System.Drawing.Size(0, 13);
            this.resultKoefExc.TabIndex = 7;
            this.resultKoefExc.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = global::HomeWork.Properties.Resources._583026c84f8641587c177e86;
            this.pictureBox2.Location = new System.Drawing.Point(-53, -484);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(665, 1179);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // Korelation
            // 
            this.Korelation.Controls.Add(this.tabPage1);
            this.Korelation.Controls.Add(this.Regression);
            this.Korelation.Location = new System.Drawing.Point(12, 12);
            this.Korelation.Name = "Korelation";
            this.Korelation.SelectedIndex = 0;
            this.Korelation.Size = new System.Drawing.Size(1236, 453);
            this.Korelation.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "a = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "b = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(249, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 26;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 466);
            this.Controls.Add(this.Korelation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.Text = "Емпіричні методи програмної інженерії";
            this.Regression.ResumeLayout(false);
            this.Regression.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Korelation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Regression;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;

        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label NotNormalMetric;
        private System.Windows.Forms.Label NormalMetrix;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label resultKoefKendal;
        private System.Windows.Forms.Label resultU;
        private System.Windows.Forms.Label resultSerKv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label resultLaw;
        private System.Windows.Forms.Label resultKoefExc;
        private System.Windows.Forms.Label resultKoefAsm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultDisp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultMatSpod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Korelation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ZnachResult;
        private System.Windows.Forms.Label resultKendal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
    }
}

