namespace Singular
{
    partial class Window
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SourceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Animate_Timer = new System.Windows.Forms.Timer(this.components);
            this.InfoBar = new System.Windows.Forms.StatusStrip();
            this.EplisonInfoText = new System.Windows.Forms.ToolStripStatusLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.percentText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.arrayText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.alphaText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.disp3Text = new System.Windows.Forms.TextBox();
            this.disp2Text = new System.Windows.Forms.TextBox();
            this.disp1Text = new System.Windows.Forms.TextBox();
            this.center3Text = new System.Windows.Forms.TextBox();
            this.center2Text = new System.Windows.Forms.TextBox();
            this.center1Text = new System.Windows.Forms.TextBox();
            this.amp3Text = new System.Windows.Forms.TextBox();
            this.amp2Text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.amp1Text = new System.Windows.Forms.TextBox();
            this.ImpulseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ConvolChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ReseachChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DrawFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.StartStopAnimateFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.ResetFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.normalParamText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SourceChart)).BeginInit();
            this.InfoBar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImpulseChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConvolChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReseachChart)).BeginInit();
            this.SuspendLayout();
            // 
            // SourceChart
            // 
            this.SourceChart.BorderlineColor = System.Drawing.Color.Black;
            this.SourceChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.SourceChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.SourceChart.Legends.Add(legend1);
            this.SourceChart.Location = new System.Drawing.Point(16, 90);
            this.SourceChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SourceChart.Name = "SourceChart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.LegendText = "Сигнал";
            series1.Name = "SignalSeries";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.DarkOrange;
            series2.Legend = "Legend1";
            series2.LegendText = "Новый";
            series2.Name = "RestoredSeries";
            this.SourceChart.Series.Add(series1);
            this.SourceChart.Series.Add(series2);
            this.SourceChart.Size = new System.Drawing.Size(764, 370);
            this.SourceChart.TabIndex = 0;
            this.SourceChart.Text = "chart1";
            // 
            // Animate_Timer
            // 
            this.Animate_Timer.Interval = 10;
            this.Animate_Timer.Tick += new System.EventHandler(this.Animate_Timer_Tick);
            // 
            // InfoBar
            // 
            this.InfoBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.InfoBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.InfoBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EplisonInfoText});
            this.InfoBar.Location = new System.Drawing.Point(0, 1000);
            this.InfoBar.Name = "InfoBar";
            this.InfoBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.InfoBar.Size = new System.Drawing.Size(1568, 22);
            this.InfoBar.TabIndex = 1;
            this.InfoBar.Text = "statusStrip1";
            // 
            // EplisonInfoText
            // 
            this.EplisonInfoText.Name = "EplisonInfoText";
            this.EplisonInfoText.Size = new System.Drawing.Size(0, 16);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(605, 949);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 23);
            this.label11.TabIndex = 28;
            this.label11.Text = "Порог, %";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // percentText
            // 
            this.percentText.Location = new System.Drawing.Point(813, 948);
            this.percentText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.percentText.Multiline = true;
            this.percentText.Name = "percentText";
            this.percentText.Size = new System.Drawing.Size(53, 24);
            this.percentText.TabIndex = 27;
            this.percentText.Text = "12";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(605, 885);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Количество отсчетов";
            // 
            // arrayText
            // 
            this.arrayText.Location = new System.Drawing.Point(813, 884);
            this.arrayText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.arrayText.Name = "arrayText";
            this.arrayText.Size = new System.Drawing.Size(53, 22);
            this.arrayText.TabIndex = 23;
            this.arrayText.Text = "60";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.alphaText);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(379, 850);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(225, 132);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Имп. характеристика";
            // 
            // alphaText
            // 
            this.alphaText.Location = new System.Drawing.Point(148, 38);
            this.alphaText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.alphaText.Name = "alphaText";
            this.alphaText.Size = new System.Drawing.Size(53, 26);
            this.alphaText.TabIndex = 17;
            this.alphaText.Text = "2";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(8, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 27);
            this.label9.TabIndex = 16;
            this.label9.Text = "Параметр ɑ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.disp3Text);
            this.groupBox3.Controls.Add(this.disp2Text);
            this.groupBox3.Controls.Add(this.disp1Text);
            this.groupBox3.Controls.Add(this.center3Text);
            this.groupBox3.Controls.Add(this.center2Text);
            this.groupBox3.Controls.Add(this.center1Text);
            this.groupBox3.Controls.Add(this.amp3Text);
            this.groupBox3.Controls.Add(this.amp2Text);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.amp1Text);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(16, 849);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(355, 133);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Параметры графика";
            // 
            // disp3Text
            // 
            this.disp3Text.Location = new System.Drawing.Point(284, 91);
            this.disp3Text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.disp3Text.Name = "disp3Text";
            this.disp3Text.Size = new System.Drawing.Size(53, 26);
            this.disp3Text.TabIndex = 17;
            this.disp3Text.Text = "2.9";
            // 
            // disp2Text
            // 
            this.disp2Text.Location = new System.Drawing.Point(221, 91);
            this.disp2Text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.disp2Text.Name = "disp2Text";
            this.disp2Text.Size = new System.Drawing.Size(53, 26);
            this.disp2Text.TabIndex = 16;
            this.disp2Text.Text = "3.2";
            // 
            // disp1Text
            // 
            this.disp1Text.Location = new System.Drawing.Point(159, 91);
            this.disp1Text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.disp1Text.Name = "disp1Text";
            this.disp1Text.Size = new System.Drawing.Size(53, 26);
            this.disp1Text.TabIndex = 15;
            this.disp1Text.Text = "2.4";
            // 
            // center3Text
            // 
            this.center3Text.Location = new System.Drawing.Point(284, 58);
            this.center3Text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.center3Text.Name = "center3Text";
            this.center3Text.Size = new System.Drawing.Size(53, 26);
            this.center3Text.TabIndex = 14;
            this.center3Text.Text = "49";
            // 
            // center2Text
            // 
            this.center2Text.Location = new System.Drawing.Point(221, 58);
            this.center2Text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.center2Text.Name = "center2Text";
            this.center2Text.Size = new System.Drawing.Size(53, 26);
            this.center2Text.TabIndex = 13;
            this.center2Text.Text = "34";
            // 
            // center1Text
            // 
            this.center1Text.Location = new System.Drawing.Point(159, 58);
            this.center1Text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.center1Text.Name = "center1Text";
            this.center1Text.Size = new System.Drawing.Size(53, 26);
            this.center1Text.TabIndex = 12;
            this.center1Text.Text = "10";
            // 
            // amp3Text
            // 
            this.amp3Text.Location = new System.Drawing.Point(284, 23);
            this.amp3Text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amp3Text.Name = "amp3Text";
            this.amp3Text.Size = new System.Drawing.Size(53, 26);
            this.amp3Text.TabIndex = 11;
            this.amp3Text.Text = "2.6";
            // 
            // amp2Text
            // 
            this.amp2Text.Location = new System.Drawing.Point(221, 23);
            this.amp2Text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amp2Text.Name = "amp2Text";
            this.amp2Text.Size = new System.Drawing.Size(53, 26);
            this.amp2Text.TabIndex = 10;
            this.amp2Text.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(32, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дисперсия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(19, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Центр купола";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Амплитуда";
            // 
            // amp1Text
            // 
            this.amp1Text.Location = new System.Drawing.Point(159, 23);
            this.amp1Text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amp1Text.Name = "amp1Text";
            this.amp1Text.Size = new System.Drawing.Size(53, 26);
            this.amp1Text.TabIndex = 5;
            this.amp1Text.Text = "2.2";
            // 
            // ImpulseChart
            // 
            this.ImpulseChart.BorderlineColor = System.Drawing.Color.Black;
            this.ImpulseChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.ImpulseChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ImpulseChart.Legends.Add(legend2);
            this.ImpulseChart.Location = new System.Drawing.Point(788, 90);
            this.ImpulseChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ImpulseChart.Name = "ImpulseChart";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.LegendText = "Импульс";
            series3.Name = "ImpulseSeries";
            this.ImpulseChart.Series.Add(series3);
            this.ImpulseChart.Size = new System.Drawing.Size(764, 370);
            this.ImpulseChart.TabIndex = 35;
            this.ImpulseChart.Text = "chart2";
            // 
            // ConvolChart
            // 
            this.ConvolChart.BorderlineColor = System.Drawing.Color.Black;
            this.ConvolChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.Name = "ChartArea1";
            this.ConvolChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ConvolChart.Legends.Add(legend3);
            this.ConvolChart.Location = new System.Drawing.Point(16, 468);
            this.ConvolChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConvolChart.Name = "ConvolChart";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series4.Legend = "Legend1";
            series4.LegendText = "Свёртка";
            series4.Name = "ConvolSeries";
            this.ConvolChart.Series.Add(series4);
            this.ConvolChart.Size = new System.Drawing.Size(764, 370);
            this.ConvolChart.TabIndex = 36;
            this.ConvolChart.Text = "chart3";
            // 
            // ReseachChart
            // 
            this.ReseachChart.BorderlineColor = System.Drawing.Color.Black;
            this.ReseachChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.Name = "ChartArea1";
            this.ReseachChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.ReseachChart.Legends.Add(legend4);
            this.ReseachChart.Location = new System.Drawing.Point(788, 468);
            this.ReseachChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReseachChart.Name = "ReseachChart";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.Green;
            series5.Legend = "Legend1";
            series5.LegendText = "Исследование";
            series5.Name = "ResearchSeries";
            this.ReseachChart.Series.Add(series5);
            this.ReseachChart.Size = new System.Drawing.Size(764, 370);
            this.ReseachChart.TabIndex = 37;
            this.ReseachChart.Text = "chart4";
            // 
            // DrawFlatButton
            // 
            this.DrawFlatButton.AutoSize = true;
            this.DrawFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DrawFlatButton.Depth = 0;
            this.DrawFlatButton.Location = new System.Drawing.Point(877, 884);
            this.DrawFlatButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.DrawFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DrawFlatButton.Name = "DrawFlatButton";
            this.DrawFlatButton.Primary = false;
            this.DrawFlatButton.Size = new System.Drawing.Size(126, 36);
            this.DrawFlatButton.TabIndex = 38;
            this.DrawFlatButton.Text = "Нарисовать";
            this.DrawFlatButton.UseVisualStyleBackColor = true;
            this.DrawFlatButton.Click += new System.EventHandler(this.DrawFlatButton_Click);
            // 
            // StartStopAnimateFlatButton
            // 
            this.StartStopAnimateFlatButton.AutoSize = true;
            this.StartStopAnimateFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartStopAnimateFlatButton.Depth = 0;
            this.StartStopAnimateFlatButton.Location = new System.Drawing.Point(1025, 884);
            this.StartStopAnimateFlatButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.StartStopAnimateFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.StartStopAnimateFlatButton.Name = "StartStopAnimateFlatButton";
            this.StartStopAnimateFlatButton.Primary = false;
            this.StartStopAnimateFlatButton.Size = new System.Drawing.Size(223, 36);
            this.StartStopAnimateFlatButton.TabIndex = 41;
            this.StartStopAnimateFlatButton.Text = "Начать исследование";
            this.StartStopAnimateFlatButton.UseVisualStyleBackColor = true;
            this.StartStopAnimateFlatButton.Click += new System.EventHandler(this.StartStopAnimateFlatButton_Click);
            // 
            // ResetFlatButton
            // 
            this.ResetFlatButton.AutoSize = true;
            this.ResetFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ResetFlatButton.Depth = 0;
            this.ResetFlatButton.Location = new System.Drawing.Point(877, 937);
            this.ResetFlatButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.ResetFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ResetFlatButton.Name = "ResetFlatButton";
            this.ResetFlatButton.Primary = false;
            this.ResetFlatButton.Size = new System.Drawing.Size(69, 36);
            this.ResetFlatButton.TabIndex = 42;
            this.ResetFlatButton.Text = "Сброс";
            this.ResetFlatButton.UseVisualStyleBackColor = true;
            this.ResetFlatButton.Click += new System.EventHandler(this.ResetFlatButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(605, 917);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 23);
            this.label1.TabIndex = 44;
            this.label1.Text = "Усреднение";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // normalParamText
            // 
            this.normalParamText.Location = new System.Drawing.Point(813, 916);
            this.normalParamText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.normalParamText.Multiline = true;
            this.normalParamText.Name = "normalParamText";
            this.normalParamText.Size = new System.Drawing.Size(53, 24);
            this.normalParamText.TabIndex = 43;
            this.normalParamText.Text = "10";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 1022);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.normalParamText);
            this.Controls.Add(this.ResetFlatButton);
            this.Controls.Add(this.StartStopAnimateFlatButton);
            this.Controls.Add(this.DrawFlatButton);
            this.Controls.Add(this.ReseachChart);
            this.Controls.Add(this.ConvolChart);
            this.Controls.Add(this.ImpulseChart);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.percentText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.arrayText);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.InfoBar);
            this.Controls.Add(this.SourceChart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Window";
            this.Text = "Восстановление сигнала";
            this.Load += new System.EventHandler(this.Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SourceChart)).EndInit();
            this.InfoBar.ResumeLayout(false);
            this.InfoBar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImpulseChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConvolChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReseachChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart SourceChart;
        private System.Windows.Forms.Timer Animate_Timer;
        private System.Windows.Forms.StatusStrip InfoBar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox percentText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox arrayText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox alphaText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart ImpulseChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ConvolChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ReseachChart;
        private MaterialSkin.Controls.MaterialFlatButton DrawFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton StartStopAnimateFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton ResetFlatButton;
        private System.Windows.Forms.TextBox disp3Text;
        private System.Windows.Forms.TextBox disp2Text;
        private System.Windows.Forms.TextBox disp1Text;
        private System.Windows.Forms.TextBox center3Text;
        private System.Windows.Forms.TextBox center2Text;
        private System.Windows.Forms.TextBox center1Text;
        private System.Windows.Forms.TextBox amp1Text;
        private System.Windows.Forms.TextBox amp2Text;
        private System.Windows.Forms.TextBox amp3Text;
        private System.Windows.Forms.ToolStripStatusLabel EplisonInfoText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox normalParamText;
    }
}

