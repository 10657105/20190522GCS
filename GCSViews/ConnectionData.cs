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
        public static CurrentState curs;
        //public static HUD ;
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
                    label1.Text = MainV2.comPort.MAV.cs.battery_voltage.ToString();
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
    }
}
