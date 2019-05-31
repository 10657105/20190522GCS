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
using MissionPlanner.Utilities; // Locationwp function
using MissionPlanner.GCSViews;  // MainUserControl.cs function

namespace MissionPlanner.MainTabControl
{
    public partial class AutoGuided : MyUserControl
    {
        Locationwp gotohere = new Locationwp();
        public List<PointLatLngAlt> Apointlist = new List<PointLatLngAlt>(); //宣告Apointlist，接收FlightPlanner的A群List
        public List<PointLatLngAlt> Bpointlist = new List<PointLatLngAlt>(); //宣告Bpointlist，接收FlightPlanner的B群List
        public List<PointLatLngAlt> Cpointlist = new List<PointLatLngAlt>(); //宣告Cpointlist，接收FlightPlanner的C群List
        public List<PointLatLngAlt> Dpointlist = new List<PointLatLngAlt>(); //宣告Dpointlist，接收FlightPlanner的D群List
        public List<PointLatLngAlt> Epointlist = new List<PointLatLngAlt>(); //宣告Epointlist，接收FlightPlanner的E群List

        public delegate void mydalegate();
        public mydalegate change_text;
        public double alg_speed_a;//0305 演算後a機速度
        public double alg_speed_b;//0305 演算後b機速度
        public double alg_speed_c;//0305 演算後c機速度
        public double alg_speed_d;//0305 演算後d機速度
        public double alg_speed_e;//0305 演算後e機速度
        public float WP_radius;
        public int timeset_a;  //設定A抵達時間 
        public int timeset_b;  //設定B抵達時間 
        public int timeset_c;  //設定C抵達時間 
        public int timeset_d;  //設定D抵達時間 
        public int timeset_e;  //設定E抵達時間 
        static bool threadrun;
        static bool Athread;
        static bool Bthread;
        static bool Cthread;
        static bool Dthread;
        static bool Ethread;
        static bool Aend;
        static bool Bend;
        static bool Cend;
        static bool Dend;
        static bool Eend;

        internal MAVLinkInterface Acopter = null;
        internal MAVLinkInterface Bcopter = null;
        internal MAVLinkInterface Ccopter = null;
        internal MAVLinkInterface Dcopter = null;
        internal MAVLinkInterface Ecopter = null;
        
        private ComponentResourceManager rm = new ComponentResourceManager(typeof(AutoGuided));

        public AutoGuided()
        {
            InitializeComponent();
            change_text = new mydalegate(Button_start_end);
        }
        public void Button_start_end()
        {
            Button_start.Text = rm.GetString("startText");
        }

        private void Connection_Select_Click(object sender, EventArgs e)
        {
            bindingSource1.ResetBindings(false);
            bindingSource1.DataSource = MainV2.Comports;
            Connection_Select.DataSource = bindingSource1;
        }

        private void SetA_Click(object sender, EventArgs e)
        {
            foreach (var port in MainV2.Comports)
            {
                if (port.ToString() == Connection_Select.Text)
                {
                    Acopter = port;
                    LBL_ACopter.Text = rm.GetString("LBL_ACopter.Text") + port.BaseStream.PortName.ToString();
                    LBL_ACopter.ForeColor = Color.Yellow;
                }
            }
        }

        private void SetB_Click(object sender, EventArgs e)
        {
            foreach (var port in MainV2.Comports)
            {
                if (port.ToString() == Connection_Select.Text)
                {
                    Bcopter = port;
                    LBL_BCopter.Text = rm.GetString("LBL_BCopter.Text") + port.BaseStream.PortName.ToString();
                    LBL_BCopter.ForeColor = Color.Red;
                }
            }
        }

        private void SetC_Click(object sender, EventArgs e)
        {
            foreach (var port in MainV2.Comports)
            {
                if (port.ToString() == Connection_Select.Text)
                {
                    Ccopter = port;
                    LBL_CCopter.Text = rm.GetString("LBL_CCopter.Text") + port.BaseStream.PortName.ToString();
                    LBL_CCopter.ForeColor = Color.Cyan;
                }
            }
        }

        private void SetD_Click(object sender, EventArgs e)
        {
            foreach (var port in MainV2.Comports)
            {
                if (port.ToString() == Connection_Select.Text)
                {
                    Dcopter = port;
                    LBL_DCopter.Text = rm.GetString("LBL_DCopter.Text") + port.BaseStream.PortName.ToString();
                    LBL_DCopter.ForeColor = Color.Tomato;
                }
            }
        }

