namespace prjFinal
{
    partial class frmMenuAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuRemax = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAgents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClients = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHouses = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAgent = new System.Windows.Forms.ToolStripMenuItem();
            this.searchClient = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchHouse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRemax});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuRemax
            // 
            this.mnuRemax.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdmin,
            this.searchAdmin,
            this.mnuQuit});
            this.mnuRemax.Name = "mnuRemax";
            this.mnuRemax.Size = new System.Drawing.Size(80, 29);
            this.mnuRemax.Text = "Remax";
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAgents,
            this.mnuClients,
            this.mnuHouses});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(270, 34);
            this.mnuAdmin.Text = "Admin";
            // 
            // mnuAgents
            // 
            this.mnuAgents.Name = "mnuAgents";
            this.mnuAgents.Size = new System.Drawing.Size(270, 34);
            this.mnuAgents.Text = "Agents";
            this.mnuAgents.Click += new System.EventHandler(this.mnuAgents_Click);
            // 
            // mnuClients
            // 
            this.mnuClients.Name = "mnuClients";
            this.mnuClients.Size = new System.Drawing.Size(270, 34);
            this.mnuClients.Text = "Clients";
            this.mnuClients.Click += new System.EventHandler(this.mnuClients_Click);
            // 
            // mnuHouses
            // 
            this.mnuHouses.Name = "mnuHouses";
            this.mnuHouses.Size = new System.Drawing.Size(270, 34);
            this.mnuHouses.Text = "Houses";
            this.mnuHouses.Click += new System.EventHandler(this.mnuHouses_Click);
            // 
            // mnuQuit
            // 
            this.mnuQuit.Name = "mnuQuit";
            this.mnuQuit.Size = new System.Drawing.Size(270, 34);
            this.mnuQuit.Text = "Quit   Alt+X";
            this.mnuQuit.Click += new System.EventHandler(this.mnuQuit_Click);
            // 
            // searchAdmin
            // 
            this.searchAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchAgent,
            this.searchClient,
            this.SearchHouse});
            this.searchAdmin.Name = "searchAdmin";
            this.searchAdmin.Size = new System.Drawing.Size(270, 34);
            this.searchAdmin.Text = "Search";
            // 
            // searchAgent
            // 
            this.searchAgent.Name = "searchAgent";
            this.searchAgent.Size = new System.Drawing.Size(270, 34);
            this.searchAgent.Text = "Agent";
            this.searchAgent.Click += new System.EventHandler(this.searchAgent_Click);
            // 
            // searchClient
            // 
            this.searchClient.Name = "searchClient";
            this.searchClient.Size = new System.Drawing.Size(270, 34);
            this.searchClient.Text = "Client";
            this.searchClient.Click += new System.EventHandler(this.searchClient_Click);
            // 
            // SearchHouse
            // 
            this.SearchHouse.Name = "SearchHouse";
            this.SearchHouse.Size = new System.Drawing.Size(270, 34);
            this.SearchHouse.Text = "House";
            this.SearchHouse.Click += new System.EventHandler(this.SearchHouse_Click);
            // 
            // frmMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuAdmin";
            this.Text = "frmMenuAdmin";
            this.Load += new System.EventHandler(this.frmMenuAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuRemax;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuAgents;
        private System.Windows.Forms.ToolStripMenuItem mnuClients;
        private System.Windows.Forms.ToolStripMenuItem mnuHouses;
        private System.Windows.Forms.ToolStripMenuItem mnuQuit;
        private System.Windows.Forms.ToolStripMenuItem searchAdmin;
        private System.Windows.Forms.ToolStripMenuItem searchAgent;
        private System.Windows.Forms.ToolStripMenuItem searchClient;
        private System.Windows.Forms.ToolStripMenuItem SearchHouse;
    }
}