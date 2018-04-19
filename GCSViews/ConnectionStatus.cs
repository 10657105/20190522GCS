using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MissionPlanner.GCSViews
{
    public partial class ConnectionStatus : MyUserControl
    {
        internal MAVLinkInterface conn1 = null;
        public ConnectionStatus()
        {
            InitializeComponent();
        }
        private void PrintBat()
        {
            //curs = new CurrentState();
            while (true)
            {
                if (MainV2.comPort.BaseStream.IsOpen)
                {
                    this.Invoke(new Action(delegate ()
                    {
                        if (conn1 != null)
                        {
                            label1.Text = conn1.MAV.cs.alt.ToString("f1") + "m";
                            label10.Text = conn1.MAV.cs.yaw.ToString("f1") + "deg";
                            label11.Text = conn1.MAV.cs.groundspeed.ToString("f1") + "m/s";
                            label12.Text = conn1.MAV.cs.mode.ToString();

                            label7.Text = conn1.MAV.cs.battery_voltage.ToString("f1") + "V   " + conn1.MAV.cs.current.ToString("f1") + "A ";

                            label9.Text = conn1.MAV.cs.satcount.ToString() + "   (" + conn1.MAV.cs.gpshdop.ToString() + "m)  ";

                            if (conn1.MAV.cs.armed)
                            {//arm
                                label4.Text = "Armed";
                                label4.ForeColor = Color.Red;
                            }
                            else
                            {
                                label4.Text = "Disarmed";
                                label4.ForeColor = Color.Lime;
                            }

                            if (conn1.MAV.cs.ekfstatus > 0.5)
                            {//EKF
                                if (conn1.MAV.cs.ekfstatus > 0.8)
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

                            label8.Text = conn1.MAV.cs.linkqualitygcs.ToString() + "% " + conn1.ToString().Remove(0, 9);
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

        private void ConnectionStatus_Load(object sender, EventArgs e)
        {
            Thread ThreadA = new Thread(new ThreadStart(PrintBat));
            ThreadA.IsBackground = true;
            ThreadA.Start();
        }
    }
}
