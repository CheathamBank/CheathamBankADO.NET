namespace CheathamBankADO.NET
{
    partial class DeleteJob
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
            this.gvDeleteJobs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeleteJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDeleteJobs
            // 
            this.gvDeleteJobs.AllowUserToAddRows = false;
            this.gvDeleteJobs.AllowUserToDeleteRows = false;
            this.gvDeleteJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDeleteJobs.Location = new System.Drawing.Point(12, 53);
            this.gvDeleteJobs.MultiSelect = false;
            this.gvDeleteJobs.Name = "gvDeleteJobs";
            this.gvDeleteJobs.ReadOnly = true;
            this.gvDeleteJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDeleteJobs.Size = new System.Drawing.Size(275, 83);
            this.gvDeleteJobs.TabIndex = 2;
            this.gvDeleteJobs.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvDeleteJobs_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select a job to delete";
            // 
            // DeleteJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 158);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvDeleteJobs);
            this.Name = "DeleteJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delete Job";
            ((System.ComponentModel.ISupportInitialize)(this.gvDeleteJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gvDeleteJobs;
        private System.Windows.Forms.Label label1;
    }
}