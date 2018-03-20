using MissionPlanner.Controls;

namespace MissionPlanner.MainTabControl
{
    partial class WayPointControl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.coords1 = new MissionPlanner.Controls.Coords();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chk_grid = new System.Windows.Forms.CheckBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.comboBoxMapType = new System.Windows.Forms.ComboBox();
            this.lnk_kml = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_wpfile = new System.Windows.Forms.Label();
            this.BUT_loadwpfile = new MissionPlanner.Controls.MyButton();
            this.BUT_saveWPFile = new MissionPlanner.Controls.MyButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BUT_write = new MissionPlanner.Controls.MyButton();
            this.BUT_read = new MissionPlanner.Controls.MyButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TXT_homealt = new System.Windows.Forms.TextBox();
            this.TXT_homelng = new System.Windows.Forms.TextBox();
            this.TXT_homelat = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_distance_E = new System.Windows.Forms.Label();
            this.Groupcountset = new System.Windows.Forms.TextBox();
            this.lbl_distance_D = new System.Windows.Forms.Label();
            this.Groupcount_label = new System.Windows.Forms.Label();
            this.lbl_distance_C = new System.Windows.Forms.Label();
            this.Path_Programming_button = new MissionPlanner.Controls.MyButton();
            this.lbl_distance_B = new System.Windows.Forms.Label();
            this.lbl_distance_A = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(158, 534);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.coords1);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(127, 55);
            this.panel4.TabIndex = 51;
            // 
            // coords1
            // 
            this.coords1.Alt = 0D;
            this.coords1.AltSource = "";
            this.coords1.AltUnit = "m";
            this.coords1.Lat = 0D;
            this.coords1.Lng = 0D;
            this.coords1.Location = new System.Drawing.Point(0, 0);
            this.coords1.Name = "coords1";
            this.coords1.Size = new System.Drawing.Size(127, 55);
            this.coords1.TabIndex = 16;
            this.coords1.Vertical = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chk_grid);
            this.panel3.Controls.Add(this.lbl_status);
            this.panel3.Controls.Add(this.comboBoxMapType);
            this.panel3.Controls.Add(this.lnk_kml);
            this.panel3.Location = new System.Drawing.Point(3, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(123, 61);
            this.panel3.TabIndex = 52;
            // 
            // chk_grid
            // 
            this.chk_grid.AutoSize = true;
            this.chk_grid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chk_grid.Location = new System.Drawing.Point(3, 3);
            this.chk_grid.Name = "chk_grid";
            this.chk_grid.Size = new System.Drawing.Size(45, 16);
            this.chk_grid.TabIndex = 44;
            this.chk_grid.Text = "Grid";
            this.chk_grid.UseVisualStyleBackColor = true;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_status.Location = new System.Drawing.Point(4, 46);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(32, 12);
            this.lbl_status.TabIndex = 43;
            this.lbl_status.Text = "Status";
            // 
            // comboBoxMapType
            // 
            this.comboBoxMapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMapType.FormattingEnabled = true;
            this.comboBoxMapType.Location = new System.Drawing.Point(3, 22);
            this.comboBoxMapType.Name = "comboBoxMapType";
            this.comboBoxMapType.Size = new System.Drawing.Size(111, 20);
            this.comboBoxMapType.TabIndex = 42;
            // 
            // lnk_kml
            // 
            this.lnk_kml.AutoSize = true;
            this.lnk_kml.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnk_kml.Location = new System.Drawing.Point(62, 3);
            this.lnk_kml.Name = "lnk_kml";
            this.lnk_kml.Size = new System.Drawing.Size(57, 12);
            this.lnk_kml.TabIndex = 45;
            this.lnk_kml.TabStop = true;
            this.lnk_kml.Text = "View KML";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_wpfile);
            this.panel2.Controls.Add(this.BUT_loadwpfile);
            this.panel2.Controls.Add(this.BUT_saveWPFile);
            this.panel2.Location = new System.Drawing.Point(3, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(123, 75);
            this.panel2.TabIndex = 53;
            // 
            // lbl_wpfile
            // 
            this.lbl_wpfile.AutoSize = true;
            this.lbl_wpfile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_wpfile.Location = new System.Drawing.Point(3, 59);
            this.lbl_wpfile.Name = "lbl_wpfile";
            this.lbl_wpfile.Size = new System.Drawing.Size(14, 12);
            this.lbl_wpfile.TabIndex = 48;
            this.lbl_wpfile.Text = "...";
            // 
            // BUT_loadwpfile
            // 
            this.BUT_loadwpfile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_loadwpfile.Location = new System.Drawing.Point(3, 3);
            this.BUT_loadwpfile.Name = "BUT_loadwpfile";
            this.BUT_loadwpfile.Size = new System.Drawing.Size(107, 23);
            this.BUT_loadwpfile.TabIndex = 46;
            this.BUT_loadwpfile.Text = "Load WP File";
            this.BUT_loadwpfile.UseVisualStyleBackColor = true;
            
            // 
            // BUT_saveWPFile
            // 
            this.BUT_saveWPFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_saveWPFile.Location = new System.Drawing.Point(3, 32);
            this.BUT_saveWPFile.Name = "BUT_saveWPFile";
            this.BUT_saveWPFile.Size = new System.Drawing.Size(107, 23);
            this.BUT_saveWPFile.TabIndex = 47;
            this.BUT_saveWPFile.Text = "Save WP File";
            this.BUT_saveWPFile.UseVisualStyleBackColor = true;
            
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BUT_write);
            this.panel5.Controls.Add(this.BUT_read);
            this.panel5.Location = new System.Drawing.Point(3, 212);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(123, 63);
            this.panel5.TabIndex = 54;
            // 
            // BUT_write
            // 
            this.BUT_write.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_write.Location = new System.Drawing.Point(3, 32);
            this.BUT_write.Name = "BUT_write";
            this.BUT_write.Size = new System.Drawing.Size(107, 23);
            this.BUT_write.TabIndex = 8;
            this.BUT_write.Text = "Write WPs";
            this.BUT_write.UseVisualStyleBackColor = true;
            
            // 
            // BUT_read
            // 
            this.BUT_read.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_read.Location = new System.Drawing.Point(3, 4);
            this.BUT_read.Name = "BUT_read";
            this.BUT_read.Size = new System.Drawing.Size(107, 23);
            this.BUT_read.TabIndex = 7;
            this.BUT_read.Text = "Read WPs";
            this.BUT_read.UseVisualStyleBackColor = true;
            
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.TXT_homealt);
            this.panel1.Controls.Add(this.TXT_homelng);
            this.panel1.Controls.Add(this.TXT_homelat);
            this.panel1.Location = new System.Drawing.Point(3, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 89);
            this.panel1.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(18, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 6;
            this.label4.TabStop = true;
            this.label4.Text = "Home Location";        
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alt (abs)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Long";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label1.Location = new System.Drawing.Point(4, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(20, 12);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Lat";
            // 
            // TXT_homealt
            // 
            this.TXT_homealt.Location = new System.Drawing.Point(47, 65);
            this.TXT_homealt.Name = "TXT_homealt";
            this.TXT_homealt.Size = new System.Drawing.Size(65, 22);
            this.TXT_homealt.TabIndex = 14;
            // 
            // TXT_homelng
            // 
            this.TXT_homelng.Location = new System.Drawing.Point(47, 42);
            this.TXT_homelng.Name = "TXT_homelng";
            this.TXT_homelng.Size = new System.Drawing.Size(65, 22);
            this.TXT_homelng.TabIndex = 13;
            // 
            // TXT_homelat
            // 
            this.TXT_homelat.Location = new System.Drawing.Point(47, 18);
            this.TXT_homelat.Name = "TXT_homelat";
            this.TXT_homelat.Size = new System.Drawing.Size(65, 22);
            this.TXT_homelat.TabIndex = 12;         
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbl_distance_E);
            this.panel6.Controls.Add(this.Groupcountset);
            this.panel6.Controls.Add(this.lbl_distance_D);
            this.panel6.Controls.Add(this.Groupcount_label);
            this.panel6.Controls.Add(this.lbl_distance_C);
            this.panel6.Controls.Add(this.Path_Programming_button);
            this.panel6.Controls.Add(this.lbl_distance_B);
            this.panel6.Controls.Add(this.lbl_distance_A);
            this.panel6.Location = new System.Drawing.Point(3, 376);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(152, 129);
            this.panel6.TabIndex = 56;
            // 
            // lbl_distance_E
            // 
            this.lbl_distance_E.AutoSize = true;
            this.lbl_distance_E.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_distance_E.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_distance_E.Location = new System.Drawing.Point(3, 112);
            this.lbl_distance_E.Name = "lbl_distance_E";
            this.lbl_distance_E.Size = new System.Drawing.Size(57, 12);
            this.lbl_distance_E.TabIndex = 55;
            this.lbl_distance_E.Text = "Distance_E";
            // 
            // Groupcountset
            // 
            this.Groupcountset.Location = new System.Drawing.Point(86, 9);
            this.Groupcountset.Name = "Groupcountset";
            this.Groupcountset.Size = new System.Drawing.Size(33, 22);
            this.Groupcountset.TabIndex = 53;
            // 
            // lbl_distance_D
            // 
            this.lbl_distance_D.AutoSize = true;
            this.lbl_distance_D.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_distance_D.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_distance_D.Location = new System.Drawing.Point(3, 101);
            this.lbl_distance_D.Name = "lbl_distance_D";
            this.lbl_distance_D.Size = new System.Drawing.Size(58, 12);
            this.lbl_distance_D.TabIndex = 54;
            this.lbl_distance_D.Text = "Distance_D";
            // 
            // Groupcount_label
            // 
            this.Groupcount_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Groupcount_label.AutoSize = true;
            this.Groupcount_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Groupcount_label.Location = new System.Drawing.Point(6, 14);
            this.Groupcount_label.Name = "Groupcount_label";
            this.Groupcount_label.Size = new System.Drawing.Size(73, 12);
            this.Groupcount_label.TabIndex = 52;
            this.Groupcount_label.Text = "Groupcountset";
            // 
            // lbl_distance_C
            // 
            this.lbl_distance_C.AutoSize = true;
            this.lbl_distance_C.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_distance_C.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_distance_C.Location = new System.Drawing.Point(3, 89);
            this.lbl_distance_C.Name = "lbl_distance_C";
            this.lbl_distance_C.Size = new System.Drawing.Size(58, 12);
            this.lbl_distance_C.TabIndex = 53;
            this.lbl_distance_C.Text = "Distance_C";
            // 
            // Path_Programming_button
            // 
            this.Path_Programming_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Path_Programming_button.Location = new System.Drawing.Point(6, 36);
            this.Path_Programming_button.Name = "Path_Programming_button";
            this.Path_Programming_button.Size = new System.Drawing.Size(112, 23);
            this.Path_Programming_button.TabIndex = 51;
            this.Path_Programming_button.Text = "Path Programming";
            this.Path_Programming_button.UseVisualStyleBackColor = true;
            // 
            // lbl_distance_B
            // 
            this.lbl_distance_B.AutoSize = true;
            this.lbl_distance_B.BackColor = System.Drawing.Color.Transparent;
            this.lbl_distance_B.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_distance_B.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_distance_B.Location = new System.Drawing.Point(3, 77);
            this.lbl_distance_B.Name = "lbl_distance_B";
            this.lbl_distance_B.Size = new System.Drawing.Size(58, 12);
            this.lbl_distance_B.TabIndex = 52;
            this.lbl_distance_B.Text = "Distance_B";
            // 
            // lbl_distance_A
            // 
            this.lbl_distance_A.AutoSize = true;
            this.lbl_distance_A.BackColor = System.Drawing.Color.Transparent;
            this.lbl_distance_A.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_distance_A.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_distance_A.Location = new System.Drawing.Point(3, 65);
            this.lbl_distance_A.Name = "lbl_distance_A";
            this.lbl_distance_A.Size = new System.Drawing.Size(58, 12);
            this.lbl_distance_A.TabIndex = 51;
            this.lbl_distance_A.Text = "Distance_A";
            // 
            // WayPointControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "WayPointControl";
            this.Size = new System.Drawing.Size(158, 534);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label Groupcount_label;
        public Coords coords1;
        public System.Windows.Forms.CheckBox chk_grid;
        public System.Windows.Forms.Label lbl_status;
        public System.Windows.Forms.ComboBox comboBoxMapType;
        public System.Windows.Forms.LinkLabel lnk_kml;
        public MyButton BUT_loadwpfile;
        public MyButton BUT_saveWPFile;
        public MyButton BUT_write;
        public MyButton BUT_read;
        public System.Windows.Forms.TextBox TXT_homealt;
        public System.Windows.Forms.TextBox TXT_homelng;
        public System.Windows.Forms.TextBox TXT_homelat;
        public System.Windows.Forms.Label lbl_distance_E;
        public System.Windows.Forms.TextBox Groupcountset;
        public System.Windows.Forms.Label lbl_distance_D;
        public System.Windows.Forms.Label lbl_distance_C;
        public MyButton Path_Programming_button;
        public System.Windows.Forms.Label lbl_distance_B;
        public System.Windows.Forms.Label lbl_distance_A;
        public System.Windows.Forms.Label lbl_wpfile;
        public System.Windows.Forms.LinkLabel label4;
    }
}
