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
using MissionPlanner.Controls;

namespace MissionPlanner.GCSViews
{
    public partial class ConnectionStatus : MyUserControl
    {
        internal MAVLinkInterface InputMAVlink = null;
        HUD hud=new HUD();
        Form HUDdropout = new Form();
        bool HUDdropoutresize;
       

        public ConnectionStatus()
        {
            InitializeComponent();
        }
        double flytimer = 0;

        public void PrintBat()
        {
            DateTime updateTime = DateTime.Now;
            
            while (true)
            {
                if (updateTime.AddSeconds(0.2) < DateTime.Now)
                {
                    if (MainV2.comPort.BaseStream.IsOpen)
                    {                        
                        this.Invoke(new Action(delegate ()
                        {
                            if (InputMAVlink != null)
                            {
                                label_PortName.Text = InputMAVlink.BaseStream.PortName;
                                label_linkquality.Text = InputMAVlink.MAV.cs.linkqualitygcs.ToString() + "% ";
                                label_GroundSpeed.Text = InputMAVlink.MAV.cs.groundspeed.ToString("f2") + "m/s";
                                label_yaw.Text = InputMAVlink.MAV.cs.yaw.ToString("f1") + "deg";
                                label_alt.Text = InputMAVlink.MAV.cs.alt.ToString("f1") + "m";
                                label_mode.Text = InputMAVlink.MAV.cs.mode.ToString(); label_mode.ForeColor = Color.Cyan;
                                label_battery.Text = InputMAVlink.MAV.cs.battery_voltage.ToString("f1") + "V   " + InputMAVlink.MAV.cs.current.ToString("f1") + "A ";
                                label_GPS.Text = InputMAVlink.MAV.cs.satcount.ToString() + "   (" + InputMAVlink.MAV.cs.gpshdop.ToString() + "m)  ";
                                label_latlng.Text = "( " + InputMAVlink.MAV.cs.lat.ToString("f6") + " , " + InputMAVlink.MAV.cs.lng.ToString("f6") + " )";

                                label_timer.Text = flytimer.ToString("f2") + " sec";

                                if (InputMAVlink.MAV.cs.armed)
                                {//arm
                                label_armedstatus.Text = "Armed";
                                    label_armedstatus.ForeColor = Color.Red;
                                }
                                else
                                {
                                    label_armedstatus.Text = "Disarmed";
                                    label_armedstatus.ForeColor = Color.Lime;
                                }

                                if (InputMAVlink.MAV.cs.ekfstatus > 0.5)
                                {//EKF
                                    if (InputMAVlink.MAV.cs.ekfstatus > 0.8)
                                    {
                                        label_ekf.Text = "EKF";
                                        label_ekf.ForeColor = Color.Red;
                                    }
                                    else
                                    {
                                        label_ekf.Text = "EKF";
                                        label_ekf.ForeColor = Color.Orange;
                                    }
                                }
                                else
                                {
                                    label_ekf.Text = "EKF";
                                    label_ekf.ForeColor = Color.Lime;
                                }
                            }
                        }));
                    }
                    updateTime = DateTime.Now;
                }
                Thread.Sleep(5);
            }
        }

        private void ConnectionStatus_Load(object sender, EventArgs e)
        {
            Thread ThreadA = new Thread(new ThreadStart(PrintBat));
            ThreadA.IsBackground = true;
            ThreadA.Start();
        }

        private void label_ekf_Click(object sender, EventArgs e)
        {
            EKFStatus frm = new EKFStatus();
            frm.InputMAVlink_EKF = InputMAVlink;
            frm.TopMost = true;
            frm.Show();            
        }

        private void label_hud_Click(object sender, EventArgs e)
        {
            HUDForm hudform = new HUDForm();
            hudform.Show();
            /*hud.Size = new Size(358, 264);
            hud.Dock = DockStyle.Fill;
            hud.Enabled = true;
            //if(InputMAVlink!=null)
            // HUD.Custom.src = InputMAVlink.MAV.cs;
            HUD.Custom.src = MainV2.comPort.MAV.cs;
            HUDdropout.Size = new Size(hud.Width, hud.Height + 20);
            HUDdropout.Controls.Add(hud);
            HUDdropout.Resize += HUDdropout_Resize;
            HUDdropout.FormClosed += HUDdropout_FormClosed;
            HUDdropout.Show();*/
        }
        void HUDdropout_Resize(object sender, EventArgs e)
        {
            if (HUDdropoutresize)
                return;

            HUDdropoutresize = true;

            int hudh = hud.Height;
            int formh = ((Form)sender).Height - 30;

            if (((Form)sender).Height < hudh)
            {
                if (((Form)sender).WindowState == FormWindowState.Maximized)
                {
                    Point tl = ((Form)sender).DesktopLocation;
                    ((Form)sender).WindowState = FormWindowState.Normal;
                    ((Form)sender).Location = tl;
                }
                ((Form)sender).Width = (int)(formh * (hud.SixteenXNine ? 1.777f : 1.333f));
                ((Form)sender).Height = formh + 20;
            }

            hud.Refresh();
            HUDdropoutresize = false;
        }

        void HUDdropout_FormClosed(object sender, FormClosedEventArgs e)
        {
            HUDdropout.Dispose();
        }
        private void FlightTime_Tick(object sender, EventArgs e)
        {
            flytimer = flytimer + 0.1;
        }
    }
}
