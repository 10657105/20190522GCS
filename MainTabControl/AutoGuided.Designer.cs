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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoGuided));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Reset_Connection_Button = new MissionPlanner.Controls.MyButton();
            this.SetAll = new MissionPlanner.Controls.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Armed_and_Takeoff_All
            // 
            resources.ApplyResources(this.Armed_and_Takeoff_All, "Armed_and_Takeoff_All");
            this.Armed_and_Takeoff_All.Name = "Armed_and_Takeoff_All";
            this.Armed_and_Takeoff_All.UseVisualStyleBackColor = true;
            this.Armed_and_Takeoff_All.Click += new System.EventHandler(this.Armed_and_Takeoff_All_Click);
            // 
            // Button_start
            // 
            resources.ApplyResources(this.Button_start, "Button_start");
            this.Button_start.Name = "Button_start";
            this.Button_start.UseVisualStyleBackColor = true;
            this.Button_start.Click += new System.EventHandler(this.Button_start_Click);
            // 
            // SetA
            // 
            resources.ApplyResources(this.SetA, "SetA");
            this.SetA.Name = "SetA";
            this.SetA.UseVisualStyleBackColor = true;
            this.SetA.Click += new System.EventHandler(this.SetA_Click);
            // 
            // SetB
            // 
            resources.ApplyResources(this.SetB, "SetB");
            this.SetB.Name = "SetB";
            this.SetB.UseVisualStyleBackColor = true;
            this.SetB.Click += new System.EventHandler(this.SetB_Click);
            // 
            // SetC
            // 
            resources.ApplyResources(this.SetC, "SetC");
            this.SetC.Name = "SetC";
            this.SetC.UseVisualStyleBackColor = true;
            this.SetC.Click += new System.EventHandler(this.SetC_Click);
            // 
            // SetD
            // 
            resources.ApplyResources(this.SetD, "SetD");
            this.SetD.Name = "SetD";
            this.SetD.UseVisualStyleBackColor = true;
            this.SetD.Click += new System.EventHandler(this.SetD_Click);
            // 
            // SetE
            // 
            resources.ApplyResources(this.SetE, "SetE");
            this.SetE.Name = "SetE";
            this.SetE.UseVisualStyleBackColor = true;
            this.SetE.Click += new System.EventHandler(this.SetE_Click);
            // 
            // Connection_Select
            // 
            this.Connection_Select.FormattingEnabled = true;
            resources.ApplyResources(this.Connection_Select, "Connection_Select");
            this.Connection_Select.Name = "Connection_Select";
            this.Connection_Select.Click += new System.EventHandler(this.Connection_Select_Click);
            // 
            // LBL_ACopter
            // 
            resources.ApplyResources(this.LBL_ACopter, "LBL_ACopter");
            this.LBL_ACopter.Name = "LBL_ACopter";
            // 
            // LBL_BCopter
            // 
            resources.ApplyResources(this.LBL_BCopter, "LBL_BCopter");
            this.LBL_BCopter.Name = "LBL_BCopter";
            // 
            // LBL_CCopter
            // 
            resources.ApplyResources(this.LBL_CCopter, "LBL_CCopter");
            this.LBL_CCopter.Name = "LBL_CCopter";
            // 
            // LBL_DCopter
            // 
            resources.ApplyResources(this.LBL_DCopter, "LBL_DCopter");
            this.LBL_DCopter.Name = "LBL_DCopter";
            // 
            // LBL_ECopter
            // 
            resources.ApplyResources(this.LBL_ECopter, "LBL_ECopter");
            this.LBL_ECopter.Name = "LBL_ECopter";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LBL_ACopter);
            this.panel1.Controls.Add(this.LBL_ECopter);
            this.panel1.Controls.Add(this.LBL_BCopter);
            this.panel1.Controls.Add(this.LBL_DCopter);
            this.panel1.Controls.Add(this.LBL_CCopter);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // Reset_Connection_Button
            // 
            resources.ApplyResources(this.Reset_Connection_Button, "Reset_Connection_Button");
            this.Reset_Connection_Button.Name = "Reset_Connection_Button";
            this.Reset_Connection_Button.UseVisualStyleBackColor = true;
            this.Reset_Connection_Button.Click += new System.EventHandler(this.Reset_Connection_Button_Click);
            // 
            // SetAll
            // 
            resources.ApplyResources(this.SetAll, "SetAll");
            this.SetAll.Name = "SetAll";
            this.SetAll.UseVisualStyleBackColor = true;
            this.SetAll.Click += new System.EventHandler(this.SetAll_Click);
            // 
            // AutoGuided
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Reset_Connection_Button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Connection_Select);
            this.Controls.Add(this.SetE);
            this.Controls.Add(this.SetD);
            this.Controls.Add(this.SetC);
            this.Controls.Add(this.SetB);
            this.Controls.Add(this.SetAll);
            this.Controls.Add(this.SetA);
            this.Controls.Add(this.Button_start);
            this.Controls.Add(this.Armed_and_Takeoff_All);
            this.Name = "AutoGuided";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private Controls.MyButton Reset_Connection_Button;
        private Controls.MyButton SetAll;
    }
}