        private void SetE_Click(object sender, EventArgs e)
        {
            foreach (var port in MainV2.Comports)
            {
                if (port.ToString() == Connection_Select.Text)
                {
                    Ecopter = port;
                    LBL_ECopter.Text = rm.GetString("LBL_ECopter.Text") + port.BaseStream.PortName.ToString();
                    LBL_ECopter.ForeColor = Color.DeepPink;
                }
            }
        }
        private void SetAll_Click(object sender, EventArgs e)
        {
            if (MainV2.Comports[0] != null)
            {
                Acopter = MainV2.Comports[0];
                LBL_ACopter.Text = rm.GetString("LBL_ACopter.Text") + MainV2.Comports[0].BaseStream.PortName.ToString();
                LBL_ACopter.ForeColor = Color.Yellow;
            }
            if (MainV2.Comports.Count > 1)
            {
                Bcopter = MainV2.Comports[1];
                LBL_BCopter.Text = rm.GetString("LBL_BCopter.Text") + MainV2.Comports[1].BaseStream.PortName.ToString();
                LBL_BCopter.ForeColor = Color.Red;
            }
            if (MainV2.Comports.Count > 2)
            {
                Ccopter = MainV2.Comports[2];
                LBL_CCopter.Text = rm.GetString("LBL_CCopter.Text") + MainV2.Comports[2].BaseStream.PortName.ToString();
                LBL_CCopter.ForeColor = Color.Cyan;
            }
            if (MainV2.Comports.Count > 3)
            {
                Dcopter = MainV2.Comports[3];
                LBL_DCopter.Text = rm.GetString("LBL_DCopter.Text") + MainV2.Comports[3].BaseStream.PortName.ToString();
                LBL_DCopter.ForeColor = Color.Tomato;
            }
            if (MainV2.Comports.Count > 4)
            {
                Ecopter = MainV2.Comports[4];
                LBL_ECopter.Text = rm.GetString("LBL_ECopter.Text") + MainV2.Comports[4].BaseStream.PortName.ToString();
                LBL_ECopter.ForeColor = Color.DeepPink;
            }
        }

