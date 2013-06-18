namespace VirtualAP
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lSSID = new System.Windows.Forms.Label();
            this.txtSSID = new System.Windows.Forms.TextBox();
            this.lPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnStartAP = new System.Windows.Forms.Button();
            this.btnStopAP = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lInfo = new System.Windows.Forms.Label();
            this.lVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lSSID
            // 
            this.lSSID.AutoSize = true;
            this.lSSID.Location = new System.Drawing.Point(51, 29);
            this.lSSID.Name = "lSSID";
            this.lSSID.Size = new System.Drawing.Size(144, 13);
            this.lSSID.TabIndex = 0;
            this.lSSID.Text = "SSID (Wifi name)/热点名称:";
            // 
            // txtSSID
            // 
            this.txtSSID.Location = new System.Drawing.Point(201, 26);
            this.txtSSID.Name = "txtSSID";
            this.txtSSID.Size = new System.Drawing.Size(131, 20);
            this.txtSSID.TabIndex = 1;
            this.txtSSID.Text = "PC-WIFI";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(51, 60);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(85, 13);
            this.lPassword.TabIndex = 2;
            this.lPassword.Text = "Password/密码:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(201, 57);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(131, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "password";
            // 
            // btnStartAP
            // 
            this.btnStartAP.Location = new System.Drawing.Point(80, 101);
            this.btnStartAP.Name = "btnStartAP";
            this.btnStartAP.Size = new System.Drawing.Size(112, 23);
            this.btnStartAP.TabIndex = 4;
            this.btnStartAP.Text = "Start AP/启动热点";
            this.btnStartAP.UseVisualStyleBackColor = true;
            this.btnStartAP.Click += new System.EventHandler(this.btnStartAP_Click);
            // 
            // btnStopAP
            // 
            this.btnStopAP.Location = new System.Drawing.Point(197, 101);
            this.btnStopAP.Name = "btnStopAP";
            this.btnStopAP.Size = new System.Drawing.Size(111, 23);
            this.btnStopAP.TabIndex = 5;
            this.btnStopAP.Text = "Stop AP/停止热点";
            this.btnStopAP.UseVisualStyleBackColor = true;
            this.btnStopAP.Click += new System.EventHandler(this.btnStopAP_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 149);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(358, 167);
            this.txtOutput.TabIndex = 6;
            // 
            // lInfo
            // 
            this.lInfo.AutoSize = true;
            this.lInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lInfo.Location = new System.Drawing.Point(12, 319);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(67, 13);
            this.lInfo.TabIndex = 7;
            this.lInfo.Text = "By JIN Weijie";
            // 
            // lVersion
            // 
            this.lVersion.AutoSize = true;
            this.lVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lVersion.Location = new System.Drawing.Point(80, 319);
            this.lVersion.Name = "lVersion";
            this.lVersion.Size = new System.Drawing.Size(0, 13);
            this.lVersion.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 338);
            this.Controls.Add(this.lVersion);
            this.Controls.Add(this.lInfo);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnStopAP);
            this.Controls.Add(this.btnStartAP);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.txtSSID);
            this.Controls.Add(this.lSSID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Virtual Access Point/虚拟热点管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lSSID;
        private System.Windows.Forms.TextBox txtSSID;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnStartAP;
        private System.Windows.Forms.Button btnStopAP;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lInfo;
        private System.Windows.Forms.Label lVersion;
    }
}

