﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MissionPlanner.Controls;

namespace MissionPlanner.GCSViews
{
    public partial class ConnectionData : MyUserControl
    {
        public static HUD hud;
        public ConnectionData()
        {
            InitializeComponent();
            hud = new HUD();
            /*try
            {
                label1.Text = hud.batterylevel.ToString();
            }
            catch { }*/
        }


    }
}