        private void Button_start_Click(object sender, EventArgs e)
        {
             if (threadrun == true)
             {
                 threadrun = false;
                 Athread = false;
                 Bthread = false;
                 Cthread = false;
                 Dthread = false;
                 Ethread = false;
                if(Acopter != null)
                     Acopter.setMode("Brake");
                if (Bcopter != null)
                    Bcopter.setMode("Brake");
                if (Ccopter != null)
                    Ccopter.setMode("Brake");
                if (Dcopter != null)
                    Dcopter.setMode("Brake");
                if (Ecopter != null)
                    Ecopter.setMode("Brake");
                Button_start.Text = rm.GetString("startText");
                return;
             }
             {
                 new System.Threading.Thread(Mainthread) { IsBackground = true }.Start();
                 Button_start.Text = rm.GetString("stopText");
                 Athread = false;
                 Bthread = false;
                 Cthread = false;
                 Dthread = false;
                 Ethread = false;
                 MainUserControls.Receivelist(ref Apointlist, ref Bpointlist, ref Cpointlist, ref Dpointlist, ref Epointlist);
             }

            
        }
        private void Mainthread()
        {
            threadrun = true;

            while (threadrun)
            {
                if (Athread == false && Acopter != null && Acopter.MAV.cs.mode != "Brake")
                {
                    Athread = true;
                    new System.Threading.Thread(ACopter) { IsBackground = true }.Start();
                }
                if (Bthread == false && Bcopter != null && Bcopter.MAV.cs.mode != "Brake")
                {
                    Bthread = true;
                    new System.Threading.Thread(BCopter) { IsBackground = true }.Start();
                }
                if (Cthread == false && Ccopter != null && Ccopter.MAV.cs.mode != "Brake")
                {
                    Cthread = true;
                    new System.Threading.Thread(CCopter) { IsBackground = true }.Start();
                }
                if (Dthread == false && Dcopter != null && Dcopter.MAV.cs.mode != "Brake")
                {
                    Dthread = true;
                    new System.Threading.Thread(DCopter) { IsBackground = true }.Start();
                }
                if (Ethread == false && Ecopter != null && Ecopter.MAV.cs.mode != "Brake")
                {
                    Ethread = true;
                    new System.Threading.Thread(ECopter) { IsBackground = true }.Start();
                }
                System.Threading.Thread.Sleep(450);       
                if ((Aend == true && Bcopter == null && Ccopter == null && Dcopter == null && Ecopter == null)||
                    (Aend == true && Bend == true && Ccopter == null && Dcopter == null && Ecopter == null) ||
                    (Aend == true && Bend == true && Cend == true && Dcopter == null && Ecopter == null) ||
                    (Aend == true && Bend == true && Cend == true && Dend == true && Ecopter == null) ||
                    (Aend == true && Bend == true && Cend == true && Dend == true && Eend == true))
                {
                    threadrun = false;
                    Athread = false;
                    Bthread = false;
                    Cthread = false;
                    Dthread = false;
                    Ethread = false;
                    Invoke(change_text);
                }
            }
        }
        private void ACopter()
        {
            if (!Acopter.BaseStream.IsOpen)
            {
                CustomMessageBox.Show(Strings.PleaseConnect, Strings.ERROR);
                return;
            }
            Acopter.setParam("WPNAV_SPEED", alg_speed_a * 100); //0211 WPNAV_SPEED is cm/s
            Acopter.setParam("WP_YAW_BEHAVIOR", 0); //0405不轉YAW //0:Never change yaw 1:Face next waypoint 2:Face next waypoint except RTL 3:Face along GPS course
            Acopter.setParam("ATC_ACCEL_P_MAX", 120000); //0506 加速度加快一點點 cdeg/s/s
            Acopter.setParam("ATC_ACCEL_R_MAX", 120000); //0506 roll 預設110000
            Acopter.setParam("RTL_ALT", Apointlist[Apointlist.Count - 1].Alt); //0211 RTL_ALT is cm
            float wpdistance = Acopter.MAV.cs.wp_dist;
            int wpi = 0;

            for (int i = 0; i < Apointlist.Count - 2; i++)
            {
                gotohere.id = (ushort)MAVLink.MAV_CMD.WAYPOINT;                
                gotohere.alt = (float)Apointlist[i + 1].Alt;  //List第0點是Home點
                gotohere.lat = Apointlist[i + 1].Lat;
                gotohere.lng = Apointlist[i + 1].Lng;
                
                try
                {                    
                    Acopter.setGuidedModeWP(gotohere);
                    Thread.Sleep(550);
                }
                catch (Exception ex)
                {
                    Acopter.giveComport = false;
                    CustomMessageBox.Show(Strings.CommandFailed + ex.Message, Strings.ERROR);
                }
                wpdistance = Acopter.MAV.cs.wp_dist;

                if (i == 0)
                {
                    this.Invoke(new Action(delegate ()
                    {
                        //DateTime start = DateTime.Now;
                        ConnectionData.ConnectionStatus1.FlightTime.Enabled = true;//0527 開始計時飛行時間
                    }));
                }
                do
                {
                    wpdistance = Acopter.MAV.cs.wp_dist;
                    Thread.Sleep(550);
                } while (wpdistance >= WP_radius);
                //float.Parse(MainUserControls2.TXT_WPRad.Text)
                //if (i == 0) Acopter.setParam("WPNAV_SPEED", 50); //0211可調每段速度
                //if (i == 1) Acopter.setParam("WPNAV_SPEED", 100); //0211
                if (Acopter.MAV.cs.mode == "Brake")
                    Athread = false;
                if (Athread == false) break;
                wpi++;
            }

            if (Athread == true)
            {                
                Acopter.setMode("RTL");
                Aend = true;
                Thread.Sleep(Convert.ToInt32(WP_radius / alg_speed_a * 1000));
                wpi = wpi + 1;
                do
                {
                    Thread.Sleep(100);
                    wpdistance = Acopter.MAV.cs.wp_dist;
                } while ((wpdistance >= WP_radius) || !(wpi == Apointlist.Count-1));
                this.Invoke(new Action(delegate ()
                {
                    ConnectionData.ConnectionStatus1.FlightTime.Enabled = false;//0527停止計時飛行時間
                }));
            }
            Thread.Sleep(1);
        }
        private void BCopter()
        {
            if (!Bcopter.BaseStream.IsOpen)
            {
                CustomMessageBox.Show(Strings.PleaseConnect, Strings.ERROR);
                return;
            }
            //Bcopter.setParam("WPNAV_SPEED", 200); //0211 改速度
            Bcopter.setParam("WPNAV_SPEED", alg_speed_b * 100); //0211 WPNAV_SPEED is cm/s
            Bcopter.setParam("WP_YAW_BEHAVIOR", 0); //0405 不轉YAW 
            //0:Never change yaw  1:Face next waypoint  2:Face next waypoint except RTL  3:Face along GPS course
            Bcopter.setParam("ATC_ACCEL_P_MAX", 120000); //0506 加速度加快一點點 cdeg/s/s
            Bcopter.setParam("ATC_ACCEL_R_MAX", 120000); //0506 roll 預設110000
            Bcopter.setParam("RTL_ALT", Bpointlist[Bpointlist.Count - 1].Alt); //0211 RTL_ALT is cm
            float wpdistance = Bcopter.MAV.cs.wp_dist;
            int wpi = 0;

            for (int i = 0; i < Bpointlist.Count - 2; i++)
            {
                gotohere.id = (ushort)MAVLink.MAV_CMD.WAYPOINT;                
                gotohere.alt = (float)Bpointlist[i + 1].Alt;  //List第0點是Home點
                gotohere.lat = Bpointlist[i + 1].Lat;
                gotohere.lng = Bpointlist[i + 1].Lng;
                try
                {
                    Bcopter.setGuidedModeWP(gotohere);
                    Thread.Sleep(550);
                }
                catch (Exception ex)
                {
                    Bcopter.giveComport = false;
                    CustomMessageBox.Show(Strings.CommandFailed + ex.Message, Strings.ERROR);
                }
                wpdistance = Bcopter.MAV.cs.wp_dist;

                if (i == 0)
                {
                    this.Invoke(new Action(delegate ()
                    {                        
                        ConnectionData.ConnectionStatus2.FlightTime.Enabled = true;
                    }));
                }
                do
                {
                    wpdistance = Bcopter.MAV.cs.wp_dist;
                    Thread.Sleep(550);
                } while (wpdistance >= WP_radius);
                /*if (i == 0) Bcopter.setParam("WPNAV_SPEED", 50); //0211
                if (i == 1) Bcopter.setParam("WPNAV_SPEED", 100);*/ //0211

                if (Bcopter.MAV.cs.mode == "Brake")
                    Bthread = false;
                if (Bthread == false) break;
                wpi++;
            }
            
            if (Bthread == true)
            {                
                Bcopter.setMode("RTL");
                Bend = true;
                Thread.Sleep(Convert.ToInt32(WP_radius / alg_speed_b * 1000));
                wpi = wpi + 1;
                do
                {
                    Thread.Sleep(100);
                    wpdistance = Bcopter.MAV.cs.wp_dist;
                } while ((wpdistance >= WP_radius) || !(wpi == Bpointlist.Count - 1));
                this.Invoke(new Action(delegate ()
                {
                    ConnectionData.ConnectionStatus2.FlightTime.Enabled = false;//0527停止計時飛行時間
                }));
            }
            Thread.Sleep(1);
        }
        private void CCopter()
        {
            if (!Ccopter.BaseStream.IsOpen)
            {
                CustomMessageBox.Show(Strings.PleaseConnect, Strings.ERROR);
                return;
            }
            
            Ccopter.setParam("WPNAV_SPEED", alg_speed_c * 100); //0211 WPNAV_SPEED is cm/s
            Ccopter.setParam("WP_YAW_BEHAVIOR", 0); //0405 不轉YAW 
            //0:Never change yaw  1:Face next waypoint  2:Face next waypoint except RTL  3:Face along GPS course
            Ccopter.setParam("ATC_ACCEL_P_MAX", 120000); //0506 pitch加速度加快一點點 cdeg/s/s
            Ccopter.setParam("ATC_ACCEL_R_MAX", 120000); //0506 roll 預設110000
            Ccopter.setParam("RTL_ALT", Cpointlist[Cpointlist.Count - 1].Alt); //0211 RTL_ALT is cm
            float wpdistance = Ccopter.MAV.cs.wp_dist;
            int wpi = 0;

            for (int i = 0; i < Cpointlist.Count - 2; i++)
            {
                gotohere.id = (ushort)MAVLink.MAV_CMD.WAYPOINT;
                gotohere.alt = (float)Cpointlist[i + 1].Alt;  //List第0點是Home點
                gotohere.lat = Cpointlist[i + 1].Lat;
                gotohere.lng = Cpointlist[i + 1].Lng;
                try
                {
                    Ccopter.setGuidedModeWP(gotohere);
                    Thread.Sleep(550);
                }
                catch (Exception ex)
                {
                    Ccopter.giveComport = false;
                    CustomMessageBox.Show(Strings.CommandFailed + ex.Message, Strings.ERROR);
                }
                wpdistance = Ccopter.MAV.cs.wp_dist;
                if (i == 0)
                {
                    this.Invoke(new Action(delegate ()
                    {                        
                        ConnectionData.ConnectionStatus3.FlightTime.Enabled = true;
                    }));
                }
                do
                {
                    wpdistance = Ccopter.MAV.cs.wp_dist;
                    Thread.Sleep(550);
                } while (wpdistance >= WP_radius);
                if (Ccopter.MAV.cs.mode == "Brake")
                    Cthread = false;
                if (Cthread == false) break;
                wpi++;
            }

            if (Cthread == true)
            {                
                Ccopter.setMode("RTL");
                Cend = true;
                Thread.Sleep(Convert.ToInt32(WP_radius / alg_speed_c* 1000));
                wpi = wpi + 1;
                do
                {
                    Thread.Sleep(100);
                    wpdistance = Ccopter.MAV.cs.wp_dist;
                } while ((wpdistance >= WP_radius) || !(wpi == Cpointlist.Count - 1));
                this.Invoke(new Action(delegate ()
                {
                    ConnectionData.ConnectionStatus3.FlightTime.Enabled = false;//0527停止計時飛行時間
                }));
            }
            Thread.Sleep(1);
        }
        private void DCopter()
        {
            if (!Dcopter.BaseStream.IsOpen)
            {
                CustomMessageBox.Show(Strings.PleaseConnect, Strings.ERROR);
                return;
            }

            Dcopter.setParam("WPNAV_SPEED", alg_speed_d * 100); //0211 WPNAV_SPEED is cm/s
            Dcopter.setParam("WP_YAW_BEHAVIOR", 0); //0405不轉YAW //0:Never change yaw 1:Face next waypoint 2:Face next waypoint except RTL 3:Face along GPS course
            Dcopter.setParam("ATC_ACCEL_P_MAX", 120000); //0506 加速度加快一點點 cdeg/s/s
            Dcopter.setParam("ATC_ACCEL_R_MAX", 120000); //0506 roll 預設110000            
            Dcopter.setParam("RTL_ALT", Dpointlist[Dpointlist.Count - 1].Alt); //0211 RTL_ALT is cm
            float wpdistance = Dcopter.MAV.cs.wp_dist;
            int wpi = 0;

            for (int i = 0; i < Dpointlist.Count - 2; i++)
            {
                gotohere.id = (ushort)MAVLink.MAV_CMD.WAYPOINT;
                gotohere.alt = (float)Dpointlist[i + 1].Alt;  //List第0點是Home點
                gotohere.lat = Dpointlist[i + 1].Lat;
                gotohere.lng = Dpointlist[i + 1].Lng;
                try
                {
                    Dcopter.setGuidedModeWP(gotohere);
                    Thread.Sleep(550);
                }
                catch (Exception ex)
                {
                    Dcopter.giveComport = false;
                    CustomMessageBox.Show(Strings.CommandFailed + ex.Message, Strings.ERROR);
                }
                wpdistance = Dcopter.MAV.cs.wp_dist;

                if (i == 0)
                {
                    this.Invoke(new Action(delegate ()
                    {
                        ConnectionData.ConnectionStatus4.FlightTime.Enabled = true;//0527 開始計時飛行時間
                    }));
                }
                do
                {
                    wpdistance = Dcopter.MAV.cs.wp_dist;
                    Thread.Sleep(550);
                } while (wpdistance >= WP_radius);
                if (Dcopter.MAV.cs.mode == "Brake")
                    Dthread = false;
                if (Dthread == false) break;
                wpi++;
            }

            if (Dthread == true)
            {                
                Dcopter.setMode("RTL");
                Dend = true;
                Thread.Sleep(Convert.ToInt32(WP_radius / alg_speed_d * 1000));
                wpi = wpi + 1;
                do
                {
                    Thread.Sleep(100);
                    wpdistance = Dcopter.MAV.cs.wp_dist;
                } while ((wpdistance >= WP_radius) || !(wpi == Dpointlist.Count - 1));
                this.Invoke(new Action(delegate ()
                {
                    ConnectionData.ConnectionStatus4.FlightTime.Enabled = false;//0527停止計時飛行時間
                }));
            }
            Thread.Sleep(1);
        }
        private void ECopter()
        {
            if (!Ecopter.BaseStream.IsOpen)
            {
                CustomMessageBox.Show(Strings.PleaseConnect, Strings.ERROR);
                return;
            }

            Ecopter.setParam("WPNAV_SPEED", alg_speed_e * 100); //0211 WPNAV_SPEED is cm/s
            Ecopter.setParam("WP_YAW_BEHAVIOR", 0); //0405 不轉YAW 
            //0:Never change yaw  1:Face next waypoint  2:Face next waypoint except RTL  3:Face along GPS course
            Ecopter.setParam("ATC_ACCEL_P_MAX", 120000); //0506 加速度加快一點點 cdeg/s/s
            Ecopter.setParam("ATC_ACCEL_R_MAX", 120000); //0506 roll 預設110000
            Ecopter.setParam("RTL_ALT", Epointlist[Epointlist.Count - 1].Alt); //0211 RTL_ALT is cm
            float wpdistance = Ecopter.MAV.cs.wp_dist;
            int wpi = 0;

            for (int i = 0; i < Epointlist.Count - 2; i++)
            {
                gotohere.id = (ushort)MAVLink.MAV_CMD.WAYPOINT;
                gotohere.alt = (float)Epointlist[i + 1].Alt;  //List第0點是Home點
                gotohere.lat = Epointlist[i + 1].Lat;
                gotohere.lng = Epointlist[i + 1].Lng;
                try
                {
                    Ecopter.setGuidedModeWP(gotohere);
                    Thread.Sleep(550);
                }
                catch (Exception ex)
                {
                    Ecopter.giveComport = false;
                    CustomMessageBox.Show(Strings.CommandFailed + ex.Message, Strings.ERROR);
                }
                wpdistance = Ecopter.MAV.cs.wp_dist;

                if (i == 0)
                {
                    this.Invoke(new Action(delegate ()
                    {
                       ConnectionData.ConnectionStatus5.FlightTime.Enabled = true;//0527 開始計時飛行時間
                    }));
                }
                do
                {
                    wpdistance = Ecopter.MAV.cs.wp_dist;
                    Thread.Sleep(550);
                } while (wpdistance >= WP_radius);
                if (Ecopter.MAV.cs.mode == "Brake")
                    Ethread = false;
                if (Ethread == false) break;
                wpi++;
            }

            if (Ethread == true)
            {               
                Ecopter.setMode("RTL");
                Eend = true;
                Thread.Sleep(Convert.ToInt32(WP_radius / alg_speed_e  * 1000));
                wpi = wpi + 1;
                do
                {
                    Thread.Sleep(100);
                    wpdistance = Ecopter.MAV.cs.wp_dist;
                } while ((wpdistance >= WP_radius) || !(wpi == Epointlist.Count - 1));
                this.Invoke(new Action(delegate ()
                {
                    ConnectionData.ConnectionStatus5.FlightTime.Enabled = false;//0527停止計時飛行時間
                }));
            }
            Thread.Sleep(1);
        }

