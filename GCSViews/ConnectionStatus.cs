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
        internal MAVLinkInterface InputConnection = null;
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
                        if (InputConnection != null)
                        {
                            label1.Text = InputConnection.MAV.cs.alt.ToString("f1") + "m";
                            label10.Text = InputConnection.MAV.cs.yaw.ToString("f1") + "deg";
                            label11.Text = InputConnection.MAV.cs.groundspeed.ToString("f1") + "m/s";
                            label12.Text = InputConnection.MAV.cs.mode.ToString();

                            label7.Text = InputConnection.MAV.cs.battery_voltage.ToString("f1") + "V   " + InputConnection.MAV.cs.current.ToString("f1") + "A ";

                            label9.Text = InputConnection.MAV.cs.satcount.ToString() + "   (" + InputConnection.MAV.cs.gpshdop.ToString() + "m)  ";

                            if (InputConnection.MAV.cs.armed)
                            {//arm
                                label4.Text = "Armed";
                                label4.ForeColor = Color.Red;
                            }
                            else
                            {
                                label4.Text = "Disarmed";
                                label4.ForeColor = Color.Lime;
                            }

                            if (InputConnection.MAV.cs.ekfstatus > 0.5)
                            {//EKF
                                if (InputConnection.MAV.cs.ekfstatus > 0.8)
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

                            label8.Text = InputConnection.MAV.cs.linkqualitygcs.ToString() + "% " + InputConnection.ToString().Remove(0, 9);
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
