namespace prjFinal
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnNextMain = new System.Windows.Forms.Button();
            this.radioClient = new System.Windows.Forms.RadioButton();
            this.radioAgent = new System.Windows.Forms.RadioButton();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome to Remax ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuit);
            this.groupBox1.Controls.Add(this.btnNextMain);
            this.groupBox1.Controls.Add(this.radioClient);
            this.groupBox1.Controls.Add(this.radioAgent);
            this.groupBox1.Controls.Add(this.radioAdmin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(302, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 325);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login as:";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(237, 225);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(173, 51);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit   Alt+X";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnNextMain
            // 
            this.btnNextMain.Location = new System.Drawing.Point(27, 225);
            this.btnNextMain.Name = "btnNextMain";
            this.btnNextMain.Size = new System.Drawing.Size(173, 51);
            this.btnNextMain.TabIndex = 3;
            this.btnNextMain.Text = "Next please..";
            this.btnNextMain.UseVisualStyleBackColor = true;
            this.btnNextMain.Click += new System.EventHandler(this.btnNextMain_Click);
            // 
            // radioClient
            // 
            this.radioClient.AutoSize = true;
            this.radioClient.Location = new System.Drawing.Point(27, 155);
            this.radioClient.Name = "radioClient";
            this.radioClient.Size = new System.Drawing.Size(87, 26);
            this.radioClient.TabIndex = 2;
            this.radioClient.TabStop = true;
            this.radioClient.Text = "Client";
            this.radioClient.UseVisualStyleBackColor = true;
            // 
            // radioAgent
            // 
            this.radioAgent.AutoSize = true;
            this.radioAgent.Location = new System.Drawing.Point(27, 102);
            this.radioAgent.Name = "radioAgent";
            this.radioAgent.Size = new System.Drawing.Size(87, 26);
            this.radioAgent.TabIndex = 1;
            this.radioAgent.TabStop = true;
            this.radioAgent.Text = "Agent";
            this.radioAgent.UseVisualStyleBackColor = true;
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Location = new System.Drawing.Point(27, 49);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(90, 26);
            this.radioAdmin.TabIndex = 0;
            this.radioAdmin.TabStop = true;
            this.radioAdmin.Text = "Admin";
            this.radioAdmin.UseVisualStyleBackColor = true;
            this.radioAdmin.CheckedChanged += new System.EventHandler(this.radioAdmin_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNextMain;
        private System.Windows.Forms.RadioButton radioClient;
        private System.Windows.Forms.RadioButton radioAgent;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.Button btnQuit;
    }
}