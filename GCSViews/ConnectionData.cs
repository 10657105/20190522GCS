using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MissionPlanner.Controls;
using System.Threading;



namespace MissionPlanner.GCSViews
{
    public partial class ConnectionData : MyUserControl
    {
        // public static CurrentState curs;
        public static ConnectionStatus ConnectionStatus1 = new ConnectionStatus();
        public static ConnectionStatus ConnectionStatus2 = new ConnectionStatus();
        public static ConnectionStatus ConnectionStatus3 = new ConnectionStatus();
        public static ConnectionStatus ConnectionStatus4 = new ConnectionStatus();
        public static ConnectionStatus ConnectionStatus5 = new ConnectionStatus();
        public static Thread ThreadA;
        public static bool threadrun = true;

        public ConnectionData()
        {
            InitializeComponent();

            // 
            // connectionStatus1
            // 
            /*tableLayoutPanel1.Controls.Add(ConnectionStatus1, 0, 0);
            ConnectionStatus1.Dock = DockStyle.Fill;
            ConnectionStatus1.Location = new System.Drawing.Point(3, 240);
            ConnectionStatus1.Name = "connectionStatus1";
            ConnectionStatus1.Size = new System.Drawing.Size(141, 61);
            ConnectionStatus1.TabIndex = 1;
            // */
            // connectionStatus2
            // 
            tableLayoutPanel1.Controls.Add(ConnectionStatus2, 0, 1);
            ConnectionStatus2.Dock = DockStyle.Fill;
            ConnectionStatus2.Location = new System.Drawing.Point(3, 240);
            ConnectionStatus2.Name = "connectionStatus2";
            ConnectionStatus2.Size = new System.Drawing.Size(141, 61);
            ConnectionStatus2.TabIndex = 1;
            // 
            // connectionStatus3
            // 
           tableLayoutPanel1.Controls.Add(ConnectionStatus3, 0, 2);
            ConnectionStatus3.Dock = DockStyle.Fill;
            ConnectionStatus3.Location = new System.Drawing.Point(3, 240);
            ConnectionStatus3.Name = "connectionStatus3";
            ConnectionStatus3.Size = new System.Drawing.Size(141, 61);
            ConnectionStatus3.TabIndex = 1;
            //ConnectionStatus3.Visible = false;
            // 
            // connectionStatus4
            // 
            /*tableLayoutPanel1.Controls.Add(ConnectionStatus4, 0, 3);
            ConnectionStatus4.Dock = DockStyle.Fill;
            ConnectionStatus4.Location = new System.Drawing.Point(3, 240);
            ConnectionStatus4.Name = "connectionStatus4";
            ConnectionStatus4.Size = new System.Drawing.Size(141, 61);
            ConnectionStatus4.TabIndex = 1;
            //
            // connectionStatus5
            // 
            tableLayoutPanel1.Controls.Add(ConnectionStatus5, 0, 4);
            ConnectionStatus5.Dock = DockStyle.Fill;
            ConnectionStatus5.Location = new System.Drawing.Point(3, 240);
            ConnectionStatus5.Name = "connectionStatus5";
            ConnectionStatus5.Size = new System.Drawing.Size(141, 61);
            ConnectionStatus5.TabIndex = 1;*/
            
            ThreadA = new Thread(new ThreadStart(Mainthread));
            //ThreadA.IsBackground = true;
            ThreadA.Start();

        }
        /*private void PrintBat()
        {
        
            //curs = new CurrentState();
            while (true)
            {
                if (MainV2.comPort.BaseStream.IsOpen)
                {
                    this.Invoke(new Action(delegate ()
                    {
                        if (MainV2.Comports[0] != null)
                        {
                            label1.Text = MainV2.Comports[0].MAV.cs.alt.ToString("f1") + "m";
                            label10.Text = MainV2.Comports[0].MAV.cs.yaw.ToString("f1") + "deg";
                            label11.Text = MainV2.Comports[0].MAV.cs.groundspeed.ToString("f1") + "m/s";
                            label12.Text = MainV2.Comports[0].MAV.cs.mode.ToString();

                            label7.Text = MainV2.Comports[0].MAV.cs.battery_voltage.ToString("f1") + "V   " + MainV2.Comports[0].MAV.cs.current.ToString("f1") + "A ";                                       
                            
                            label9.Text = MainV2.Comports[0].MAV.cs.satcount.ToString() + "   (" + MainV2.Comports[0].MAV.cs.gpshdop.ToString() + "m)  ";

                            if (MainV2.Comports[0].MAV.cs.armed)
                            {//arm
                                label4.Text = "Armed";
                                label4.ForeColor = Color.Red;
                            }
                            else
                            {
                                label4.Text = "Disarmed";
                                label4.ForeColor = Color.Lime;
                            }

                             if (MainV2.Comports[0].MAV.cs.ekfstatus > 0.5)
                             {//EKF
                                 if (MainV2.Comports[0].MAV.cs.ekfstatus > 0.8)
                                 {
                                   label6.Text = "EKF";
                                   label6.ForeColor = Color.Red;
                                 }
                                 else
                                 {
                                    label6.Text = "EKF";
                                    label6.ForeColor = Color.Orange;
                                 }
                             }
                             else
                             {
                                label6.Text = "EKF";
                                label6.ForeColor = Color.Lime;
                            }

                            label8.Text = MainV2.Comports[0].MAV.cs.linkqualitygcs.ToString() + "% " + MainV2.Comports[0].ToString().Remove(0,9);
                        }
                        if (MainV2.Comports.Count > 1 && MainV2.Comports[1] != null)
                        {
                          label2.Text = MainV2.Comports[1].MAV.cs.battery_voltage.ToString("f1") + "V  " + MainV2.Comports[1].MAV.cs.current.ToString("f1") + "A  \n"
                                      + MainV2.Comports[1].MAV.cs.alt.ToString("f1") + "m  " + MainV2.Comports[1].MAV.cs.yaw.ToString("f1") + "deg  " + MainV2.Comports[1].MAV.cs.mode.ToString() + " \n"
                                      + "Ssta:" + MainV2.Comports[1].MAV.cs.satcount.ToString() + "  " + "hdop:" + MainV2.Comports[1].MAV.cs.gpshdop.ToString(); ;
                        }
                       

                    }));

                }

            }
        }

        /*private void label1_Click(object sender, EventArgs e)
        {
            Thread ThreadA = new Thread(new ThreadStart(PrintBat));
            ThreadA.IsBackground = true;
            ThreadA.Start();
        }*/
        public static void Mainthread()
        {
            while (true)
            //while (threadrun)
            {
                if (MainV2.comPort.BaseStream.IsOpen)
                {
                    if (MainV2.Comports[0] != null)
                        ConnectionStatus2.conn1 = MainV2.Comports[0];

                    if (MainV2.Comports.Count > 1 && MainV2.Comports[1] != null && MainV2.Comports[0].ToString() != "MAV 0 on Ice")

                    {
                        ConnectionStatus3.conn1 = MainV2.Comports[1];
                        /*this.Invoke(new Action(delegate ()
                        {
                            ConnectionStatus3.Visible = true;
                        }));*/
                        // }
                    }
                }

                // if (MainV2.comPort.BaseStream.IsOpen && MainV2.Comports[0] != null && MainV2.Comports.Count > 1)
                // {


               /* if (MainV2.Comports.Count > 2 && MainV2.Comports[2] != null && MainV2.Comports[0].ToString() != "MAV 0 on Ice")
                {
                    ConnectionStatus4.conn1 = MainV2.Comports[2];
                    this.Invoke(new Action(delegate ()
                    {
                        ConnectionStatus3.Visible = true;
                    }));


                }*/
            }


        }
           /* private void ConnectionData_Load(object sender, EventArgs e)
        {
            Thread ThreadA = new Thread(new ThreadStart(Mainthread));
            ThreadA.IsBackground = true;
            ThreadA.Start();
        }*/

    }
}
