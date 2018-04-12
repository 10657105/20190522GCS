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
using System.Drawing;

namespace MissionPlanner.GCSViews
{
    public partial class ConnectionData : MyUserControl
    {
        public static CurrentState curs;
        
        public ConnectionData()
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
                        if (MainV2.Comports[0] != null)
                        {
                            label7.Text = MainV2.Comports[0].MAV.cs.battery_voltage.ToString("f1") + "V   " + MainV2.Comports[0].MAV.cs.current.ToString("f1") + "A ";                                       
                            label1.Text = MainV2.Comports[0].MAV.cs.alt.ToString("f1") + "m   " + MainV2.Comports[0].MAV.cs.yaw.ToString("f1") + "deg   " 
                                        + MainV2.Comports[0].MAV.cs.groundspeed.ToString("f1") + "m/s   " + MainV2.Comports[0].MAV.cs.mode.ToString() + " ";
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

        private void ConnectionData_Load(object sender, EventArgs e)
        {
            Thread ThreadA = new Thread(new ThreadStart(PrintBat));
            ThreadA.IsBackground = true;
            ThreadA.Start();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
