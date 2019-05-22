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
        public static bool threadrun = true;
        public static ConnectionStatus ConnectionStatus1 = new ConnectionStatus();
        public static ConnectionStatus ConnectionStatus2 = new ConnectionStatus();
        public static ConnectionStatus ConnectionStatus3 = new ConnectionStatus();
        public static ConnectionStatus ConnectionStatus4 = new ConnectionStatus();
        public static ConnectionStatus ConnectionStatus5 = new ConnectionStatus();
        public static Thread ThreadA;

        public ConnectionData()
        {
            InitializeComponent();

            // 
            // connectionStatus1
            // 
            tableLayoutPanel1.Controls.Add(ConnectionStatus1, 0, 0);
            ConnectionStatus1.Dock = DockStyle.Fill;
            ConnectionStatus1.Location = new System.Drawing.Point(3, 240);
            ConnectionStatus1.Name = "connectionStatus1";
            ConnectionStatus1.Size = new System.Drawing.Size(141, 61);
            ConnectionStatus1.TabIndex = 1;
            // 
            // connectionStatus2
            // 
            tableLayoutPanel1.Controls.Add(ConnectionStatus2, 0, 1);
            ConnectionStatus2.Dock = DockStyle.Fill;
            ConnectionStatus2.Location = new System.Drawing.Point(3, 240);
            ConnectionStatus2.Name = "connectionStatus2";
            ConnectionStatus2.Size = new System.Drawing.Size(141, 61);
            ConnectionStatus2.TabIndex = 1;
            ConnectionStatus2.Visible = false;
            // 
            // connectionStatus3
            // 
            tableLayoutPanel1.Controls.Add(ConnectionStatus3, 0, 2);
            ConnectionStatus3.Dock = DockStyle.Fill;
            ConnectionStatus3.Location = new System.Drawing.Point(3, 240);
            ConnectionStatus3.Name = "connectionStatus3";
            ConnectionStatus3.Size = new System.Drawing.Size(141, 61);
            ConnectionStatus3.TabIndex = 1;
            ConnectionStatus3.Visible = false;
            // 
            // connectionStatus4
            // 
            tableLayoutPanel1.Controls.Add(ConnectionStatus4, 0, 3);
            ConnectionStatus4.Dock = DockStyle.Fill;
            ConnectionStatus4.Location = new System.Drawing.Point(3, 240);
            ConnectionStatus4.Name = "connectionStatus4";
            ConnectionStatus4.Size = new System.Drawing.Size(141, 61);
            ConnectionStatus4.TabIndex = 1;
            ConnectionStatus4.Visible = false;
            //
            // connectionStatus5
            // 
            tableLayoutPanel1.Controls.Add(ConnectionStatus5, 0, 4);
            ConnectionStatus5.Dock = DockStyle.Fill;
            ConnectionStatus5.Location = new System.Drawing.Point(3, 240);
            ConnectionStatus5.Name = "connectionStatus5";
            ConnectionStatus5.Size = new System.Drawing.Size(141, 61);
            ConnectionStatus5.TabIndex = 1;
            ConnectionStatus5.Visible = false;

            ThreadA = new Thread(new ThreadStart(Mainthread));
            ThreadA.IsBackground = true;
            ThreadA.Start();

        }
        
        public void Mainthread()
        {            
            while (threadrun)
            {
                if (MainV2.comPort.BaseStream.IsOpen)
                {
                    if (MainV2.Comports[0] != null || MainV2.Comports[0].ToString() != "MAV 0 on Ice")
                    {                        
                        if(MainV2.Comports[0].ToString() == "MAV 0 on Ice")
                        {
                            MainV2.Comports.Remove(MainV2.Comports[0]);
                        }
                        ConnectionStatus1.InputMAVlink = MainV2.Comports[0]; //
                    }

                    if (MainV2.Comports.Count > 1 && MainV2.Comports[1] != null && MainV2.Comports[0].ToString() != "MAV 0 on Ice")
                    {
                        ConnectionStatus2.InputMAVlink = MainV2.Comports[1];
                        this.Invoke(new Action(delegate ()
                        {
                            ConnectionStatus2.Visible = true;
                        }));
                    }

                    if (MainV2.Comports.Count > 2 && MainV2.Comports[2] != null && MainV2.Comports[0].ToString() != "MAV 0 on Ice")
                    {
                        ConnectionStatus3.InputMAVlink = MainV2.Comports[2];
                        this.Invoke(new Action(delegate ()
                        {
                            ConnectionStatus3.Visible = true;
                        }));
                    }
                    if (MainV2.Comports.Count > 3 && MainV2.Comports[3] != null && MainV2.Comports[0].ToString() != "MAV 0 on Ice")
                    {
                        ConnectionStatus4.InputMAVlink = MainV2.Comports[3];
                        this.Invoke(new Action(delegate ()
                        {
                            ConnectionStatus4.Visible = true;
                        }));
                    }
                    if (MainV2.Comports.Count > 4 && MainV2.Comports[4] != null && MainV2.Comports[0].ToString() != "MAV 0 on Ice")
                    {
                        ConnectionStatus5.InputMAVlink = MainV2.Comports[4];
                        this.Invoke(new Action(delegate ()
                        {
                            ConnectionStatus5.Visible = true;
                        }));
                    }
                }
              Thread.Sleep(1);//100不行
            }
            
        }

    }
}
