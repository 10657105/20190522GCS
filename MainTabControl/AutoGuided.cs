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
                    (Aend == true && Bend == true) ||
                    (Aend == true && Bend == true && Cend == true) ||
                    (Aend == true && Bend == true && Cend == true && Dend == true) ||
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
                float wpdistance = Acopter.MAV.cs.wp_dist;
                do
                {
                    wpdistance = Acopter.MAV.cs.wp_dist;
                    Thread.Sleep(450);
                } while (wpdistance >= 2);
                if (Acopter.MAV.cs.mode == "Brake")
                    Athread = false;
                if (Athread == false)
                    break;
            }
            if (Athread == true)
            {
                Acopter.setMode("RTL");
                Aend = true;
            }
        }
        private void BCopter()
        {
            if (!Bcopter.BaseStream.IsOpen)
            {
                CustomMessageBox.Show(Strings.PleaseConnect, Strings.ERROR);
                return;
            }

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
                float wpdistance = Bcopter.MAV.cs.wp_dist;
                do
                {
                    wpdistance = Bcopter.MAV.cs.wp_dist;
                    Thread.Sleep(450);
                } while (wpdistance >= 2);
                if (Bcopter.MAV.cs.mode == "Brake")
                    Bthread = false;
                if (Bthread == false)
                    break;
            }
            if (Bthread == true)
            {
                Bcopter.setMode("RTL");
                Bend = true;
            }

        }
        private void CCopter()
        {
            if (!Ccopter.BaseStream.IsOpen)
            {
                CustomMessageBox.Show(Strings.PleaseConnect, Strings.ERROR);
                return;
            }

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
                float wpdistance = Ccopter.MAV.cs.wp_dist;
                do
                {
                    wpdistance = Ccopter.MAV.cs.wp_dist;
                    Thread.Sleep(450);
                } while (wpdistance >= 2);
                if (Ccopter.MAV.cs.mode == "Brake")
                    Cthread = false;
                if (Cthread == false)
                    break;
            }
            if (Cthread == true)
            {
                Ccopter.setMode("RTL");
                Cend = true;
            }

        }
        private void DCopter()
        {
            if (!Dcopter.BaseStream.IsOpen)
            {
                CustomMessageBox.Show(Strings.PleaseConnect, Strings.ERROR);
                return;
            }

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
                float wpdistance = Dcopter.MAV.cs.wp_dist;
                do
                {
                    wpdistance = Dcopter.MAV.cs.wp_dist;
                    Thread.Sleep(450);
                } while (wpdistance >= 2);
                if (Dcopter.MAV.cs.mode == "Brake")
                    Dthread = false;
                if (Dthread == false)
                    break;
            }
            if (Dthread == true)
            {
                Dcopter.setMode("RTL");
                Dend = true;
            }
        }
        private void ECopter()
        {
            if (!Ecopter.BaseStream.IsOpen)
            {
                CustomMessageBox.Show(Strings.PleaseConnect, Strings.ERROR);
                return;
            }

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
                float wpdistance = Ecopter.MAV.cs.wp_dist;
                do
                {
                    wpdistance = Ecopter.MAV.cs.wp_dist;
                    Thread.Sleep(450);
                } while (wpdistance >= 2);
                if (Ecopter.MAV.cs.mode == "Brake")
                    Ethread = false;
                if (Ethread == false)
                    break;
            }
            if (Ethread == true)
            {
                Ecopter.setMode("RTL");
                Eend = true;
            }
        }

        private void Armed_and_Takeoff_All_Click(object sender, EventArgs e)
        {
            foreach (var port in MainV2.Comports)
            {
                foreach (var MAV in port.MAVlist)
                {
                    MAV.parent.doARM(MAV.sysid, MAV.compid, true);
                    MAV.parent.setMode(MAV.sysid, MAV.compid, "GUIDED");

                    MAV.parent.doCommand(MAV.sysid, MAV.compid, MAVLink.MAV_CMD.TAKEOFF, 0, 0, 0, 0, 0, 0, 5);
                }
            }
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
