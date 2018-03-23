namespace MissionPlanner.MainTabControl
{
    partial class AutoGuided
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
            this.components = new System.ComponentModel.Container();
            this.Armed_and_Takeoff_All = new MissionPlanner.Controls.MyButton();
            this.Button_start = new MissionPlanner.Controls.MyButton();
            this.SetA = new MissionPlanner.Controls.MyButton();
            this.SetB = new MissionPlanner.Controls.MyButton();
            this.SetC = new MissionPlanner.Controls.MyButton();
            this.SetD = new MissionPlanner.Controls.MyButton();
            this.SetE = new MissionPlanner.Controls.MyButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Connection_Select = new System.Windows.Forms.ComboBox();
            this.LBL_ACopter = new System.Windows.Forms.Label();
            this.LBL_BCopter = new System.Windows.Forms.Label();
            this.LBL_CCopter = new System.Windows.Forms.Label();
            this.LBL_DCopter = new System.Windows.Forms.Label();
            this.LBL_ECopter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Armed_and_Takeoff_All
            // 
            this.Armed_and_Takeoff_All.Font = new System.Drawing.Font("Arial", 9F);
            this.Armed_and_Takeoff_All.Location = new System.Drawing.Point(16, 29);
            this.Armed_and_Takeoff_All.Name = "Armed_and_Takeoff_All";
            this.Armed_and_Takeoff_All.Size = new System.Drawing.Size(75, 29);
            this.Armed_and_Takeoff_All.TabIndex = 9;
            this.Armed_and_Takeoff_All.Text = "Armed and Takeoff All";
            this.Armed_and_Takeoff_All.UseVisualStyleBackColor = true;
            this.Armed_and_Takeoff_All.Click += new System.EventHandler(this.Armed_and_Takeoff_All_Click);
            // 
            // Button_start
            // 
            this.Button_start.Font = new System.Drawing.Font("Arial", 9F);
            this.Button_start.Location = new System.Drawing.Point(16, 64);
            this.Button_start.Name = "Button_start";
            this.Button_start.Size = new System.Drawing.Size(75, 23);
            this.Button_start.TabIndex = 10;
            this.Button_start.Text = "Start";
            this.Button_start.UseVisualStyleBackColor = true;
            this.Button_start.Click += new System.EventHandler(this.Button_start_Click);
            // 
            // SetA
            // 
            this.SetA.Font = new System.Drawing.Font("Arial", 9F);
            this.SetA.Location = new System.Drawing.Point(16, 136);
            this.SetA.Name = "SetA";
            this.SetA.Size = new System.Drawing.Size(75, 23);
            this.SetA.TabIndex = 11;
            this.SetA.Text = "Set to A";
            this.SetA.UseVisualStyleBackColor = true;
            this.SetA.Click += new System.EventHandler(this.SetA_Click);
            // 
            // SetB
            // 
            this.SetB.Font = new System.Drawing.Font("Arial", 9F);
            this.SetB.Location = new System.Drawing.Point(16, 165);
            this.SetB.Name = "SetB";
            this.SetB.Size = new System.Drawing.Size(75, 23);
            this.SetB.TabIndex = 12;
            this.SetB.Text = "Set to B";
            this.SetB.UseVisualStyleBackColor = true;
            this.SetB.Click += new System.EventHandler(this.SetB_Click);
            // 
            // SetC
            // 
            this.SetC.Font = new System.Drawing.Font("Arial", 9F);
            this.SetC.Location = new System.Drawing.Point(16, 194);
            this.SetC.Name = "SetC";
            this.SetC.Size = new System.Drawing.Size(75, 23);
            this.SetC.TabIndex = 13;
            this.SetC.Text = "Set to C";
            this.SetC.UseVisualStyleBackColor = true;
            this.SetC.Click += new System.EventHandler(this.SetC_Click);
            // 
            // SetD
            // 
            this.SetD.Font = new System.Drawing.Font("Arial", 9F);
            this.SetD.Location = new System.Drawing.Point(16, 224);
            this.SetD.Name = "SetD";
            this.SetD.Size = new System.Drawing.Size(75, 23);
            this.SetD.TabIndex = 14;
            this.SetD.Text = "Set to D";
            this.SetD.UseVisualStyleBackColor = true;
            this.SetD.Click += new System.EventHandler(this.SetD_Click);
            // 
            // SetE
            // 
            this.SetE.Font = new System.Drawing.Font("Arial", 9F);
            this.SetE.Location = new System.Drawing.Point(16, 255);
            this.SetE.Name = "SetE";
            this.SetE.Size = new System.Drawing.Size(75, 23);
            this.SetE.TabIndex = 15;
            this.SetE.Text = "Set to E";
            this.SetE.UseVisualStyleBackColor = true;
            this.SetE.Click += new System.EventHandler(this.SetE_Click);
            // 
            // Connection_Select
            // 
            this.Connection_Select.FormattingEnabled = true;
            this.Connection_Select.Location = new System.Drawing.Point(16, 110);
            this.Connection_Select.Name = "Connection_Select";
            this.Connection_Select.Size = new System.Drawing.Size(121, 20);
            this.Connection_Select.TabIndex = 16;
            this.Connection_Select.Click += new System.EventHandler(this.Connection_Select_Click);
            // 
            // LBL_ACopter
            // 
            this.LBL_ACopter.AutoSize = true;
            this.LBL_ACopter.Font = new System.Drawing.Font("Arial", 9F);
            this.LBL_ACopter.Location = new System.Drawing.Point(13, 292);
            this.LBL_ACopter.Name = "LBL_ACopter";
            this.LBL_ACopter.Size = new System.Drawing.Size(51, 15);
            this.LBL_ACopter.TabIndex = 17;
            this.LBL_ACopter.Text = "ACopter";
            // 
            // LBL_BCopter
            // 
            this.LBL_BCopter.AutoSize = true;
            this.LBL_BCopter.Font = new System.Drawing.Font("Arial", 9F);
            this.LBL_BCopter.Location = new System.Drawing.Point(12, 307);
            this.LBL_BCopter.Name = "LBL_BCopter";
            this.LBL_BCopter.Size = new System.Drawing.Size(52, 15);
            this.LBL_BCopter.TabIndex = 17;
            this.LBL_BCopter.Text = "BCopter";
            // 
            // LBL_CCopter
            // 
            this.LBL_CCopter.AutoSize = true;
            this.LBL_CCopter.Font = new System.Drawing.Font("Arial", 9F);
            this.LBL_CCopter.Location = new System.Drawing.Point(11, 322);
            this.LBL_CCopter.Name = "LBL_CCopter";
            this.LBL_CCopter.Size = new System.Drawing.Size(53, 15);
            this.LBL_CCopter.TabIndex = 17;
            this.LBL_CCopter.Text = "CCopter";
            // 
            // LBL_DCopter
            // 
            this.LBL_DCopter.AutoSize = true;
            this.LBL_DCopter.Font = new System.Drawing.Font("Arial", 9F);
            this.LBL_DCopter.Location = new System.Drawing.Point(11, 337);
            this.LBL_DCopter.Name = "LBL_DCopter";
            this.LBL_DCopter.Size = new System.Drawing.Size(53, 15);
            this.LBL_DCopter.TabIndex = 17;
            this.LBL_DCopter.Text = "DCopter";
            // 
            // LBL_ECopter
            // 
            this.LBL_ECopter.AutoSize = true;
            this.LBL_ECopter.Font = new System.Drawing.Font("Arial", 9F);
            this.LBL_ECopter.Location = new System.Drawing.Point(12, 352);
            this.LBL_ECopter.Name = "LBL_ECopter";
            this.LBL_ECopter.Size = new System.Drawing.Size(52, 15);
            this.LBL_ECopter.TabIndex = 17;
            this.LBL_ECopter.Text = "ECopter";
            // 
            // AutoGuided
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LBL_ECopter);
            this.Controls.Add(this.LBL_DCopter);
            this.Controls.Add(this.LBL_CCopter);
            this.Controls.Add(this.LBL_BCopter);
            this.Controls.Add(this.LBL_ACopter);
            this.Controls.Add(this.Connection_Select);
            this.Controls.Add(this.SetE);
            this.Controls.Add(this.SetD);
            this.Controls.Add(this.SetC);
            this.Controls.Add(this.SetB);
            this.Controls.Add(this.SetA);
            this.Controls.Add(this.Button_start);
            this.Controls.Add(this.Armed_and_Takeoff_All);
            this.Name = "AutoGuided";
            this.Size = new System.Drawing.Size(243, 398);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MyButton Armed_and_Takeoff_All;
        private Controls.MyButton Button_start;
        private Controls.MyButton SetA;
        private Controls.MyButton SetB;
        private Controls.MyButton SetC;
        private Controls.MyButton SetD;
        private Controls.MyButton SetE;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox Connection_Select;
        private System.Windows.Forms.Label LBL_ACopter;
        private System.Windows.Forms.Label LBL_BCopter;
        private System.Windows.Forms.Label LBL_CCopter;
        private System.Windows.Forms.Label LBL_DCopter;
        private System.Windows.Forms.Label LBL_ECopter;
    }
}