        private void Armed_and_Takeoff_All_Click(object sender, EventArgs e)
        {
            if (MainV2.Comports[0] != null)
            {
                Thread ThreadAA = new Thread(new ThreadStart(Armed_and_Takeoff_All_Click_Start_AA));
                ThreadAA.IsBackground = true;
                ThreadAA.Start();
            }
            if (MainV2.Comports.Count>1)
            {
                Thread ThreadBB = new Thread(new ThreadStart(Armed_and_Takeoff_All_Click_Start_BB));
                ThreadBB.IsBackground = true;
                ThreadBB.Start();
            }
            if (MainV2.Comports.Count > 2)
            {
                Thread ThreadCC = new Thread(new ThreadStart(Armed_and_Takeoff_All_Click_Start_CC));
                ThreadCC.IsBackground = true;
                ThreadCC.Start();
            }
            if (MainV2.Comports.Count > 3)
            {
                Thread ThreadDD = new Thread(new ThreadStart(Armed_and_Takeoff_All_Click_Start_DD));
                ThreadDD.IsBackground = true;
                ThreadDD.Start();
            }
            if (MainV2.Comports.Count > 4)
            {
                Thread ThreadEE = new Thread(new ThreadStart(Armed_and_Takeoff_All_Click_Start_EE));
                ThreadEE.IsBackground = true;
                ThreadEE.Start();
            }

            Armed_and_Takeoff_All.Enabled = false;//0508 防止按鈕重複點擊
        }
        private void Armed_and_Takeoff_All_Click_Start_AA()
        {
            foreach (var MAV in MainV2.Comports[0].MAVlist)
            {
                MAV.parent.doARM(MAV.sysid, MAV.compid, true);
                MAV.parent.setMode(MAV.sysid, MAV.compid, "GUIDED");
                MAV.parent.doCommand(MAV.sysid, MAV.compid, MAVLink.MAV_CMD.TAKEOFF, 0, 0, 0, 0, 0, 0, 7);
            }
            Thread.Sleep(1);
        }
        private void Armed_and_Takeoff_All_Click_Start_BB()
        {
            foreach (var MAV in MainV2.Comports[1].MAVlist)
            {
                MAV.parent.doARM(MAV.sysid, MAV.compid, true);
                MAV.parent.setMode(MAV.sysid, MAV.compid, "GUIDED");
                MAV.parent.doCommand(MAV.sysid, MAV.compid, MAVLink.MAV_CMD.TAKEOFF, 0, 0, 0, 0, 0, 0, 7);
            }
            Thread.Sleep(1);            
        }
        private void Armed_and_Takeoff_All_Click_Start_CC()
        {
            foreach (var MAV in MainV2.Comports[2].MAVlist)
            {
                MAV.parent.doARM(MAV.sysid, MAV.compid, true);
                MAV.parent.setMode(MAV.sysid, MAV.compid, "GUIDED");
                MAV.parent.doCommand(MAV.sysid, MAV.compid, MAVLink.MAV_CMD.TAKEOFF, 0, 0, 0, 0, 0, 0, 7);
            }
            Thread.Sleep(1);
        }
        private void Armed_and_Takeoff_All_Click_Start_DD()
        {
            foreach (var MAV in MainV2.Comports[3].MAVlist)
            {
                MAV.parent.doARM(MAV.sysid, MAV.compid, true);
                MAV.parent.setMode(MAV.sysid, MAV.compid, "GUIDED");
                MAV.parent.doCommand(MAV.sysid, MAV.compid, MAVLink.MAV_CMD.TAKEOFF, 0, 0, 0, 0, 0, 0, 7);
            }
            Thread.Sleep(1);
        }
        private void Armed_and_Takeoff_All_Click_Start_EE()
        {
            foreach (var MAV in MainV2.Comports[4].MAVlist)
            {
                MAV.parent.doARM(MAV.sysid, MAV.compid, true);
                MAV.parent.setMode(MAV.sysid, MAV.compid, "GUIDED");
                MAV.parent.doCommand(MAV.sysid, MAV.compid, MAVLink.MAV_CMD.TAKEOFF, 0, 0, 0, 0, 0, 0, 7);
            }
            Thread.Sleep(1);
        }

        private void Reset_Connection_Button_Click(object sender, EventArgs e)
        {
            LBL_ACopter.Text = rm.GetString("LBL_ACopter.Text");
            LBL_ACopter.ForeColor = Color.White;
            LBL_BCopter.Text = rm.GetString("LBL_BCopter.Text");
            LBL_BCopter.ForeColor = Color.White;
            LBL_CCopter.Text = rm.GetString("LBL_CCopter.Text");
            LBL_CCopter.ForeColor = Color.White;
            LBL_DCopter.Text = rm.GetString("LBL_DCopter.Text");
            LBL_DCopter.ForeColor = Color.White;
            LBL_ECopter.Text = rm.GetString("LBL_ECopter.Text");
            LBL_ECopter.ForeColor = Color.White;
            Acopter = null;
            Bcopter = null;
            Ccopter = null;
            Dcopter = null;
            Ecopter = null;
        }


    }
}
