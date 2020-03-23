namespace IntegralMethods
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.nUpDa = new System.Windows.Forms.NumericUpDown();
            this.nUpDb = new System.Windows.Forms.NumericUpDown();
            this.nUpDn = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.labelN = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trapRbtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.smpRBtn = new System.Windows.Forms.RadioButton();
            this.prRBtn = new System.Windows.Forms.RadioButton();
            this.resultLabel = new System.Windows.Forms.Label();
            this.mainGraphCBox = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(217, 35);
            this.chart1.Name = "chart1";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.OrangeRed;
            series5.Legend = "Legend1";
            series5.Name = "Series2";
            series5.YValuesPerPoint = 2;
            series6.BorderColor = System.Drawing.Color.White;
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            series6.Legend = "Legend1";
            series6.Name = "Series4";
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(929, 499);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(20, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "ПІДТВЕРДИТИ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nUpDa
            // 
            this.nUpDa.Location = new System.Drawing.Point(39, 35);
            this.nUpDa.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUpDa.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nUpDa.Name = "nUpDa";
            this.nUpDa.Size = new System.Drawing.Size(46, 23);
            this.nUpDa.TabIndex = 2;
            this.nUpDa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUpDb
            // 
            this.nUpDb.Location = new System.Drawing.Point(121, 35);
            this.nUpDb.Name = "nUpDb";
            this.nUpDb.Size = new System.Drawing.Size(43, 23);
            this.nUpDb.TabIndex = 3;
            this.nUpDb.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // nUpDn
            // 
            this.nUpDn.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUpDn.Location = new System.Drawing.Point(39, 77);
            this.nUpDn.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nUpDn.Name = "nUpDn";
            this.nUpDn.Size = new System.Drawing.Size(125, 23);
            this.nUpDn.TabIndex = 4;
            this.nUpDn.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1009, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "ПІДТВЕРДИТИ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(15, 79);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(19, 19);
            this.labelN.TabIndex = 12;
            this.labelN.Text = "N";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(15, 37);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(19, 19);
            this.labelA.TabIndex = 13;
            this.labelA.Text = "a";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "b";
            // 
            // trapRbtn
            // 
            this.trapRbtn.AutoSize = true;
            this.trapRbtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trapRbtn.Location = new System.Drawing.Point(6, 24);
            this.trapRbtn.Name = "trapRbtn";
            this.trapRbtn.Size = new System.Drawing.Size(135, 23);
            this.trapRbtn.TabIndex = 15;
            this.trapRbtn.Text = "Метод Трапеції";
            this.trapRbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.smpRBtn);
            this.groupBox1.Controls.Add(this.prRBtn);
            this.groupBox1.Controls.Add(this.trapRbtn);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(20, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 112);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Виберіть метод";
            // 
            // smpRBtn
            // 
            this.smpRBtn.AutoSize = true;
            this.smpRBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smpRBtn.Location = new System.Drawing.Point(6, 79);
            this.smpRBtn.Name = "smpRBtn";
            this.smpRBtn.Size = new System.Drawing.Size(148, 23);
            this.smpRBtn.TabIndex = 17;
            this.smpRBtn.Text = "Метод Сімпсона";
            this.smpRBtn.UseVisualStyleBackColor = true;
            // 
            // prRBtn
            // 
            this.prRBtn.AutoSize = true;
            this.prRBtn.Checked = true;
            this.prRBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prRBtn.Location = new System.Drawing.Point(6, 52);
            this.prRBtn.Name = "prRBtn";
            this.prRBtn.Size = new System.Drawing.Size(179, 23);
            this.prRBtn.TabIndex = 16;
            this.prRBtn.TabStop = true;
            this.prRBtn.Text = "Метод Прямокутників";
            this.prRBtn.UseVisualStyleBackColor = true;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resultLabel.Location = new System.Drawing.Point(389, 551);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 23);
            this.resultLabel.TabIndex = 17;
            // 
            // mainGraphCBox
            // 
            this.mainGraphCBox.AutoSize = true;
            this.mainGraphCBox.Checked = true;
            this.mainGraphCBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mainGraphCBox.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainGraphCBox.Location = new System.Drawing.Point(993, 232);
            this.mainGraphCBox.Name = "mainGraphCBox";
            this.mainGraphCBox.Size = new System.Drawing.Size(130, 21);
            this.mainGraphCBox.TabIndex = 19;
            this.mainGraphCBox.Text = "Головний графік";
            this.mainGraphCBox.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "x^2\\sin(10x)+x^4-10x^3+25x^2-5x+1",
            "sin(x)",
            "sin(x)/x",
            "Check Line"});
            this.comboBox1.Location = new System.Drawing.Point(57, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "f(x)=";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nUpDb);
            this.groupBox2.Controls.Add(this.nUpDa);
            this.groupBox2.Controls.Add(this.nUpDn);
            this.groupBox2.Controls.Add(this.labelN);
            this.groupBox2.Controls.Add(this.labelA);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(20, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 118);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Введіть дані";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1154, 587);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.mainGraphCBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Simpson\'s Rule";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nUpDa;
        private System.Windows.Forms.NumericUpDown nUpDb;
        private System.Windows.Forms.NumericUpDown nUpDn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton trapRbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton smpRBtn;
        private System.Windows.Forms.RadioButton prRBtn;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.CheckBox mainGraphCBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

