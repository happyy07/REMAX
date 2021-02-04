namespace prjFinal
{
    partial class searchAgent
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
            this.txtAgentId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchAgent = new System.Windows.Forms.Button();
            this.gridAgents = new System.Windows.Forms.DataGridView();
            this.lblSearchMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAgents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 37);
            this.label1.TabIndex = 69;
            this.label1.Text = "Search Agent";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAgentId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSearchAgent);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(50, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 241);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Agent:";
            // 
            // txtAgentId
            // 
            this.txtAgentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgentId.Location = new System.Drawing.Point(145, 64);
            this.txtAgentId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAgentId.Name = "txtAgentId";
            this.txtAgentId.Size = new System.Drawing.Size(141, 28);
            this.txtAgentId.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Agent Id : ";
            // 
            // btnSearchAgent
            // 
            this.btnSearchAgent.Location = new System.Drawing.Point(27, 129);
            this.btnSearchAgent.Name = "btnSearchAgent";
            this.btnSearchAgent.Size = new System.Drawing.Size(126, 51);
            this.btnSearchAgent.TabIndex = 3;
            this.btnSearchAgent.Text = "Search";
            this.btnSearchAgent.UseVisualStyleBackColor = true;
            this.btnSearchAgent.Click += new System.EventHandler(this.btnSearchAgent_Click);
            // 
            // gridAgents
            // 
            this.gridAgents.AllowUserToAddRows = false;
            this.gridAgents.AllowUserToDeleteRows = false;
            this.gridAgents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAgents.Location = new System.Drawing.Point(407, 111);
            this.gridAgents.Name = "gridAgents";
            this.gridAgents.ReadOnly = true;
            this.gridAgents.RowHeadersWidth = 62;
            this.gridAgents.RowTemplate.Height = 28;
            this.gridAgents.Size = new System.Drawing.Size(724, 408);
            this.gridAgents.TabIndex = 74;
            this.gridAgents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHouses_CellContentClick);
            // 
            // lblSearchMessage
            // 
            this.lblSearchMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSearchMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchMessage.Location = new System.Drawing.Point(407, 35);
            this.lblSearchMessage.Name = "lblSearchMessage";
            this.lblSearchMessage.Size = new System.Drawing.Size(631, 44);
            this.lblSearchMessage.TabIndex = 75;
            this.lblSearchMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 566);
            this.Controls.Add(this.lblSearchMessage);
            this.Controls.Add(this.gridAgents);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "searchAgent";
            this.Text = "search";
            this.Load += new System.EventHandler(this.searchAgent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAgents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchAgent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAgentId;
        private System.Windows.Forms.DataGridView gridAgents;
        private System.Windows.Forms.Label lblSearchMessage;
    }
}