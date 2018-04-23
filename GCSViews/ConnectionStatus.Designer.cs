namespace MissionPlanner.GCSViews
{
    partial class ConnectionStatus
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label_alt = new System.Windows.Forms.Label();
            this.label_ekf = new System.Windows.Forms.Label();
            this.label_GroundSpeed = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_battery = new System.Windows.Forms.Label();
            this.label_GPS = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label_mode = new System.Windows.Forms.Label();
            this.label_PortName = new System.Windows.Forms.Label();
            this.label_linkquality = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_armedstatus = new System.Windows.Forms.Label();
            this.label_yaw = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(193, 139);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.label_yaw, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_alt, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_GroundSpeed, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_ekf, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 49);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(187, 40);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label_alt
            // 
            this.label_alt.AutoSize = true;
            this.label_alt.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_alt.Location = new System.Drawing.Point(3, 0);
            this.label_alt.Name = "label_alt";
            this.label_alt.Size = new System.Drawing.Size(29, 40);
            this.label_alt.TabIndex = 0;
            this.label_alt.Text = "0.0m";
            // 
            // label_ekf
            // 
            this.label_ekf.AutoSize = true;
            this.label_ekf.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_ekf.Location = new System.Drawing.Point(151, 0);
            this.label_ekf.Name = "label_ekf";
            this.label_ekf.Size = new System.Drawing.Size(26, 40);
            this.label_ekf.TabIndex = 1;
            this.label_ekf.Text = "EKF";
            // 
            // label_GroundSpeed
            // 
            this.label_GroundSpeed.AutoSize = true;
            this.label_GroundSpeed.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_GroundSpeed.Location = new System.Drawing.Point(95, 0);
            this.label_GroundSpeed.Name = "label_GroundSpeed";
            this.label_GroundSpeed.Size = new System.Drawing.Size(36, 40);
            this.label_GroundSpeed.TabIndex = 3;
            this.label_GroundSpeed.Text = "0.0m/s";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label_battery, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label_GPS, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 95);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(187, 41);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::MissionPlanner.Properties.Resources.satellite;
            this.pictureBox1.Location = new System.Drawing.Point(96, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label_battery
            // 
            this.label_battery.AutoSize = true;
            this.label_battery.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_battery.Location = new System.Drawing.Point(3, 0);
            this.label_battery.Name = "label_battery";
            this.label_battery.Size = new System.Drawing.Size(66, 41);
            this.label_battery.TabIndex = 3;
            this.label_battery.Text = "0.0V     0.0A";
            // 
            // label_GPS
            // 
            this.label_GPS.AutoSize = true;
            this.label_GPS.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_GPS.Location = new System.Drawing.Point(114, 0);
            this.label_GPS.Name = "label_GPS";
            this.label_GPS.Size = new System.Drawing.Size(23, 41);
            this.label_GPS.TabIndex = 4;
            this.label_GPS.Text = "Sats";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.81943F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.790875F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.07809F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.20749F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.10412F));
            this.tableLayoutPanel5.Controls.Add(this.label_mode, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.label_PortName, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label_linkquality, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label_armedstatus, 4, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(187, 40);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // label_mode
            // 
            this.label_mode.AutoSize = true;
            this.label_mode.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_mode.Location = new System.Drawing.Point(103, 0);
            this.label_mode.Name = "label_mode";
            this.label_mode.Size = new System.Drawing.Size(32, 40);
            this.label_mode.TabIndex = 3;
            this.label_mode.Text = "Mode";
            // 
            // label_PortName
            // 
            this.label_PortName.AutoSize = true;
            this.label_PortName.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_PortName.Location = new System.Drawing.Point(3, 0);
            this.label_PortName.Name = "label_PortName";
            this.label_PortName.Size = new System.Drawing.Size(46, 40);
            this.label_PortName.TabIndex = 0;
            this.label_PortName.Text = "PortName";
            // 
            // label_linkquality
            // 
            this.label_linkquality.AutoSize = true;
            this.label_linkquality.Location = new System.Drawing.Point(70, 0);
            this.label_linkquality.Name = "label_linkquality";
            this.label_linkquality.Size = new System.Drawing.Size(20, 12);
            this.label_linkquality.TabIndex = 1;
            this.label_linkquality.Text = "0%";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::MissionPlanner.Properties.Resources.linkquality;
            this.pictureBox2.Location = new System.Drawing.Point(58, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(6, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label_armedstatus
            // 
            this.label_armedstatus.AutoSize = true;
            this.label_armedstatus.Location = new System.Drawing.Point(142, 0);
            this.label_armedstatus.Name = "label_armedstatus";
            this.label_armedstatus.Size = new System.Drawing.Size(34, 12);
            this.label_armedstatus.TabIndex = 5;
            this.label_armedstatus.Text = "armed";
            // 
            // label_yaw
            // 
            this.label_yaw.AutoSize = true;
            this.label_yaw.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_yaw.Location = new System.Drawing.Point(49, 0);
            this.label_yaw.Name = "label_yaw";
            this.label_yaw.Size = new System.Drawing.Size(37, 40);
            this.label_yaw.TabIndex = 4;
            this.label_yaw.Text = "0.0deg";
            // 
            // ConnectionStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ConnectionStatus";
            this.Size = new System.Drawing.Size(193, 139);
            this.Load += new System.EventHandler(this.ConnectionStatus_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label_alt;
        private System.Windows.Forms.Label label_ekf;
        private System.Windows.Forms.Label label_GroundSpeed;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_battery;
        private System.Windows.Forms.Label label_GPS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label_mode;
        private System.Windows.Forms.Label label_PortName;
        private System.Windows.Forms.Label label_linkquality;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_armedstatus;
        private System.Windows.Forms.Label label_yaw;
    }
}
