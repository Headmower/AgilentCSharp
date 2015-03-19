namespace AgilentCSharp
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.connectGroup = new System.Windows.Forms.GroupBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.addressField = new System.Windows.Forms.TextBox();
            this.freqOptionsGroup = new System.Windows.Forms.GroupBox();
            this.powerOptionsGroup = new System.Windows.Forms.GroupBox();
            this.powerField = new System.Windows.Forms.TextBox();
            this.setMeasurementOptions = new System.Windows.Forms.Button();
            this.bandwidthOptionsGroup = new System.Windows.Forms.GroupBox();
            this.bandwidthField = new System.Windows.Forms.TextBox();
            this.pointNumberOptionsGroup = new System.Windows.Forms.GroupBox();
            this.pointNumberField = new System.Windows.Forms.NumericUpDown();
            this.stopFreqOptionsGroup = new System.Windows.Forms.GroupBox();
            this.stopFreqField = new System.Windows.Forms.TextBox();
            this.stopFreqMultiplierBox = new System.Windows.Forms.ComboBox();
            this.startFreqOptionsGroup = new System.Windows.Forms.GroupBox();
            this.startFreqField = new System.Windows.Forms.TextBox();
            this.startFreqMultiplierBox = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.metalCalGroup = new System.Windows.Forms.GroupBox();
            this.saveCSVMetal = new System.Windows.Forms.Button();
            this.saveS1PMetal = new System.Windows.Forms.Button();
            this.measureMetalButton = new System.Windows.Forms.Button();
            this.metalGraphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.spaceCalGroup = new System.Windows.Forms.GroupBox();
            this.saveCSVSpace = new System.Windows.Forms.Button();
            this.saveS1PSpace = new System.Windows.Forms.Button();
            this.measureSpaceButton = new System.Windows.Forms.Button();
            this.spaceGraphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.outputGroup = new System.Windows.Forms.GroupBox();
            this.saveCSVButton = new System.Windows.Forms.Button();
            this.saveS1PButton = new System.Windows.Forms.Button();
            this.withCalCheckbox = new System.Windows.Forms.CheckBox();
            this.measListGroup = new System.Windows.Forms.GroupBox();
            this.measList = new System.Windows.Forms.CheckedListBox();
            this.graphGroup = new System.Windows.Forms.GroupBox();
            this.measGraphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.outTextGroup = new System.Windows.Forms.GroupBox();
            this.outText = new System.Windows.Forms.TextBox();
            this.measureButtonsGroup = new System.Windows.Forms.GroupBox();
            this.measObjectButton = new System.Windows.Forms.Button();
            this.saveS1PDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveCSVDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveMassCSVDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveMassS1PDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.connectGroup.SuspendLayout();
            this.freqOptionsGroup.SuspendLayout();
            this.powerOptionsGroup.SuspendLayout();
            this.bandwidthOptionsGroup.SuspendLayout();
            this.pointNumberOptionsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointNumberField)).BeginInit();
            this.stopFreqOptionsGroup.SuspendLayout();
            this.startFreqOptionsGroup.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.metalCalGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metalGraphic)).BeginInit();
            this.spaceCalGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spaceGraphic)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.outputGroup.SuspendLayout();
            this.measListGroup.SuspendLayout();
            this.graphGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.measGraphic)).BeginInit();
            this.outTextGroup.SuspendLayout();
            this.measureButtonsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(914, 690);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.connectGroup);
            this.tabPage3.Controls.Add(this.freqOptionsGroup);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(906, 664);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Настройки измерений";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // connectGroup
            // 
            this.connectGroup.Controls.Add(this.connectButton);
            this.connectGroup.Controls.Add(this.addressField);
            this.connectGroup.Location = new System.Drawing.Point(5, 3);
            this.connectGroup.Name = "connectGroup";
            this.connectGroup.Size = new System.Drawing.Size(117, 79);
            this.connectGroup.TabIndex = 22;
            this.connectGroup.TabStop = false;
            this.connectGroup.Text = "Подключение";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(7, 43);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(104, 31);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Подключиться";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // addressField
            // 
            this.addressField.Location = new System.Drawing.Point(7, 19);
            this.addressField.Name = "addressField";
            this.addressField.Size = new System.Drawing.Size(104, 20);
            this.addressField.TabIndex = 2;
            this.addressField.Text = "\\\\192.168.1.100";
            // 
            // freqOptionsGroup
            // 
            this.freqOptionsGroup.Controls.Add(this.powerOptionsGroup);
            this.freqOptionsGroup.Controls.Add(this.setMeasurementOptions);
            this.freqOptionsGroup.Controls.Add(this.bandwidthOptionsGroup);
            this.freqOptionsGroup.Controls.Add(this.pointNumberOptionsGroup);
            this.freqOptionsGroup.Controls.Add(this.stopFreqOptionsGroup);
            this.freqOptionsGroup.Controls.Add(this.startFreqOptionsGroup);
            this.freqOptionsGroup.Location = new System.Drawing.Point(675, 3);
            this.freqOptionsGroup.Name = "freqOptionsGroup";
            this.freqOptionsGroup.Size = new System.Drawing.Size(225, 406);
            this.freqOptionsGroup.TabIndex = 0;
            this.freqOptionsGroup.TabStop = false;
            this.freqOptionsGroup.Text = "Настройки измерений";
            // 
            // powerOptionsGroup
            // 
            this.powerOptionsGroup.Controls.Add(this.powerField);
            this.powerOptionsGroup.Location = new System.Drawing.Point(6, 259);
            this.powerOptionsGroup.Name = "powerOptionsGroup";
            this.powerOptionsGroup.Size = new System.Drawing.Size(214, 54);
            this.powerOptionsGroup.TabIndex = 9;
            this.powerOptionsGroup.TabStop = false;
            this.powerOptionsGroup.Text = "Мощность";
            // 
            // powerField
            // 
            this.powerField.Location = new System.Drawing.Point(7, 20);
            this.powerField.Name = "powerField";
            this.powerField.Size = new System.Drawing.Size(172, 20);
            this.powerField.TabIndex = 0;
            this.powerField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericFieldKeyPress);
            // 
            // setMeasurementOptions
            // 
            this.setMeasurementOptions.Location = new System.Drawing.Point(6, 319);
            this.setMeasurementOptions.Name = "setMeasurementOptions";
            this.setMeasurementOptions.Size = new System.Drawing.Size(214, 80);
            this.setMeasurementOptions.TabIndex = 8;
            this.setMeasurementOptions.Text = "Применить";
            this.setMeasurementOptions.UseVisualStyleBackColor = true;
            this.setMeasurementOptions.Click += new System.EventHandler(this.setMeasurementOptions_Click);
            // 
            // bandwidthOptionsGroup
            // 
            this.bandwidthOptionsGroup.Controls.Add(this.bandwidthField);
            this.bandwidthOptionsGroup.Location = new System.Drawing.Point(6, 199);
            this.bandwidthOptionsGroup.Name = "bandwidthOptionsGroup";
            this.bandwidthOptionsGroup.Size = new System.Drawing.Size(214, 54);
            this.bandwidthOptionsGroup.TabIndex = 7;
            this.bandwidthOptionsGroup.TabStop = false;
            this.bandwidthOptionsGroup.Text = "IFBandwidth";
            // 
            // bandwidthField
            // 
            this.bandwidthField.Location = new System.Drawing.Point(7, 20);
            this.bandwidthField.Name = "bandwidthField";
            this.bandwidthField.Size = new System.Drawing.Size(172, 20);
            this.bandwidthField.TabIndex = 0;
            this.bandwidthField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericFieldKeyPress);
            // 
            // pointNumberOptionsGroup
            // 
            this.pointNumberOptionsGroup.Controls.Add(this.pointNumberField);
            this.pointNumberOptionsGroup.Location = new System.Drawing.Point(6, 139);
            this.pointNumberOptionsGroup.Name = "pointNumberOptionsGroup";
            this.pointNumberOptionsGroup.Size = new System.Drawing.Size(214, 54);
            this.pointNumberOptionsGroup.TabIndex = 6;
            this.pointNumberOptionsGroup.TabStop = false;
            this.pointNumberOptionsGroup.Text = "Количество точек разбиения";
            // 
            // pointNumberField
            // 
            this.pointNumberField.Location = new System.Drawing.Point(6, 19);
            this.pointNumberField.Maximum = new decimal(new int[] {
            1345294336,
            9,
            0,
            0});
            this.pointNumberField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pointNumberField.Name = "pointNumberField";
            this.pointNumberField.Size = new System.Drawing.Size(173, 20);
            this.pointNumberField.TabIndex = 2;
            this.pointNumberField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // stopFreqOptionsGroup
            // 
            this.stopFreqOptionsGroup.Controls.Add(this.stopFreqField);
            this.stopFreqOptionsGroup.Controls.Add(this.stopFreqMultiplierBox);
            this.stopFreqOptionsGroup.Location = new System.Drawing.Point(6, 79);
            this.stopFreqOptionsGroup.Name = "stopFreqOptionsGroup";
            this.stopFreqOptionsGroup.Size = new System.Drawing.Size(214, 54);
            this.stopFreqOptionsGroup.TabIndex = 5;
            this.stopFreqOptionsGroup.TabStop = false;
            this.stopFreqOptionsGroup.Text = "Конечная частота";
            // 
            // stopFreqField
            // 
            this.stopFreqField.Location = new System.Drawing.Point(7, 19);
            this.stopFreqField.Name = "stopFreqField";
            this.stopFreqField.Size = new System.Drawing.Size(149, 20);
            this.stopFreqField.TabIndex = 4;
            this.stopFreqField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericFieldKeyPress);
            // 
            // stopFreqMultiplierBox
            // 
            this.stopFreqMultiplierBox.FormattingEnabled = true;
            this.stopFreqMultiplierBox.Items.AddRange(new object[] {
            "Hz",
            "KHz",
            "MHz",
            "GHz"});
            this.stopFreqMultiplierBox.Location = new System.Drawing.Point(162, 19);
            this.stopFreqMultiplierBox.Name = "stopFreqMultiplierBox";
            this.stopFreqMultiplierBox.Size = new System.Drawing.Size(46, 21);
            this.stopFreqMultiplierBox.TabIndex = 3;
            this.stopFreqMultiplierBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stopFreqMultiplierBox_KeyPress);
            // 
            // startFreqOptionsGroup
            // 
            this.startFreqOptionsGroup.Controls.Add(this.startFreqField);
            this.startFreqOptionsGroup.Controls.Add(this.startFreqMultiplierBox);
            this.startFreqOptionsGroup.Location = new System.Drawing.Point(6, 19);
            this.startFreqOptionsGroup.Name = "startFreqOptionsGroup";
            this.startFreqOptionsGroup.Size = new System.Drawing.Size(214, 54);
            this.startFreqOptionsGroup.TabIndex = 4;
            this.startFreqOptionsGroup.TabStop = false;
            this.startFreqOptionsGroup.Text = "Начальная частота";
            // 
            // startFreqField
            // 
            this.startFreqField.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.startFreqField.Location = new System.Drawing.Point(7, 19);
            this.startFreqField.Name = "startFreqField";
            this.startFreqField.Size = new System.Drawing.Size(149, 20);
            this.startFreqField.TabIndex = 4;
            this.startFreqField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericFieldKeyPress);
            // 
            // startFreqMultiplierBox
            // 
            this.startFreqMultiplierBox.FormattingEnabled = true;
            this.startFreqMultiplierBox.Items.AddRange(new object[] {
            "Hz",
            "KHz",
            "MHz",
            "GHz"});
            this.startFreqMultiplierBox.Location = new System.Drawing.Point(162, 19);
            this.startFreqMultiplierBox.Name = "startFreqMultiplierBox";
            this.startFreqMultiplierBox.Size = new System.Drawing.Size(46, 21);
            this.startFreqMultiplierBox.TabIndex = 3;
            this.startFreqMultiplierBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startFreqMultiplierBox_KeyPress);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.metalCalGroup);
            this.tabPage1.Controls.Add(this.spaceCalGroup);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(906, 664);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Калибровка";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // metalCalGroup
            // 
            this.metalCalGroup.Controls.Add(this.saveCSVMetal);
            this.metalCalGroup.Controls.Add(this.saveS1PMetal);
            this.metalCalGroup.Controls.Add(this.measureMetalButton);
            this.metalCalGroup.Controls.Add(this.metalGraphic);
            this.metalCalGroup.Location = new System.Drawing.Point(7, 334);
            this.metalCalGroup.Name = "metalCalGroup";
            this.metalCalGroup.Size = new System.Drawing.Size(893, 322);
            this.metalCalGroup.TabIndex = 20;
            this.metalCalGroup.TabStop = false;
            this.metalCalGroup.Text = "Закоротка";
            // 
            // saveCSVMetal
            // 
            this.saveCSVMetal.Enabled = false;
            this.saveCSVMetal.Location = new System.Drawing.Point(782, 244);
            this.saveCSVMetal.Name = "saveCSVMetal";
            this.saveCSVMetal.Size = new System.Drawing.Size(105, 33);
            this.saveCSVMetal.TabIndex = 7;
            this.saveCSVMetal.Text = "Сохранить .csv";
            this.saveCSVMetal.UseVisualStyleBackColor = true;
            this.saveCSVMetal.Click += new System.EventHandler(this.saveCSVMetal_Click);
            // 
            // saveS1PMetal
            // 
            this.saveS1PMetal.Enabled = false;
            this.saveS1PMetal.Location = new System.Drawing.Point(782, 283);
            this.saveS1PMetal.Name = "saveS1PMetal";
            this.saveS1PMetal.Size = new System.Drawing.Size(105, 33);
            this.saveS1PMetal.TabIndex = 6;
            this.saveS1PMetal.Text = "Сохранить .s1p";
            this.saveS1PMetal.UseVisualStyleBackColor = true;
            this.saveS1PMetal.Click += new System.EventHandler(this.saveS1PMetal_Click);
            // 
            // measureMetalButton
            // 
            this.measureMetalButton.Location = new System.Drawing.Point(783, 66);
            this.measureMetalButton.Name = "measureMetalButton";
            this.measureMetalButton.Size = new System.Drawing.Size(104, 35);
            this.measureMetalButton.TabIndex = 2;
            this.measureMetalButton.Text = "Измерить закоротку";
            this.measureMetalButton.UseVisualStyleBackColor = true;
            this.measureMetalButton.Click += new System.EventHandler(this.measureMetalButton_Click);
            // 
            // metalGraphic
            // 
            this.metalGraphic.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.metalGraphic.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Text;
            chartArea1.Name = "ChartArea1";
            this.metalGraphic.ChartAreas.Add(chartArea1);
            this.metalGraphic.Cursor = System.Windows.Forms.Cursors.Cross;
            this.metalGraphic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend1.Name = "Legend1";
            this.metalGraphic.Legends.Add(legend1);
            this.metalGraphic.Location = new System.Drawing.Point(7, 20);
            this.metalGraphic.Name = "metalGraphic";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.metalGraphic.Series.Add(series1);
            this.metalGraphic.Size = new System.Drawing.Size(880, 295);
            this.metalGraphic.TabIndex = 0;
            this.metalGraphic.Text = "metal";
            // 
            // spaceCalGroup
            // 
            this.spaceCalGroup.Controls.Add(this.saveCSVSpace);
            this.spaceCalGroup.Controls.Add(this.saveS1PSpace);
            this.spaceCalGroup.Controls.Add(this.measureSpaceButton);
            this.spaceCalGroup.Controls.Add(this.spaceGraphic);
            this.spaceCalGroup.Location = new System.Drawing.Point(7, 6);
            this.spaceCalGroup.Name = "spaceCalGroup";
            this.spaceCalGroup.Size = new System.Drawing.Size(893, 322);
            this.spaceCalGroup.TabIndex = 19;
            this.spaceCalGroup.TabStop = false;
            this.spaceCalGroup.Text = "Пространство";
            // 
            // saveCSVSpace
            // 
            this.saveCSVSpace.Enabled = false;
            this.saveCSVSpace.Location = new System.Drawing.Point(782, 243);
            this.saveCSVSpace.Name = "saveCSVSpace";
            this.saveCSVSpace.Size = new System.Drawing.Size(105, 33);
            this.saveCSVSpace.TabIndex = 5;
            this.saveCSVSpace.Text = "Сохранить .csv";
            this.saveCSVSpace.UseVisualStyleBackColor = true;
            this.saveCSVSpace.Click += new System.EventHandler(this.saveCSVSpace_Click);
            // 
            // saveS1PSpace
            // 
            this.saveS1PSpace.Enabled = false;
            this.saveS1PSpace.Location = new System.Drawing.Point(782, 282);
            this.saveS1PSpace.Name = "saveS1PSpace";
            this.saveS1PSpace.Size = new System.Drawing.Size(105, 33);
            this.saveS1PSpace.TabIndex = 4;
            this.saveS1PSpace.Text = "Сохранить .s1p";
            this.saveS1PSpace.UseVisualStyleBackColor = true;
            this.saveS1PSpace.Click += new System.EventHandler(this.saveS1PSpace_Click);
            // 
            // measureSpaceButton
            // 
            this.measureSpaceButton.Location = new System.Drawing.Point(783, 66);
            this.measureSpaceButton.Name = "measureSpaceButton";
            this.measureSpaceButton.Size = new System.Drawing.Size(104, 35);
            this.measureSpaceButton.TabIndex = 1;
            this.measureSpaceButton.Text = "Измерить пространство";
            this.measureSpaceButton.UseVisualStyleBackColor = true;
            this.measureSpaceButton.Click += new System.EventHandler(this.measureSpaceButton_Click);
            // 
            // spaceGraphic
            // 
            this.spaceGraphic.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.spaceGraphic.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Text;
            chartArea2.Name = "ChartArea1";
            this.spaceGraphic.ChartAreas.Add(chartArea2);
            this.spaceGraphic.Cursor = System.Windows.Forms.Cursors.Cross;
            this.spaceGraphic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend2.Name = "Legend1";
            this.spaceGraphic.Legends.Add(legend2);
            this.spaceGraphic.Location = new System.Drawing.Point(7, 20);
            this.spaceGraphic.Name = "spaceGraphic";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.spaceGraphic.Series.Add(series2);
            this.spaceGraphic.Size = new System.Drawing.Size(880, 295);
            this.spaceGraphic.TabIndex = 0;
            this.spaceGraphic.Text = "space";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.outputGroup);
            this.tabPage2.Controls.Add(this.measListGroup);
            this.tabPage2.Controls.Add(this.graphGroup);
            this.tabPage2.Controls.Add(this.outTextGroup);
            this.tabPage2.Controls.Add(this.measureButtonsGroup);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(906, 664);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Измерения объекта";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // outputGroup
            // 
            this.outputGroup.Controls.Add(this.saveCSVButton);
            this.outputGroup.Controls.Add(this.saveS1PButton);
            this.outputGroup.Controls.Add(this.withCalCheckbox);
            this.outputGroup.Location = new System.Drawing.Point(783, 455);
            this.outputGroup.Name = "outputGroup";
            this.outputGroup.Size = new System.Drawing.Size(117, 201);
            this.outputGroup.TabIndex = 22;
            this.outputGroup.TabStop = false;
            this.outputGroup.Text = "Вывод";
            this.outputGroup.Enter += new System.EventHandler(this.outputGroup_Enter);
            // 
            // saveCSVButton
            // 
            this.saveCSVButton.Location = new System.Drawing.Point(6, 123);
            this.saveCSVButton.Name = "saveCSVButton";
            this.saveCSVButton.Size = new System.Drawing.Size(105, 33);
            this.saveCSVButton.TabIndex = 3;
            this.saveCSVButton.Text = "Сохранить .csv";
            this.saveCSVButton.UseVisualStyleBackColor = true;
            this.saveCSVButton.Click += new System.EventHandler(this.saveCSVButton_Click);
            // 
            // saveS1PButton
            // 
            this.saveS1PButton.Location = new System.Drawing.Point(6, 162);
            this.saveS1PButton.Name = "saveS1PButton";
            this.saveS1PButton.Size = new System.Drawing.Size(105, 33);
            this.saveS1PButton.TabIndex = 2;
            this.saveS1PButton.Text = "Сохранить .s1p";
            this.saveS1PButton.UseVisualStyleBackColor = true;
            this.saveS1PButton.Click += new System.EventHandler(this.saveS1PButton_Click);
            // 
            // withCalCheckbox
            // 
            this.withCalCheckbox.AutoSize = true;
            this.withCalCheckbox.Enabled = false;
            this.withCalCheckbox.Location = new System.Drawing.Point(6, 19);
            this.withCalCheckbox.Name = "withCalCheckbox";
            this.withCalCheckbox.Size = new System.Drawing.Size(102, 17);
            this.withCalCheckbox.TabIndex = 1;
            this.withCalCheckbox.Text = "С калибровкой";
            this.withCalCheckbox.UseVisualStyleBackColor = true;
            this.withCalCheckbox.CheckedChanged += new System.EventHandler(this.withCalCheckbox_CheckedChanged);
            // 
            // measListGroup
            // 
            this.measListGroup.Controls.Add(this.measList);
            this.measListGroup.Location = new System.Drawing.Point(445, 389);
            this.measListGroup.Name = "measListGroup";
            this.measListGroup.Size = new System.Drawing.Size(332, 267);
            this.measListGroup.TabIndex = 21;
            this.measListGroup.TabStop = false;
            this.measListGroup.Text = "Список измерений";
            // 
            // measList
            // 
            this.measList.FormattingEnabled = true;
            this.measList.Location = new System.Drawing.Point(6, 19);
            this.measList.Name = "measList";
            this.measList.Size = new System.Drawing.Size(320, 244);
            this.measList.TabIndex = 0;
            this.measList.SelectedIndexChanged += new System.EventHandler(this.measList_SelectedIndexChanged);
            // 
            // graphGroup
            // 
            this.graphGroup.Controls.Add(this.measGraphic);
            this.graphGroup.Location = new System.Drawing.Point(7, 9);
            this.graphGroup.Name = "graphGroup";
            this.graphGroup.Size = new System.Drawing.Size(893, 373);
            this.graphGroup.TabIndex = 18;
            this.graphGroup.TabStop = false;
            this.graphGroup.Text = "График";
            // 
            // measGraphic
            // 
            chartArea3.Name = "ChartArea1";
            this.measGraphic.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.measGraphic.Legends.Add(legend3);
            this.measGraphic.Location = new System.Drawing.Point(7, 11);
            this.measGraphic.Name = "measGraphic";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.measGraphic.Series.Add(series3);
            this.measGraphic.Size = new System.Drawing.Size(880, 356);
            this.measGraphic.TabIndex = 0;
            this.measGraphic.Text = "object";
            // 
            // outTextGroup
            // 
            this.outTextGroup.Controls.Add(this.outText);
            this.outTextGroup.Location = new System.Drawing.Point(7, 388);
            this.outTextGroup.Name = "outTextGroup";
            this.outTextGroup.Size = new System.Drawing.Size(431, 268);
            this.outTextGroup.TabIndex = 17;
            this.outTextGroup.TabStop = false;
            this.outTextGroup.Text = "Вывод с прибора";
            // 
            // outText
            // 
            this.outText.Location = new System.Drawing.Point(6, 19);
            this.outText.Multiline = true;
            this.outText.Name = "outText";
            this.outText.ReadOnly = true;
            this.outText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outText.Size = new System.Drawing.Size(419, 243);
            this.outText.TabIndex = 3;
            // 
            // measureButtonsGroup
            // 
            this.measureButtonsGroup.Controls.Add(this.measObjectButton);
            this.measureButtonsGroup.Location = new System.Drawing.Point(783, 389);
            this.measureButtonsGroup.Name = "measureButtonsGroup";
            this.measureButtonsGroup.Size = new System.Drawing.Size(117, 59);
            this.measureButtonsGroup.TabIndex = 20;
            this.measureButtonsGroup.TabStop = false;
            this.measureButtonsGroup.Text = "Измерения";
            // 
            // measObjectButton
            // 
            this.measObjectButton.Location = new System.Drawing.Point(6, 19);
            this.measObjectButton.Name = "measObjectButton";
            this.measObjectButton.Size = new System.Drawing.Size(105, 33);
            this.measObjectButton.TabIndex = 0;
            this.measObjectButton.Text = "Измерить объект";
            this.measObjectButton.UseVisualStyleBackColor = true;
            this.measObjectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveS1PDialog
            // 
            this.saveS1PDialog.DefaultExt = "s1p";
            this.saveS1PDialog.Filter = ".s1p Agilent files|*.s1p";
            this.saveS1PDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveS1PDialog_FileOk);
            // 
            // saveCSVDialog
            // 
            this.saveCSVDialog.DefaultExt = "csv";
            this.saveCSVDialog.Filter = ".csv HFSS file|*.csv";
            this.saveCSVDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveCSVDialog_FileOk);
            // 
            // saveMassCSVDialog
            // 
            this.saveMassCSVDialog.DefaultExt = "csv";
            this.saveMassCSVDialog.Filter = ".csv HFSS file|*.csv";
            this.saveMassCSVDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveMassCSVDialog_FileOk);
            // 
            // saveMassS1PDialog
            // 
            this.saveMassS1PDialog.DefaultExt = "s1p";
            this.saveMassS1PDialog.Filter = ".s1p Agilent files|*.s1p";
            this.saveMassS1PDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveMassS1PDialog_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(919, 700);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Agilent C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.connectGroup.ResumeLayout(false);
            this.connectGroup.PerformLayout();
            this.freqOptionsGroup.ResumeLayout(false);
            this.powerOptionsGroup.ResumeLayout(false);
            this.powerOptionsGroup.PerformLayout();
            this.bandwidthOptionsGroup.ResumeLayout(false);
            this.bandwidthOptionsGroup.PerformLayout();
            this.pointNumberOptionsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pointNumberField)).EndInit();
            this.stopFreqOptionsGroup.ResumeLayout(false);
            this.stopFreqOptionsGroup.PerformLayout();
            this.startFreqOptionsGroup.ResumeLayout(false);
            this.startFreqOptionsGroup.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.metalCalGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metalGraphic)).EndInit();
            this.spaceCalGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spaceGraphic)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.outputGroup.ResumeLayout(false);
            this.outputGroup.PerformLayout();
            this.measListGroup.ResumeLayout(false);
            this.graphGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.measGraphic)).EndInit();
            this.outTextGroup.ResumeLayout(false);
            this.outTextGroup.PerformLayout();
            this.measureButtonsGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox measListGroup;
        private System.Windows.Forms.CheckedListBox measList;
        private System.Windows.Forms.GroupBox graphGroup;
        private System.Windows.Forms.GroupBox outTextGroup;
        private System.Windows.Forms.TextBox outText;
        private System.Windows.Forms.GroupBox measureButtonsGroup;
        private System.Windows.Forms.Button measObjectButton;
        private System.Windows.Forms.GroupBox spaceCalGroup;
        private System.Windows.Forms.DataVisualization.Charting.Chart spaceGraphic;
        private System.Windows.Forms.GroupBox metalCalGroup;
        private System.Windows.Forms.DataVisualization.Charting.Chart metalGraphic;
        private System.Windows.Forms.Button measureMetalButton;
        private System.Windows.Forms.Button measureSpaceButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox freqOptionsGroup;
        private System.Windows.Forms.ComboBox startFreqMultiplierBox;
        private System.Windows.Forms.GroupBox startFreqOptionsGroup;
        private System.Windows.Forms.GroupBox stopFreqOptionsGroup;
        private System.Windows.Forms.ComboBox stopFreqMultiplierBox;
        private System.Windows.Forms.GroupBox bandwidthOptionsGroup;
        private System.Windows.Forms.GroupBox pointNumberOptionsGroup;
        private System.Windows.Forms.NumericUpDown pointNumberField;
        private System.Windows.Forms.TextBox bandwidthField;
        private System.Windows.Forms.TextBox stopFreqField;
        private System.Windows.Forms.TextBox startFreqField;
        private System.Windows.Forms.Button setMeasurementOptions;
        private System.Windows.Forms.GroupBox connectGroup;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox addressField;
        private System.Windows.Forms.GroupBox outputGroup;
        private System.Windows.Forms.Button saveS1PButton;
        private System.Windows.Forms.CheckBox withCalCheckbox;
        private System.Windows.Forms.DataVisualization.Charting.Chart measGraphic;
        private System.Windows.Forms.GroupBox powerOptionsGroup;
        private System.Windows.Forms.TextBox powerField;
        private System.Windows.Forms.SaveFileDialog saveS1PDialog;
        private System.Windows.Forms.Button saveCSVButton;
        private System.Windows.Forms.Button saveCSVMetal;
        private System.Windows.Forms.Button saveS1PMetal;
        private System.Windows.Forms.Button saveCSVSpace;
        private System.Windows.Forms.Button saveS1PSpace;
        private System.Windows.Forms.SaveFileDialog saveCSVDialog;
        private System.Windows.Forms.SaveFileDialog saveMassCSVDialog;
        private System.Windows.Forms.SaveFileDialog saveMassS1PDialog;

    }
}

