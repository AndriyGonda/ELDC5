using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;

namespace ELDC
{
    public partial class Form1 : Form
    {
       
        private string[] Ports;
        private bool isConnected = false;
        private SerialPort Port = new SerialPort();
        private readonly string DIRECT_POLARITY = "p1\n";
        private readonly string INVERSE_POLARITY = "p0\n";
        private readonly double NORM_VOLTAGE_MULTIPLIER = 0.9066649686;
        private readonly double NORM_CURRENT_MULTIPLIER = 0.1360544217687075;
        private readonly int HARDWARE_DELAY = 100;
        private readonly int ZERO_VOLTAGE = 0;
        private double Voltage;
        private double Current;
        bool Running = false;
        private int PrevRelVoltage = 0;
        //Get list of avaliable serial ports
        private void get_avaliable_com_ports()
        {
            ComboBoxSerialPorts.Items.Clear();
            Ports = SerialPort.GetPortNames();

            if (Ports.Length > 0)
            {
                foreach (string PortName in Ports) ComboBoxSerialPorts.Items.Add(PortName);
                ComboBoxSerialPorts.SelectedIndex = 0;
                ButtonConnect.Enabled = true;
            }
            else
            {
                ComboBoxSerialPorts.Items.Clear();
                ComboBoxSerialPorts.SelectedText = "";
                ButtonConnect.Enabled = false;
                ButtonRefresh.Enabled = true;
                //ButtonDisconnect.Enabled = false;
                return;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Port.PortName = ComboBoxSerialPorts.SelectedItem.ToString();
                Port.BaudRate = 9600;
                Port.DataBits = 8;
                Port.Parity = System.IO.Ports.Parity.None;
                Port.StopBits = System.IO.Ports.StopBits.One;
                Port.Open();
                ButtonRefresh.Enabled = false;
                ButtonConnect.Enabled = false;
                ButtonDisconnect.Enabled = true;
                isConnected = true;
                panel2.Enabled = true;
                panel3.Enabled = true;
                panel4.Enabled = true;
            }
            catch (Exception all_exceptions)
            {
                MessageBox.Show("ERROR: Couldn't open port: \n" + all_exceptions.ToString(), "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                isConnected = false;
                ButtonRefresh.Enabled = true;
                ButtonConnect.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = false;
                panel4.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ButtonRefresh.Enabled = true;
            ButtonDisconnect.Enabled = false;
            get_avaliable_com_ports();
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
        }

        // send string command
        private void send_command(string cmd)
        {
            if (isConnected)
            {
                if (Port.IsOpen) Port.Write(cmd);
                else
                {
                    Port.Close();
                    Port.Open();
                }
            }
            else
                return;
        }

        // format integer value for sending
        private string format_integer_value(int value)
        {
            return "s"+value.ToString().PadLeft(3, '0')+"\n";
        }
        // send integer value of relative voltage
        private void send_relative_voltage(int RelativeVoltage)
        {
            if (isConnected)
            {
                if (Port.IsOpen)
                {
                        
                    send_command(format_integer_value((int)Math.Abs(RelativeVoltage)));
                    PrevRelVoltage = RelativeVoltage;

                    label1.Text = "";
                    string ReceivedDataVoltage = Port.ReadLine();
                    string ReceivedDataCurrent = Port.ReadLine();
                    Voltage = 0;
                    Current = 0;
                    if ((ReceivedDataVoltage.Length == 7) && (ReceivedDataCurrent.Length == 7))
                    {
                        Voltage = 0;
                        Current = 0;
                        ReceivedDataVoltage = ReceivedDataVoltage.Trim(new Char[] { ' ', 'U', '\n' });
                        ReceivedDataCurrent = ReceivedDataCurrent.Trim(new Char[] { ' ', 'I', '\n' });
                        try
                        {
                            Voltage = Convert.ToDouble(ReceivedDataVoltage);
                            Current = Convert.ToDouble(ReceivedDataCurrent);
                            if (RelativeVoltage < 0)
                            {
                                Voltage *= -1;
                                Current *= -1;
                            }
                            Voltage *= NORM_VOLTAGE_MULTIPLIER;
                            Current *= NORM_CURRENT_MULTIPLIER;
                        }
                        catch
                        {
                            Form1.ActiveForm.Text = "Invalid data";
                        }
                       
                    }
                }
                else return;
            }
        }
        // This option will can use for refresh list of avaliable serial ports
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            ComboBoxSerialPorts.Items.Clear();
            ButtonDisconnect_Click(sender, e);
            get_avaliable_com_ports();
        }
        // Disconnect serial port button callback 
        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            ButtonRefresh.Enabled = true;
            ButtonConnect.Enabled = true;
            ButtonDisconnect.Enabled = false;
            if (Port.IsOpen) Port.Close();
            isConnected = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
        }

