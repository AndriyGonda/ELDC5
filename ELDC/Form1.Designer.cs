namespace ELDC
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.ComboBoxSerialPorts = new System.Windows.Forms.ComboBox();
            this.ButtonDisconnect = new System.Windows.Forms.Button();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CurrentRelativeVoltage = new System.Windows.Forms.Label();
            this.textBoxDownBoundCalib = new System.Windows.Forms.TextBox();
            this.textBoxUpBoundCalib = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CalibrationButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCalibTimestep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblTotalCharge = new System.Windows.Forms.Label();
            this.StatRelativeVoltageTextBox = new System.Windows.Forms.TextBox();
            this.StatRelVoltageRadioButton = new System.Windows.Forms.RadioButton();
            this.StationaryModeButton = new System.Windows.Forms.Button();
            this.StopProgram = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxAnodeTime = new System.Windows.Forms.TextBox();
            this.textBoxCatodeTime = new System.Windows.Forms.TextBox();
            this.textBoxAnodeImpulse = new System.Windows.Forms.TextBox();
            this.textBoxCatodeImpulse = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxDt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSMAlpha = new System.Windows.Forms.TextBox();
            this.textBoxSMUpBound = new System.Windows.Forms.TextBox();
            this.textBoxSMDownBound = new System.Windows.Forms.TextBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxDepositionCharge = new System.Windows.Forms.TextBox();
            this.textBoxTimeDeposition = new System.Windows.Forms.TextBox();
            this.radioButtonSelectCharge = new System.Windows.Forms.RadioButton();
            this.radioButtonSelectTime = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.ButtonRefresh);
            this.panel1.Controls.Add(this.ComboBoxSerialPorts);
            this.panel1.Controls.Add(this.ButtonDisconnect);
            this.panel1.Controls.Add(this.ButtonConnect);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 75);
            this.panel1.TabIndex = 0;
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Location = new System.Drawing.Point(4, 36);
            this.ButtonRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(132, 28);
            this.ButtonRefresh.TabIndex = 3;
            this.ButtonRefresh.Text = "Refresh";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // ComboBoxSerialPorts
            // 
            this.ComboBoxSerialPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSerialPorts.FormattingEnabled = true;
            this.ComboBoxSerialPorts.Location = new System.Drawing.Point(0, 2);
            this.ComboBoxSerialPorts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxSerialPorts.Name = "ComboBoxSerialPorts";
            this.ComboBoxSerialPorts.Size = new System.Drawing.Size(135, 24);
            this.ComboBoxSerialPorts.TabIndex = 2;
            // 
            // ButtonDisconnect
            // 
            this.ButtonDisconnect.Location = new System.Drawing.Point(163, 36);
            this.ButtonDisconnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonDisconnect.Name = "ButtonDisconnect";
            this.ButtonDisconnect.Size = new System.Drawing.Size(107, 28);
            this.ButtonDisconnect.TabIndex = 1;
            this.ButtonDisconnect.Text = "Disconnect";
            this.ButtonDisconnect.UseVisualStyleBackColor = true;
            this.ButtonDisconnect.Click += new System.EventHandler(this.ButtonDisconnect_Click);
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(163, 2);
            this.ButtonConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(107, 28);
            this.ButtonConnect.TabIndex = 0;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.CurrentRelativeVoltage);
            this.panel2.Controls.Add(this.textBoxDownBoundCalib);
            this.panel2.Controls.Add(this.textBoxUpBoundCalib);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.CalibrationButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxCalibTimestep);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(5, 86);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 298);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // CurrentRelativeVoltage
            // 
            this.CurrentRelativeVoltage.AutoSize = true;
            this.CurrentRelativeVoltage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CurrentRelativeVoltage.Location = new System.Drawing.Point(4, 206);
            this.CurrentRelativeVoltage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentRelativeVoltage.Name = "CurrentRelativeVoltage";
            this.CurrentRelativeVoltage.Size = new System.Drawing.Size(0, 17);
            this.CurrentRelativeVoltage.TabIndex = 8;
            // 
            // textBoxDownBoundCalib
            // 
            this.textBoxDownBoundCalib.Location = new System.Drawing.Point(4, 177);
            this.textBoxDownBoundCalib.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDownBoundCalib.Name = "textBoxDownBoundCalib";
            this.textBoxDownBoundCalib.Size = new System.Drawing.Size(95, 22);
            this.textBoxDownBoundCalib.TabIndex = 7;
            this.textBoxDownBoundCalib.Text = "60";
            // 
            // textBoxUpBoundCalib
            // 
            this.textBoxUpBoundCalib.Location = new System.Drawing.Point(4, 113);
            this.textBoxUpBoundCalib.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUpBoundCalib.Name = "textBoxUpBoundCalib";
            this.textBoxUpBoundCalib.Size = new System.Drawing.Size(95, 22);
            this.textBoxUpBoundCalib.TabIndex = 6;
            this.textBoxUpBoundCalib.Text = "80";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(0, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "Down bound\r\n(0 - 255, -255 - 0)";
            // 
            // CalibrationButton
            // 
            this.CalibrationButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CalibrationButton.Location = new System.Drawing.Point(8, 251);
            this.CalibrationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CalibrationButton.Name = "CalibrationButton";
            this.CalibrationButton.Size = new System.Drawing.Size(103, 43);
            this.CalibrationButton.TabIndex = 0;
            this.CalibrationButton.Text = "Start Calibration";
            this.CalibrationButton.UseVisualStyleBackColor = true;
            this.CalibrationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(4, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Up bound\r\n(0 - 255, -255 -0)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time step (ms)";
            // 
            // textBoxCalibTimestep
            // 
            this.textBoxCalibTimestep.Location = new System.Drawing.Point(4, 43);
            this.textBoxCalibTimestep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCalibTimestep.Name = "textBoxCalibTimestep";
            this.textBoxCalibTimestep.Size = new System.Drawing.Size(95, 22);
            this.textBoxCalibTimestep.TabIndex = 2;
            this.textBoxCalibTimestep.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calibration";
            // 
            // chart1
            // 
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.IntervalOffset = 0D;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea1.AxisX.MajorTickMark.Interval = 0D;
            chartArea1.AxisX.MajorTickMark.IntervalOffset = 0D;
            chartArea1.AxisX.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.Title = "t ( sec)";
            chartArea1.AxisY.Title = "U(V)";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(493, 4);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series2.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(397, 256);
            this.chart1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.lblTotalTime);
            this.panel3.Controls.Add(this.lblTotalCharge);
            this.panel3.Controls.Add(this.StatRelativeVoltageTextBox);
            this.panel3.Controls.Add(this.StatRelVoltageRadioButton);
            this.panel3.Controls.Add(this.StationaryModeButton);
            this.panel3.Location = new System.Drawing.Point(1, 388);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 117);
            this.panel3.TabIndex = 3;
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Location = new System.Drawing.Point(116, 89);
            this.lblTotalTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(68, 17);
            this.lblTotalTime.TabIndex = 7;
            this.lblTotalTime.Text = "Time (s): ";
            // 
            // lblTotalCharge
            // 
            this.lblTotalCharge.AutoSize = true;
            this.lblTotalCharge.Location = new System.Drawing.Point(116, 60);
            this.lblTotalCharge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCharge.Name = "lblTotalCharge";
            this.lblTotalCharge.Size = new System.Drawing.Size(96, 17);
            this.lblTotalCharge.TabIndex = 6;
            this.lblTotalCharge.Text = "Total charge: ";
            // 
            // StatRelativeVoltageTextBox
            // 
            this.StatRelativeVoltageTextBox.Location = new System.Drawing.Point(8, 32);
            this.StatRelativeVoltageTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StatRelativeVoltageTextBox.Name = "StatRelativeVoltageTextBox";
            this.StatRelativeVoltageTextBox.Size = new System.Drawing.Size(99, 22);
            this.StatRelativeVoltageTextBox.TabIndex = 5;
            this.StatRelativeVoltageTextBox.Text = "80";
            // 
            // StatRelVoltageRadioButton
            // 
            this.StatRelVoltageRadioButton.AutoSize = true;
            this.StatRelVoltageRadioButton.Checked = true;
            this.StatRelVoltageRadioButton.Location = new System.Drawing.Point(-1, 4);
            this.StatRelVoltageRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StatRelVoltageRadioButton.Name = "StatRelVoltageRadioButton";
            this.StatRelVoltageRadioButton.Size = new System.Drawing.Size(132, 21);
            this.StatRelVoltageRadioButton.TabIndex = 1;
            this.StatRelVoltageRadioButton.TabStop = true;
            this.StatRelVoltageRadioButton.Text = "Relative Voltage";
            this.StatRelVoltageRadioButton.UseVisualStyleBackColor = true;
            // 
            // StationaryModeButton
            // 
            this.StationaryModeButton.Location = new System.Drawing.Point(8, 69);
            this.StationaryModeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StationaryModeButton.Name = "StationaryModeButton";
            this.StationaryModeButton.Size = new System.Drawing.Size(100, 48);
            this.StationaryModeButton.TabIndex = 0;
            this.StationaryModeButton.Text = "Stationary Mode";
            this.StationaryModeButton.UseVisualStyleBackColor = true;
            this.StationaryModeButton.Click += new System.EventHandler(this.StationaryModeButton_Click);
            // 
            // StopProgram
            // 
            this.StopProgram.Location = new System.Drawing.Point(279, 476);
            this.StopProgram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StopProgram.Name = "StopProgram";
            this.StopProgram.Size = new System.Drawing.Size(100, 28);
            this.StopProgram.TabIndex = 4;
            this.StopProgram.Text = "Stop";
            this.StopProgram.UseVisualStyleBackColor = true;
            this.StopProgram.Click += new System.EventHandler(this.StopProgram_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.textBoxAnodeTime);
            this.panel4.Controls.Add(this.textBoxCatodeTime);
            this.panel4.Controls.Add(this.textBoxAnodeImpulse);
            this.panel4.Controls.Add(this.textBoxCatodeImpulse);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(133, 86);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(144, 298);
            this.panel4.TabIndex = 5;
            // 
            // textBoxAnodeTime
            // 
            this.textBoxAnodeTime.Location = new System.Drawing.Point(1, 183);
            this.textBoxAnodeTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAnodeTime.Name = "textBoxAnodeTime";
            this.textBoxAnodeTime.Size = new System.Drawing.Size(101, 22);
            this.textBoxAnodeTime.TabIndex = 10;
            this.textBoxAnodeTime.Text = "1";
            // 
            // textBoxCatodeTime
            // 
            this.textBoxCatodeTime.Location = new System.Drawing.Point(8, 133);
            this.textBoxCatodeTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCatodeTime.Name = "textBoxCatodeTime";
            this.textBoxCatodeTime.Size = new System.Drawing.Size(95, 22);
            this.textBoxCatodeTime.TabIndex = 9;
            this.textBoxCatodeTime.Text = "2";
            // 
            // textBoxAnodeImpulse
            // 
            this.textBoxAnodeImpulse.Location = new System.Drawing.Point(7, 85);
            this.textBoxAnodeImpulse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAnodeImpulse.Name = "textBoxAnodeImpulse";
            this.textBoxAnodeImpulse.Size = new System.Drawing.Size(96, 22);
            this.textBoxAnodeImpulse.TabIndex = 8;
            this.textBoxAnodeImpulse.Text = "-60";
            // 
            // textBoxCatodeImpulse
            // 
            this.textBoxCatodeImpulse.Location = new System.Drawing.Point(4, 42);
            this.textBoxCatodeImpulse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCatodeImpulse.Name = "textBoxCatodeImpulse";
            this.textBoxCatodeImpulse.Size = new System.Drawing.Size(99, 22);
            this.textBoxCatodeImpulse.TabIndex = 6;
            this.textBoxCatodeImpulse.Text = "80";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 257);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Impulse Mode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 164);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Anode Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 113);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Catode time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Anode value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Catode value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Impulse Mode";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.textBoxDt);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.textBoxSMAlpha);
            this.panel5.Controls.Add(this.textBoxSMUpBound);
            this.panel5.Controls.Add(this.textBoxSMDownBound);
            this.panel5.Location = new System.Drawing.Point(279, 4);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(207, 256);
            this.panel5.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 86);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 17);
            this.label17.TabIndex = 17;
            this.label17.Text = "dt (ms)";
            // 
            // textBoxDt
            // 
            this.textBoxDt.Location = new System.Drawing.Point(4, 106);
            this.textBoxDt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDt.Name = "textBoxDt";
            this.textBoxDt.Size = new System.Drawing.Size(96, 22);
            this.textBoxDt.TabIndex = 16;
            this.textBoxDt.Text = "200";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 213);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 28);
            this.button2.TabIndex = 15;
            this.button2.Text = "Stohastic mode";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(119, 86);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 17);
            this.label16.TabIndex = 14;
            this.label16.Text = "Alpha";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(119, 27);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "Up Bound";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 27);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Down Bound";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 6);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Stohastic mode";
            // 
            // textBoxSMAlpha
            // 
            this.textBoxSMAlpha.Location = new System.Drawing.Point(105, 106);
            this.textBoxSMAlpha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSMAlpha.Name = "textBoxSMAlpha";
            this.textBoxSMAlpha.Size = new System.Drawing.Size(96, 22);
            this.textBoxSMAlpha.TabIndex = 9;
            this.textBoxSMAlpha.Text = "7";
            // 
            // textBoxSMUpBound
            // 
            this.textBoxSMUpBound.Location = new System.Drawing.Point(105, 50);
            this.textBoxSMUpBound.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSMUpBound.Name = "textBoxSMUpBound";
            this.textBoxSMUpBound.Size = new System.Drawing.Size(96, 22);
            this.textBoxSMUpBound.TabIndex = 7;
            this.textBoxSMUpBound.Text = "80";
            // 
            // textBoxSMDownBound
            // 
            this.textBoxSMDownBound.Location = new System.Drawing.Point(4, 50);
            this.textBoxSMDownBound.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSMDownBound.Name = "textBoxSMDownBound";
            this.textBoxSMDownBound.Size = new System.Drawing.Size(96, 22);
            this.textBoxSMDownBound.TabIndex = 6;
            this.textBoxSMDownBound.Text = "60";
            // 
            // chart2
            // 
            chartArea2.AxisX.Title = "t (sec)";
            chartArea2.AxisY.Title = "I (A)";
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Location = new System.Drawing.Point(493, 263);
            this.chart2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series3.IsVisibleInLegend = false;
            series3.Name = "Series1";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(397, 241);
            this.chart2.TabIndex = 7;
            this.chart2.Text = "chart2";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.label18);
            this.panel6.Controls.Add(this.textBoxDepositionCharge);
            this.panel6.Controls.Add(this.textBoxTimeDeposition);
            this.panel6.Controls.Add(this.radioButtonSelectCharge);
            this.panel6.Controls.Add(this.radioButtonSelectTime);
            this.panel6.Location = new System.Drawing.Point(283, 267);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(203, 197);
            this.panel6.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(39, 127);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(153, 34);
            this.label19.TabIndex = 5;
            this.label19.Text = "Deposition sum charge\r\n(Culones)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(39, 69);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 17);
            this.label18.TabIndex = 4;
            this.label18.Text = "Deposition time";
            // 
            // textBoxDepositionCharge
            // 
            this.textBoxDepositionCharge.Location = new System.Drawing.Point(43, 162);
            this.textBoxDepositionCharge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDepositionCharge.Name = "textBoxDepositionCharge";
            this.textBoxDepositionCharge.Size = new System.Drawing.Size(132, 22);
            this.textBoxDepositionCharge.TabIndex = 3;
            this.textBoxDepositionCharge.Text = "1";
            // 
            // textBoxTimeDeposition
            // 
            this.textBoxTimeDeposition.Location = new System.Drawing.Point(43, 92);
            this.textBoxTimeDeposition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTimeDeposition.Name = "textBoxTimeDeposition";
            this.textBoxTimeDeposition.Size = new System.Drawing.Size(132, 22);
            this.textBoxTimeDeposition.TabIndex = 2;
            this.textBoxTimeDeposition.Text = "60";
            // 
            // radioButtonSelectCharge
            // 
            this.radioButtonSelectCharge.AutoSize = true;
            this.radioButtonSelectCharge.Location = new System.Drawing.Point(5, 32);
            this.radioButtonSelectCharge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonSelectCharge.Name = "radioButtonSelectCharge";
            this.radioButtonSelectCharge.Size = new System.Drawing.Size(75, 21);
            this.radioButtonSelectCharge.TabIndex = 1;
            this.radioButtonSelectCharge.TabStop = true;
            this.radioButtonSelectCharge.Text = "Charge";
            this.radioButtonSelectCharge.UseVisualStyleBackColor = true;
            // 
            // radioButtonSelectTime
            // 
            this.radioButtonSelectTime.AutoSize = true;
            this.radioButtonSelectTime.Checked = true;
            this.radioButtonSelectTime.Location = new System.Drawing.Point(5, 4);
            this.radioButtonSelectTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonSelectTime.Name = "radioButtonSelectTime";
            this.radioButtonSelectTime.Size = new System.Drawing.Size(60, 21);
            this.radioButtonSelectTime.TabIndex = 0;
            this.radioButtonSelectTime.TabStop = true;
            this.radioButtonSelectTime.Text = "Time";
            this.radioButtonSelectTime.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(891, 506);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.StopProgram);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Electrodeposition power control program v. 0.0.6 / http://nnc.cdu.edu.ua";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.ComboBox ComboBoxSerialPorts;
        private System.Windows.Forms.Button ButtonDisconnect;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CalibrationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCalibTimestep;
        private System.Windows.Forms.TextBox textBoxDownBoundCalib;
        private System.Windows.Forms.TextBox textBoxUpBoundCalib;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label CurrentRelativeVoltage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton StatRelVoltageRadioButton;
        private System.Windows.Forms.Button StationaryModeButton;
        private System.Windows.Forms.TextBox StatRelativeVoltageTextBox;
        private System.Windows.Forms.Button StopProgram;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxAnodeTime;
        private System.Windows.Forms.TextBox textBoxCatodeTime;
        private System.Windows.Forms.TextBox textBoxAnodeImpulse;
        private System.Windows.Forms.TextBox textBoxCatodeImpulse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSMAlpha;
        private System.Windows.Forms.TextBox textBoxSMUpBound;
        private System.Windows.Forms.TextBox textBoxSMDownBound;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxDt;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxDepositionCharge;
        private System.Windows.Forms.TextBox textBoxTimeDeposition;
        private System.Windows.Forms.RadioButton radioButtonSelectCharge;
        private System.Windows.Forms.RadioButton radioButtonSelectTime;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lblTotalCharge;
    }
}

