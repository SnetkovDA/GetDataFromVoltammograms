namespace Simplifier
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileDroppedList = new System.Windows.Forms.ToolStripMenuItem();
            this.openButDropList = new System.Windows.Forms.ToolStripMenuItem();
            this.saveButDropList = new System.Windows.Forms.ToolStripMenuItem();
            this.closeButDropList = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllPlots = new System.Windows.Forms.ToolStripMenuItem();
            this.eTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayCalculatedPlot = new System.Windows.Forms.ToolStripMenuItem();
            this.axesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.findPointsButtom = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleOut = new System.Windows.Forms.Label();
            this.grapficsOut = new System.Windows.Forms.PictureBox();
            this.yAxesLabel = new System.Windows.Forms.Label();
            this.XaxisLabel = new System.Windows.Forms.Label();
            this.powerVal = new System.Windows.Forms.NumericUpDown();
            this.polynomLabel = new System.Windows.Forms.Label();
            this.mainPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.allData = new System.Data.DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deltaValue = new System.Windows.Forms.NumericUpDown();
            this.shiftAfterLast = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grapficsOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftAfterLast)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileDroppedList,
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileDroppedList
            // 
            this.fileDroppedList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButDropList,
            this.saveButDropList,
            this.closeButDropList});
            this.fileDroppedList.Name = "fileDroppedList";
            this.fileDroppedList.Size = new System.Drawing.Size(37, 20);
            this.fileDroppedList.Text = "File";
            // 
            // openButDropList
            // 
            this.openButDropList.Name = "openButDropList";
            this.openButDropList.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openButDropList.Size = new System.Drawing.Size(148, 22);
            this.openButDropList.Text = "Open";
            this.openButDropList.Click += new System.EventHandler(this.openButDropList_Click);
            // 
            // saveButDropList
            // 
            this.saveButDropList.Name = "saveButDropList";
            this.saveButDropList.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveButDropList.Size = new System.Drawing.Size(148, 22);
            this.saveButDropList.Text = "Save";
            this.saveButDropList.Click += new System.EventHandler(this.saveButDropList_Click);
            // 
            // closeButDropList
            // 
            this.closeButDropList.Name = "closeButDropList";
            this.closeButDropList.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeButDropList.Size = new System.Drawing.Size(148, 22);
            this.closeButDropList.Text = "Close";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayAllToolStripMenuItem,
            this.axesToolStripMenuItem,
            this.findPointsButtom});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // displayAllToolStripMenuItem
            // 
            this.displayAllToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllPlots,
            this.eTToolStripMenuItem,
            this.displayCalculatedPlot});
            this.displayAllToolStripMenuItem.Name = "displayAllToolStripMenuItem";
            this.displayAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.displayAllToolStripMenuItem.Text = "Display";
            this.displayAllToolStripMenuItem.Click += new System.EventHandler(this.displayAllToolStripMenuItem_Click);
            // 
            // showAllPlots
            // 
            this.showAllPlots.Name = "showAllPlots";
            this.showAllPlots.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.showAllPlots.Size = new System.Drawing.Size(208, 22);
            this.showAllPlots.Text = "All plots";
            this.showAllPlots.Click += new System.EventHandler(this.iTToolStripMenuItem_Click);
            // 
            // eTToolStripMenuItem
            // 
            this.eTToolStripMenuItem.Name = "eTToolStripMenuItem";
            this.eTToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.eTToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.eTToolStripMenuItem.Text = "Source plot";
            this.eTToolStripMenuItem.Click += new System.EventHandler(this.eTToolStripMenuItem_Click);
            // 
            // displayCalculatedPlot
            // 
            this.displayCalculatedPlot.Name = "displayCalculatedPlot";
            this.displayCalculatedPlot.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.displayCalculatedPlot.Size = new System.Drawing.Size(208, 22);
            this.displayCalculatedPlot.Text = "Calculated plot";
            this.displayCalculatedPlot.Click += new System.EventHandler(this.displayCalculatedPlot_Click);
            // 
            // axesToolStripMenuItem
            // 
            this.axesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iTToolStripMenuItem1,
            this.iUToolStripMenuItem});
            this.axesToolStripMenuItem.Name = "axesToolStripMenuItem";
            this.axesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.axesToolStripMenuItem.Text = "Axis";
            // 
            // iTToolStripMenuItem1
            // 
            this.iTToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iToolStripMenuItem,
            this.uToolStripMenuItem,
            this.tToolStripMenuItem});
            this.iTToolStripMenuItem1.Name = "iTToolStripMenuItem1";
            this.iTToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.iTToolStripMenuItem1.Text = "X-axis";
            // 
            // iToolStripMenuItem
            // 
            this.iToolStripMenuItem.CheckOnClick = true;
            this.iToolStripMenuItem.Name = "iToolStripMenuItem";
            this.iToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.iToolStripMenuItem.Text = "Current";
            this.iToolStripMenuItem.Click += new System.EventHandler(this.iToolStripMenuItem_Click);
            // 
            // uToolStripMenuItem
            // 
            this.uToolStripMenuItem.CheckOnClick = true;
            this.uToolStripMenuItem.Name = "uToolStripMenuItem";
            this.uToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.uToolStripMenuItem.Text = "Potentioal";
            this.uToolStripMenuItem.Click += new System.EventHandler(this.uToolStripMenuItem_Click);
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.CheckOnClick = true;
            this.tToolStripMenuItem.Name = "tToolStripMenuItem";
            this.tToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.tToolStripMenuItem.Text = "Time";
            this.tToolStripMenuItem.Click += new System.EventHandler(this.tToolStripMenuItem_Click);
            // 
            // iUToolStripMenuItem
            // 
            this.iUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.iUToolStripMenuItem.Name = "iUToolStripMenuItem";
            this.iUToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.iUToolStripMenuItem.Text = "Y-axis";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem1.Text = "Current";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem2.Text = "Potentioal";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem3.Text = "Time";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // findPointsButtom
            // 
            this.findPointsButtom.Name = "findPointsButtom";
            this.findPointsButtom.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.findPointsButtom.Size = new System.Drawing.Size(152, 22);
            this.findPointsButtom.Text = "Find points";
            this.findPointsButtom.Click += new System.EventHandler(this.findPointsButtom_Click);
            // 
            // consoleOut
            // 
            this.consoleOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.consoleOut.AutoSize = true;
            this.consoleOut.Location = new System.Drawing.Point(12, 410);
            this.consoleOut.Name = "consoleOut";
            this.consoleOut.Size = new System.Drawing.Size(45, 13);
            this.consoleOut.TabIndex = 1;
            this.consoleOut.Text = "Console";
            // 
            // grapficsOut
            // 
            this.grapficsOut.Location = new System.Drawing.Point(39, 27);
            this.grapficsOut.Name = "grapficsOut";
            this.grapficsOut.Size = new System.Drawing.Size(730, 380);
            this.grapficsOut.TabIndex = 2;
            this.grapficsOut.TabStop = false;
            this.grapficsOut.Visible = false;
            // 
            // yAxesLabel
            // 
            this.yAxesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.yAxesLabel.AutoSize = true;
            this.yAxesLabel.Location = new System.Drawing.Point(25, 200);
            this.yAxesLabel.Name = "yAxesLabel";
            this.yAxesLabel.Size = new System.Drawing.Size(14, 13);
            this.yAxesLabel.TabIndex = 4;
            this.yAxesLabel.Text = "Y";
            // 
            // XaxisLabel
            // 
            this.XaxisLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.XaxisLabel.AutoSize = true;
            this.XaxisLabel.Location = new System.Drawing.Point(457, 351);
            this.XaxisLabel.Name = "XaxisLabel";
            this.XaxisLabel.Size = new System.Drawing.Size(14, 13);
            this.XaxisLabel.TabIndex = 16;
            this.XaxisLabel.Text = "X";
            // 
            // powerVal
            // 
            this.powerVal.Location = new System.Drawing.Point(174, 40);
            this.powerVal.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.powerVal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.powerVal.Name = "powerVal";
            this.powerVal.Size = new System.Drawing.Size(30, 23);
            this.powerVal.TabIndex = 17;
            this.powerVal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // polynomLabel
            // 
            this.polynomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.polynomLabel.AutoSize = true;
            this.polynomLabel.Location = new System.Drawing.Point(7, 394);
            this.polynomLabel.Name = "polynomLabel";
            this.polynomLabel.Size = new System.Drawing.Size(47, 13);
            this.polynomLabel.TabIndex = 18;
            this.polynomLabel.Text = "Polynom";
            // 
            // mainPlot
            // 
            this.mainPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea3.Area3DStyle.PointDepth = 10;
            chartArea3.Area3DStyle.PointGapDepth = 10;
            chartArea3.Area3DStyle.WallWidth = 2;
            chartArea3.AxisY.ScaleView.SmallScrollMinSize = 0.0001D;
            chartArea3.CursorX.LineColor = System.Drawing.Color.Blue;
            chartArea3.CursorY.Interval = 0.0001D;
            chartArea3.CursorY.LineColor = System.Drawing.Color.Blue;
            chartArea3.Name = "ChartArea1";
            this.mainPlot.ChartAreas.Add(chartArea3);
            this.mainPlot.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mainPlot.IsSoftShadows = false;
            legend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.mainPlot.Legends.Add(legend3);
            this.mainPlot.Location = new System.Drawing.Point(0, 27);
            this.mainPlot.MaximumSize = new System.Drawing.Size(7800, 3800);
            this.mainPlot.MinimumSize = new System.Drawing.Size(780, 380);
            this.mainPlot.Name = "mainPlot";
            this.mainPlot.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series15.Legend = "Legend1";
            series15.LegendText = "Исходные значения";
            series15.Name = "Series1";
            series15.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series15.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series16.Legend = "Legend1";
            series16.LegendText = "Найденные значения 1";
            series16.Name = "Series2";
            series16.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series17.Legend = "Legend1";
            series17.LegendText = "Найденные значения 2";
            series17.Name = "Series3";
            series17.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series18.Legend = "Legend1";
            series18.LegendText = "Разделяющий полином";
            series18.Name = "Series4";
            series18.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series19.Legend = "Legend1";
            series19.LegendText = "Исходные данные по модулю";
            series19.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series19.Name = "Series5";
            series19.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series20.Legend = "Legend1";
            series20.LegendText = "Искомые точки 1";
            series20.MarkerColor = System.Drawing.Color.DarkRed;
            series20.MarkerSize = 8;
            series20.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series20.Name = "Series6";
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series21.Legend = "Legend1";
            series21.LegendText = "Искомые точки 2";
            series21.MarkerColor = System.Drawing.Color.Red;
            series21.MarkerSize = 8;
            series21.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series21.Name = "Series7";
            this.mainPlot.Series.Add(series15);
            this.mainPlot.Series.Add(series16);
            this.mainPlot.Series.Add(series17);
            this.mainPlot.Series.Add(series18);
            this.mainPlot.Series.Add(series19);
            this.mainPlot.Series.Add(series20);
            this.mainPlot.Series.Add(series21);
            this.mainPlot.Size = new System.Drawing.Size(780, 380);
            this.mainPlot.TabIndex = 19;
            this.mainPlot.TabStop = false;
            this.mainPlot.Text = "AllGraphics";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            title3.Name = "SourceGraphic";
            title3.Text = "График";
            title3.Visible = false;
            this.mainPlot.Titles.Add(title3);
            // 
            // allData
            // 
            this.allData.DataSetName = "NewDataSet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 34);
            this.label1.TabIndex = 20;
            this.label1.Text = "Степень разделяющего\r\nполинома";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ширина линии";
            // 
            // deltaValue
            // 
            this.deltaValue.DecimalPlaces = 4;
            this.deltaValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            262144});
            this.deltaValue.Location = new System.Drawing.Point(142, 77);
            this.deltaValue.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.deltaValue.Name = "deltaValue";
            this.deltaValue.Size = new System.Drawing.Size(62, 23);
            this.deltaValue.TabIndex = 22;
            this.deltaValue.ThousandsSeparator = true;
            // 
            // shiftAfterLast
            // 
            this.shiftAfterLast.Location = new System.Drawing.Point(174, 116);
            this.shiftAfterLast.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.shiftAfterLast.Name = "shiftAfterLast";
            this.shiftAfterLast.Size = new System.Drawing.Size(30, 23);
            this.shiftAfterLast.TabIndex = 23;
            this.shiftAfterLast.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Точек от последней";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.shiftAfterLast);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.powerVal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.deltaValue);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(558, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 148);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Свойства";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 431);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.XaxisLabel);
            this.Controls.Add(this.yAxesLabel);
            this.Controls.Add(this.polynomLabel);
            this.Controls.Add(this.consoleOut);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.mainPlot);
            this.Controls.Add(this.grapficsOut);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(8000, 4700);
            this.MinimumSize = new System.Drawing.Size(800, 470);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get points from VAG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grapficsOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftAfterLast)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileDroppedList;
        private System.Windows.Forms.ToolStripMenuItem openButDropList;
        private System.Windows.Forms.ToolStripMenuItem saveButDropList;
        private System.Windows.Forms.ToolStripMenuItem closeButDropList;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findPointsButtom;
        private System.Windows.Forms.Label consoleOut;
        private System.Windows.Forms.ToolStripMenuItem displayAllToolStripMenuItem;
        private System.Windows.Forms.PictureBox grapficsOut;
        private System.Windows.Forms.ToolStripMenuItem showAllPlots;
        private System.Windows.Forms.ToolStripMenuItem eTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayCalculatedPlot;
        private System.Windows.Forms.ToolStripMenuItem axesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label yAxesLabel;
        private System.Windows.Forms.Label XaxisLabel;
        private System.Windows.Forms.NumericUpDown powerVal;
        private System.Windows.Forms.Label polynomLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainPlot;
        private System.Data.DataSet allData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown deltaValue;
        private System.Windows.Forms.NumericUpDown shiftAfterLast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