        private void time_elapse_miliseconds(long miliseconds)
        {
            DateTime BeginTime = DateTime.Now;
            DateTime CurrentTime = BeginTime;
            long elapsed = (CurrentTime.Ticks  - BeginTime.Ticks)/ TimeSpan.TicksPerMillisecond;
            while ( elapsed<= miliseconds)
            {
              CurrentTime = DateTime.Now;
              elapsed = (CurrentTime.Ticks  - BeginTime.Ticks)/ TimeSpan.TicksPerMillisecond;
              Application.DoEvents();
            }

        }

        private void setup_start_voltage(int RelativeVoltage)
        {
            if (isConnected)
            {
                if (RelativeVoltage > 0)
                {
                    send_command(DIRECT_POLARITY);
                    time_elapse_miliseconds(HARDWARE_DELAY);
                    for (int StartVoltage = 0; StartVoltage < RelativeVoltage; StartVoltage++)
                    {
                        send_relative_voltage(StartVoltage);
                        time_elapse_miliseconds(HARDWARE_DELAY);
                        CurrentRelativeVoltage.Text = StartVoltage.ToString();
                        Application.DoEvents();
                    }
                }
                else
                {
                    send_command(INVERSE_POLARITY);
                    time_elapse_miliseconds(HARDWARE_DELAY);
                    for (int StartVoltage = 0; StartVoltage > RelativeVoltage; StartVoltage--)
                    {
                        send_relative_voltage(StartVoltage);
                        time_elapse_miliseconds(HARDWARE_DELAY);
                        CurrentRelativeVoltage.Text = StartVoltage.ToString();
                        Application.DoEvents();
                    }
                }
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int TimeStep = Convert.ToInt32(textBoxCalibTimestep.Text);
            int DownBound = Convert.ToInt32(textBoxDownBoundCalib.Text);
            int UpBound = Convert.ToInt32(textBoxUpBoundCalib.Text);
            string /*title,*/ xtitle, ytitle;
            xtitle = chart1.ChartAreas[0].AxisX.Title;
            ytitle = chart1.ChartAreas[0].AxisY.Title;
            chart1.ChartAreas[0].AxisX.Title = "U (V)";
            chart1.ChartAreas[0].AxisY.Title = "I (A)";
            chart2.Visible = false;
            if (isConnected)
            {
                CalibrationButton.Enabled = false;
                send_relative_voltage(ZERO_VOLTAGE);
                time_elapse_miliseconds(HARDWARE_DELAY);
                send_command(DIRECT_POLARITY);
                time_elapse_miliseconds(HARDWARE_DELAY);

                setup_start_voltage(DownBound);

                 //Calibration
                 chart1.Series[0].Points.Clear();
                 chart1.Series[1].Points.Clear();
                 StreamWriter output = new StreamWriter(DateTime.Now.ToString("dd.MM.yyyy_HH.mm.ss") + "_Calib.txt");

                 if (DownBound < 0)
                 {
                     send_command(INVERSE_POLARITY);
                     time_elapse_miliseconds(HARDWARE_DELAY);
                 }
                 else
                 {
                     send_command(DIRECT_POLARITY);
                     time_elapse_miliseconds(HARDWARE_DELAY);
                 }

                 for (int RelativeVoltage = DownBound; RelativeVoltage <= UpBound; RelativeVoltage++)
                 {
                     if ((DownBound < 0) && (RelativeVoltage == 0))
                     {
                         send_command(DIRECT_POLARITY);
                         time_elapse_miliseconds(HARDWARE_DELAY);
                     }

                      send_relative_voltage(RelativeVoltage);
                      time_elapse_miliseconds(TimeStep);

                      //Data visualisation and writing to file 
                      chart1.Series[0].Points.AddXY(Math.Round(Voltage,3),Math.Round(Current,4));
                      output.WriteLine(RelativeVoltage.ToString() + ";" + Voltage.ToString() + ";" + Current.ToString());
                      CurrentRelativeVoltage.Text = RelativeVoltage.ToString();
                      Application.DoEvents();
                 }
                
                 output.Close();

                 //Finishing calibration
                 send_relative_voltage(ZERO_VOLTAGE);
                 time_elapse_miliseconds(HARDWARE_DELAY);
                 send_command(DIRECT_POLARITY);
                 CurrentRelativeVoltage.Text = "Complete";
                 CalibrationButton.Enabled = true;

             }
            chart1.ChartAreas[0].AxisX.Title = xtitle;
            chart1.ChartAreas[0].AxisY.Title = ytitle;
            chart2.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void StationaryModeButton_Click(object sender, EventArgs e)
        {
            Int32 StationaryModeTime = 60000 * Convert.ToInt32(textBoxTimeDeposition.Text);
            double StatModeCharge = Convert.ToDouble(textBoxDepositionCharge.Text);

            if (isConnected)
            {

                send_relative_voltage(ZERO_VOLTAGE);
                time_elapse_miliseconds(HARDWARE_DELAY);
                send_command(DIRECT_POLARITY);
                time_elapse_miliseconds(HARDWARE_DELAY);


                int RelativeVoltage = Convert.ToInt32(StatRelativeVoltageTextBox.Text);

                //setup start stationary state voltage value*/
                //setup_start_voltage(RelativeVoltage);
                //start stationary mode

                DateTime BeginTime = DateTime.Now;
                DateTime CurrentTime = DateTime.Now;
                long time = (CurrentTime.Ticks - BeginTime.Ticks) / TimeSpan.TicksPerMillisecond;
                double tc = (double)time / 1000.0;
                double tp = tc;
                double delta_t = tc - tp;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart2.Series[0].Points.Clear();

                Running = true;
                StreamWriter output = new StreamWriter(DateTime.Now.ToString("dd.MM.yyyy_HH.mm.ss") + "_Stationary_relV.txt");

                if (RelativeVoltage < 0) send_command(INVERSE_POLARITY);
                else send_command(DIRECT_POLARITY);
                time_elapse_miliseconds(HARDWARE_DELAY);

                double Sum=0; //sum charge
                double PrevCurrent;
                if (radioButtonSelectTime.Checked)
                {
                    Sum = 0;
                    while ((time <= StationaryModeTime) && (Running))
                    {
                        tp = tc;
                        CurrentTime = DateTime.Now;

                        time = (CurrentTime.Ticks - BeginTime.Ticks) / TimeSpan.TicksPerMillisecond;
                        tc = (double)time / 1000.0;
                        PrevCurrent = Current;
                        send_relative_voltage(RelativeVoltage);
                       
                        delta_t = tc - tp;
                        Sum += delta_t * (Current+PrevCurrent)*0.5;
                        lblTotalCharge.Text = Sum.ToString();
                        lblTotalTime.Text = tc.ToString();
                        chart1.Series[1].Points.AddXY(tc, Voltage);
                        chart2.Series[0].Points.AddXY(tc, Current);
                        output.WriteLine(tc.ToString() + ";" + Voltage.ToString() + ";" + Current.ToString());

                        if (chart1.Series[1].Points.Count > 1000) chart1.Series[1].Points.Clear();
                        if (chart2.Series[0].Points.Count > 1000) chart2.Series[0].Points.Clear();

                        Application.DoEvents();
                    }
                }

               
                if (radioButtonSelectCharge.Checked)
                {
                    Sum = 0;
                    while ((Sum < StatModeCharge) && (Running))
                    {
                        tp = tc;
                        CurrentTime = DateTime.Now;

                        time = (CurrentTime.Ticks - BeginTime.Ticks) / TimeSpan.TicksPerMillisecond;
                        tc = (double)time / 1000.0;
                        PrevCurrent = Current;
                        send_relative_voltage(RelativeVoltage);
                      
                        delta_t = tc - tp;
                        Sum += delta_t * (Current + PrevCurrent) * 0.5;
                        lblTotalCharge.Text = Sum.ToString();
                        lblTotalTime.Text = tc.ToString();

                        chart1.Series[1].Points.AddXY(tc, Voltage);
                        chart2.Series[0].Points.AddXY(tc, Current);
                        output.WriteLine(tc.ToString() + ";" + Voltage.ToString() + ";" + Current.ToString());

                        if (chart1.Series[1].Points.Count > 1000) chart1.Series[1].Points.Clear();
                        if (chart2.Series[0].Points.Count > 1000) chart2.Series[0].Points.Clear();

                        Application.DoEvents();
                    }
                }
                output.WriteLine("\nTotal time:" + tc.ToString() + " seconds");
                output.WriteLine("\nTotal charge:" + Sum.ToString() + " Coulomb's");
                output.WriteLine("Relative value:" + RelativeVoltage);
                output.Close();
                send_relative_voltage(ZERO_VOLTAGE);
                time_elapse_miliseconds(HARDWARE_DELAY);
                send_command(DIRECT_POLARITY);


            }
        }

        private void StopProgram_Click(object sender, EventArgs e)
        {
            Running = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (isConnected)
            {
                int CatodeTime = Convert.ToInt32(textBoxCatodeTime.Text);
                int CatodeRelativeValue = Convert.ToInt32(textBoxCatodeImpulse.Text);
                int AnodeTime = Convert.ToInt32(textBoxAnodeTime.Text);
                int AnodeRelativeValue = Convert.ToInt32(textBoxAnodeImpulse.Text);
                long ImpulseModeTotalTime = 60000 * Convert.ToInt32(textBoxTimeDeposition.Text);
                double SumCharge = Convert.ToDouble(textBoxDepositionCharge.Text);
                send_relative_voltage(ZERO_VOLTAGE);
                time_elapse_miliseconds(HARDWARE_DELAY);
                send_command(DIRECT_POLARITY);
                time_elapse_miliseconds(HARDWARE_DELAY);

                DateTime BeginTime = DateTime.Now;
                DateTime CurrentTime = DateTime.Now;
                long time = (CurrentTime.Ticks - BeginTime.Ticks) / TimeSpan.TicksPerMillisecond;
               
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart2.Series[0].Points.Clear();
               
                Running = true;
                StreamWriter output = new StreamWriter(DateTime.Now.ToString("dd.MM.yyyy_HH.mm.ss") + "_Impulse.txt");
                double tc = (double)time / 1000.0;
                double tp = tc;
                double delta_t = tc - tp;
                double Sum = 0;// sum charge
                double PrevCurrent;
                if (radioButtonSelectTime.Checked)
                {
                    Sum = 0;
                    while ((time <= ImpulseModeTotalTime) && (Running))
                    {
                        //catode impulse
                        DateTime BeginImpulse = DateTime.Now;
                        DateTime CurrentImpulse = DateTime.Now;
                        long CatodeImpulseTime = (CurrentImpulse.Ticks - BeginImpulse.Ticks) / TimeSpan.TicksPerMillisecond;

                        if (CatodeRelativeValue > 0) send_command(DIRECT_POLARITY);
                        else send_command(INVERSE_POLARITY);
                        time_elapse_miliseconds(HARDWARE_DELAY);

                        while (CatodeImpulseTime <= CatodeTime)
                        {
                            tp = tc;
                            PrevCurrent = Current;
                            send_relative_voltage(CatodeRelativeValue);

                            CurrentImpulse = DateTime.Now;
                            CatodeImpulseTime = (CurrentImpulse.Ticks - BeginImpulse.Ticks) / TimeSpan.TicksPerMillisecond;

                            // plot to chart and write to file
                            CurrentTime = DateTime.Now;
                            time = (CurrentTime.Ticks - BeginTime.Ticks) / TimeSpan.TicksPerMillisecond;
                            tc = (double)time / 1000.0;
                            delta_t = tc - tp;
                            Sum += 0.5*(Current+PrevCurrent) * delta_t;

                            lblTotalCharge.Text = Sum.ToString();
                            lblTotalTime.Text = tc.ToString();

                            chart1.Series[1].Points.AddXY(tc, Voltage);
                            chart2.Series[0].Points.AddXY(tc, Current);
                            output.WriteLine(tc.ToString() + ";" + Voltage.ToString() + ";" + Current.ToString());

                            if (chart1.Series[1].Points.Count > 500) chart1.Series[1].Points.Clear();
                            if (chart2.Series[0].Points.Count > 500) chart2.Series[0].Points.Clear();
                        }

                        //anode impulse
                        BeginImpulse = DateTime.Now;
                        CurrentImpulse = DateTime.Now;
                        long AnodeImpulseTime = (CurrentImpulse.Ticks - BeginImpulse.Ticks) / TimeSpan.TicksPerMillisecond;

                        if (AnodeRelativeValue > 0) send_command(DIRECT_POLARITY);
                        else send_command(INVERSE_POLARITY);

                        time_elapse_miliseconds(HARDWARE_DELAY);

                        while (AnodeImpulseTime <= AnodeTime)
                        {
                            tp = tc;
                            PrevCurrent = Current;
                            send_relative_voltage(AnodeRelativeValue);

                            CurrentImpulse = DateTime.Now;
                            AnodeImpulseTime = (CurrentImpulse.Ticks - BeginImpulse.Ticks) / TimeSpan.TicksPerMillisecond;

                            // plot to chart and write to file
                            CurrentTime = DateTime.Now;
                            time = (CurrentTime.Ticks - BeginTime.Ticks) / TimeSpan.TicksPerMillisecond;
                            tc = (double)time / 1000.0;
                            delta_t = tc - tp;
                            Sum += 0.5 * (Current + PrevCurrent) * delta_t;

                            lblTotalCharge.Text = Sum.ToString();
                            lblTotalTime.Text = tc.ToString();

                            chart1.Series[1].Points.AddXY(tc, Voltage);
                            chart2.Series[0].Points.AddXY(tc, Current);
                            output.WriteLine(tc.ToString() + ";" + Voltage.ToString() + ";" + Current.ToString());

                            if (chart1.Series[1].Points.Count > 1000) chart1.Series[1].Points.Clear();
                            if (chart2.Series[0].Points.Count > 1000) chart2.Series[0].Points.Clear();
                        }
                        Application.DoEvents();

                    }
                }


                /////////////////////////////////////////
               
                if (radioButtonSelectCharge.Checked)
                {
                    Sum = 0;
                 while ((Sum < SumCharge) && (Running))
                    {
                        //catode impulse
                        DateTime BeginImpulse = DateTime.Now;
                        DateTime CurrentImpulse = DateTime.Now;
                        long CatodeImpulseTime = (CurrentImpulse.Ticks - BeginImpulse.Ticks) / TimeSpan.TicksPerMillisecond;

                        if (CatodeRelativeValue > 0) send_command(DIRECT_POLARITY);
                        else send_command(INVERSE_POLARITY);

                        time_elapse_miliseconds(HARDWARE_DELAY);

                        while (CatodeImpulseTime <= CatodeTime)
                        {
                            tp = tc;
                            PrevCurrent = Current;
                            send_relative_voltage(CatodeRelativeValue);

                            CurrentImpulse = DateTime.Now;
                            CatodeImpulseTime = (CurrentImpulse.Ticks - BeginImpulse.Ticks) / TimeSpan.TicksPerMillisecond;

                            // plot to chart and write to file
                            CurrentTime = DateTime.Now;
                            time = (CurrentTime.Ticks - BeginTime.Ticks) / TimeSpan.TicksPerMillisecond;
                            tc = (double)time / 1000.0;
                            delta_t = tc - tp;
                            Sum += 0.5*(Current+PrevCurrent) * delta_t;

                            lblTotalCharge.Text = Sum.ToString();
                            lblTotalTime.Text = tc.ToString();

                            chart1.Series[1].Points.AddXY(tc, Voltage);
                            chart2.Series[0].Points.AddXY(tc, Current);
                            output.WriteLine(tc.ToString() + ";" + Voltage.ToString() + ";" + Current.ToString());

                            if (chart1.Series[1].Points.Count > 500) chart1.Series[1].Points.Clear();
                            if (chart2.Series[0].Points.Count > 500) chart2.Series[0].Points.Clear();
                        }
                        Application.DoEvents();
                        //anode impulse
                        BeginImpulse = DateTime.Now;
                        CurrentImpulse = DateTime.Now;
                        long AnodeImpulseTime = (CurrentImpulse.Ticks - BeginImpulse.Ticks) / TimeSpan.TicksPerMillisecond;

                        if (AnodeRelativeValue > 0) send_command(DIRECT_POLARITY);
                        else send_command(INVERSE_POLARITY);

                        time_elapse_miliseconds(HARDWARE_DELAY);
                        while (AnodeImpulseTime <= AnodeTime)
                        {
                            tp = tc;
                            PrevCurrent = Current;
                            send_relative_voltage(AnodeRelativeValue);

                            CurrentImpulse = DateTime.Now;
                            AnodeImpulseTime = (CurrentImpulse.Ticks - BeginImpulse.Ticks) / TimeSpan.TicksPerMillisecond;

                            // plot to chart and write to file
                            CurrentTime = DateTime.Now;
                            time = (CurrentTime.Ticks - BeginTime.Ticks) / TimeSpan.TicksPerMillisecond;
                            tc = (double)time / 1000.0;
                            delta_t = tc - tp;
                            Sum += 0.5 * (Current + PrevCurrent) * delta_t;

                            lblTotalCharge.Text = Sum.ToString();
                            lblTotalTime.Text = tc.ToString();

                            chart1.Series[1].Points.AddXY(tc, Voltage);
                            chart2.Series[0].Points.AddXY(tc, Current);
                            output.WriteLine(tc.ToString() + ";" + Voltage.ToString() + ";" + Current.ToString());

                            if (chart1.Series[1].Points.Count > 1000) chart1.Series[1].Points.Clear();
                            if (chart2.Series[0].Points.Count > 1000) chart2.Series[0].Points.Clear();
                        }
                        Application.DoEvents();

                    }
                }
                output.WriteLine("Total time:" + tc.ToString() + " seconds");
                output.WriteLine("Total charge:" + Sum.ToString() + " Coulomb's");
                output.WriteLine("Catode time:" + (CatodeTime / 1000).ToString() + "s");
                output.WriteLine("Anode time:" + (AnodeTime / 1000).ToString() + "s");
                output.WriteLine("Catode relative value:" + CatodeRelativeValue.ToString());
                output.WriteLine("Anode relative value:" + AnodeRelativeValue.ToString());
                output.Close();
                send_relative_voltage(ZERO_VOLTAGE);
                time_elapse_miliseconds(HARDWARE_DELAY);
                send_command(DIRECT_POLARITY);
                time_elapse_miliseconds(HARDWARE_DELAY);
            }
        }
        private double h(double x)
        {
            double L;
            if (x <= -1) L = (2.0 * x + 3.0) / 7.0;
            else if ( Math.Abs(x)< 1 ) L = -x / 7.0;
            else L = (2.0 * x - 3.0) / 7.0;

            return L;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int Dt = Convert.ToInt32(textBoxDt.Text);
            double DT = 0.1;
            int DownBoundary =  Convert.ToInt32(textBoxSMDownBound.Text);
            int UpBoundary =  Convert.ToInt32(textBoxSMUpBound.Text);
            double alpha = Convert.ToInt32(textBoxSMAlpha.Text);
            int TimeEl = Convert.ToInt32(textBoxTimeDeposition.Text) * 60000;
            double SumCharge = Convert.ToDouble(textBoxDepositionCharge.Text);
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart2.Series[0].Points.Clear();

            double x, y, z;
            double beta = 10;
            
            if (isConnected)
            {
                send_relative_voltage(ZERO_VOLTAGE);
                time_elapse_miliseconds(HARDWARE_DELAY);
                send_command(DIRECT_POLARITY);
                time_elapse_miliseconds(HARDWARE_DELAY);

                DateTime BeginTime = DateTime.Now;
                DateTime CurrentTime = DateTime.Now;
                long time = (CurrentTime.Ticks - BeginTime.Ticks) / TimeSpan.TicksPerMillisecond;
               
                Running = true;
                double tc = (double)time / 1000.0; //current time
                double tp = tc;
               StreamWriter output = new StreamWriter(DateTime.Now.ToString("dd.MM.yyyy_HH.mm.ss") + "_Chua.txt");
               //fing scale multipliers
               double t = 0;
               x = 0.001;
               y = 0;
               z = 0;
               double xmax, xmin;
               xmax = x;
               xmin = -x;
               while (t < (double) TimeEl/1000.0)
               {
                   x = x + alpha * (y - h(x)) * DT;
                   y = y + (x - y + z) * DT;
                   z = z + (-beta * y) * DT;
                   if (x > xmax) xmax = x;
                   if (x < xmin) xmin = x;
                   t += DT;
               }
               ////////////////////////////////
               double Sum = 0;
               double PrevCurrent;
               double minV=100, maxV=0;
               if (radioButtonSelectTime.Checked)
               {
                   minV = 100; maxV = 0;
                   x = 0.001;
                   y = 0;
                   z = 0;
                   Sum = 0;
                   while ((time <= TimeEl) && Running)
                   {
                       x = x + alpha * (y - h(x)) * DT;
                       y = y + (x - y + z) * DT;
                       z = z + (-beta * y) * DT;

                     //  if (x > xmax) xmax = x;
                   //    if (x < xmin) xmin = x;


                       int rel_val = (int)Math.Round(DownBoundary + Math.Round((x - xmin) * ((UpBoundary - DownBoundary) / (xmax - xmin))));

                       tp = tc;
                       PrevCurrent = Current;
                       send_relative_voltage(rel_val);
                       time_elapse_miliseconds(Dt);
                       CurrentTime = DateTime.Now;
                       time = (CurrentTime.Ticks - BeginTime.Ticks) / TimeSpan.TicksPerMillisecond;
                       tc = (double)time / 1000.0;

                       

                       chart1.Series[1].Points.AddXY(tc, Voltage);
                       chart2.Series[0].Points.AddXY(tc, Current);
                       if (Voltage > maxV) maxV = Voltage;
                       if (Voltage < minV) minV = Voltage;
                       output.WriteLine(tc.ToString() + ";" + Voltage.ToString() + ";" + Current.ToString());
                       Application.DoEvents();


                       if (chart1.Series[1].Points.Count > 1000) chart1.Series[1].Points.Clear();
                       if (chart2.Series[0].Points.Count > 1000) chart2.Series[0].Points.Clear();

                       double delta_t = tc - tp;
                       Sum += 0.5 * (Current + PrevCurrent) * delta_t;

                       lblTotalCharge.Text = Sum.ToString();
                       lblTotalTime.Text = tc.ToString();
                   }
               }

                   /////
                 
               if (radioButtonSelectCharge.Checked)
               {
                   minV = 100; maxV = 0;
                   x = 0.001;
                   y = 0;
                   z = 0;
                   Sum = 0;
                   while ((Sum < SumCharge) && Running)
                   {
                       x = x + alpha * (y - h(x)) * DT;
                       y = y + (x - y + z) * DT;
                       z = z + (-beta * y) * DT;



                       int rel_val = (int)Math.Round(DownBoundary + Math.Round((x - xmin) * ((UpBoundary - DownBoundary) / (xmax - xmin))));

                       tp = tc;
                       PrevCurrent = Current;
                       send_relative_voltage(rel_val);
                       time_elapse_miliseconds(Dt);
                       CurrentTime = DateTime.Now;
                       time = (CurrentTime.Ticks - BeginTime.Ticks) / TimeSpan.TicksPerMillisecond;
                       tc = (double)time / 1000.0;

                       if (Voltage > maxV) maxV = Voltage;
                       if (Voltage < minV) minV = Voltage;
                       chart1.Series[1].Points.AddXY(tc, Voltage);
                       chart2.Series[0].Points.AddXY(tc, Current);
                       output.WriteLine(tc.ToString() + ";" + Voltage.ToString() + ";" + Current.ToString());
                       Application.DoEvents();


                       if (chart1.Series[1].Points.Count > 1000) chart1.Series[1].Points.Clear();
                       if (chart2.Series[0].Points.Count > 1000) chart2.Series[0].Points.Clear();

                       double delta_t = tc - tp;
                       Sum += 0.5*(Current + PrevCurrent)* delta_t;

                       lblTotalCharge.Text = Sum.ToString();
                       lblTotalTime.Text = tc.ToString();

                   }
               }
               output.WriteLine("\nTotal time:" + tc.ToString() + " seconds");
               output.WriteLine("\nTotal charge:" + Sum.ToString() + " Coulomb's");
               output.WriteLine("norm xmax:" + xmax.ToString());
               output.WriteLine("norm xmin:" + xmin.ToString());
               output.WriteLine("Alpha: " + alpha.ToString());
               output.WriteLine("dt_for_voltage: " + Dt.ToString() + " ms");
               output.WriteLine("down bound relative value: " + DownBoundary.ToString());
               output.WriteLine("up bound relative value: " + UpBoundary.ToString());
               output.WriteLine("Min voltage: " + minV.ToString() + " V");
               output.WriteLine("Max voltage: " + maxV.ToString() + " V");

               double st1 = minV + (1.5 - xmin) *((maxV - minV) / (xmax - xmin));
               double st2 = minV + (-1.5 - xmin)*((maxV - minV) / (xmax - xmin));
               output.WriteLine("Stat1 voltage: " + st1.ToString() + " V");
               output.WriteLine("Stat2 voltage: " + st2.ToString() + " V");
                output.Close();
                send_relative_voltage(ZERO_VOLTAGE);
                time_elapse_miliseconds(HARDWARE_DELAY);
                send_command(DIRECT_POLARITY);
                time_elapse_miliseconds(HARDWARE_DELAY);
            }
        }
    }
}
    