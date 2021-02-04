namespace prjFinal
{
    partial class frmListHouse
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
            this.gridHouses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchHouse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridHouses)).BeginInit();
            this.SuspendLayout();
            // 
            // gridHouses
            // 
            this.gridHouses.AllowUserToAddRows = false;
            this.gridHouses.AllowUserToDeleteRows = false;
            this.gridHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHouses.Location = new System.Drawing.Point(52, 133);
            this.gridHouses.Name = "gridHouses";
            this.gridHouses.ReadOnly = true;
            this.gridHouses.RowHeadersWidth = 62;
            this.gridHouses.RowTemplate.Height = 28;
            this.gridHouses.Size = new System.Drawing.Size(1052, 443);
            this.gridHouses.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 45;
            this.label1.Text = "List Of Houses";
            // 
            // btnSearchHouse
            // 
            this.btnSearchHouse.Location = new System.Drawing.Point(968, 54);
            this.btnSearchHouse.Name = "btnSearchHouse";
            this.btnSearchHouse.Size = new System.Drawing.Size(126, 51);
            this.btnSearchHouse.TabIndex = 46;
            this.btnSearchHouse.Text = "Search";
            this.btnSearchHouse.UseVisualStyleBackColor = true;
            this.btnSearchHouse.Click += new System.EventHandler(this.btnSearchHouse_Click);
            // 
            // frmListHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 588);
            this.Controls.Add(this.btnSearchHouse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridHouses);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListHouse";
            this.Text = "List of Houses";
            this.Load += new System.EventHandler(this.frmListHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridHouses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridHouses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchHouse;
    }
}