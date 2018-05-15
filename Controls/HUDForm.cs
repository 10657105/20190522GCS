using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner.Controls
{
    public partial class HUDForm : Form
    {
        public static HUD myhud;
        public HUDForm()
        {
            InitializeComponent();
            myhud = hud1;
        }
    }
}
