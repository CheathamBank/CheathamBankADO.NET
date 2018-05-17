namespace CheathamBankADO.NET
{
    partial class LoanApplicationSearch
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
            this.components = new System.ComponentModel.Container();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.grpName = new System.Windows.Forms.GroupBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.gvJobHistory = new System.Windows.Forms.DataGridView();
            this.grpJobHistory = new System.Windows.Forms.GroupBox();
            this.jobHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ttAddEditJob = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteJob = new System.Windows.Forms.Button();
            this.grpName.SuspendLayout();
            this.grpAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvJobHistory)).BeginInit();
            this.grpJobHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobHistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(77, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(112, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(193, 20);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 20);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFname
            // 
            this.txtFname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFname.Location = new System.Drawing.Point(21, 37);
            this.txtFname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFname.Name = "txtFname";
            this.txtFname.ReadOnly = true;
            this.txtFname.Size = new System.Drawing.Size(107, 13);
            this.txtFname.TabIndex = 2;
            // 
            // grpName
            // 
            this.grpName.Controls.Add(this.txtLname);
            this.grpName.Controls.Add(this.txtFname);
            this.grpName.Location = new System.Drawing.Point(9, 57);
            this.grpName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpName.Name = "grpName";
            this.grpName.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpName.Size = new System.Drawing.Size(291, 81);
            this.grpName.TabIndex = 3;
            this.grpName.TabStop = false;
            this.grpName.Text = "Applicant Name";
            // 
            // txtLname
            // 
            this.txtLname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLname.Location = new System.Drawing.Point(158, 37);
            this.txtLname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLname.Name = "txtLname";
            this.txtLname.ReadOnly = true;
            this.txtLname.Size = new System.Drawing.Size(107, 13);
            this.txtLname.TabIndex = 3;
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.txtZip);
            this.grpAddress.Controls.Add(this.txtState);
            this.grpAddress.Controls.Add(this.txtCity);
            this.grpAddress.Controls.Add(this.txtStreet);
            this.grpAddress.Location = new System.Drawing.Point(9, 154);
            this.grpAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAddress.Size = new System.Drawing.Size(291, 120);
            this.grpAddress.TabIndex = 4;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address";
            // 
            // txtZip
            // 
            this.txtZip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtZip.Location = new System.Drawing.Point(175, 65);
            this.txtZip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtZip.Name = "txtZip";
            this.txtZip.ReadOnly = true;
            this.txtZip.Size = new System.Drawing.Size(69, 13);
            this.txtZip.TabIndex = 5;
            // 
            // txtState
            // 
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtState.Location = new System.Drawing.Point(132, 65);
            this.txtState.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(37, 13);
            this.txtState.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Location = new System.Drawing.Point(21, 65);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(107, 13);
            this.txtCity.TabIndex = 3;
            // 
            // txtStreet
            // 
            this.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStreet.Location = new System.Drawing.Point(21, 36);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.Size = new System.Drawing.Size(244, 13);
            this.txtStreet.TabIndex = 2;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(402, 248);
            this.btnModify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(69, 27);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "Edit";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // gvJobHistory
            // 
            this.gvJobHistory.AllowUserToDeleteRows = false;
            this.gvJobHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvJobHistory.Location = new System.Drawing.Point(21, 27);
            this.gvJobHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gvJobHistory.MultiSelect = false;
            this.gvJobHistory.Name = "gvJobHistory";
            this.gvJobHistory.ReadOnly = true;
            this.gvJobHistory.RowTemplate.Height = 24;
            this.gvJobHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvJobHistory.Size = new System.Drawing.Size(441, 182);
            this.gvJobHistory.TabIndex = 6;
            this.gvJobHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvJobHistory_CellClick);
            // 
            // grpJobHistory
            // 
            this.grpJobHistory.Controls.Add(this.btnDeleteJob);
            this.grpJobHistory.Controls.Add(this.label1);
            this.grpJobHistory.Controls.Add(this.gvJobHistory);
            this.grpJobHistory.Location = new System.Drawing.Point(9, 327);
            this.grpJobHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpJobHistory.Name = "grpJobHistory";
            this.grpJobHistory.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpJobHistory.Size = new System.Drawing.Size(482, 280);
            this.grpJobHistory.TabIndex = 7;
            this.grpJobHistory.TabStop = false;
            this.grpJobHistory.Text = "Job History";
            this.grpJobHistory.Enter += new System.EventHandler(this.grpJobHistory_Enter);
            // 
            // ttAddEditJob
            // 
            this.ttAddEditJob.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttAddEditJob.ToolTipTitle = "How to add and edit a job";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "(?)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttAddEditJob.SetToolTip(this.label1, "Select a job to edit.\r\nSelect an empty row to add a new job.");
            // 
            // btnDeleteJob
            // 
            this.btnDeleteJob.Location = new System.Drawing.Point(393, 226);
            this.btnDeleteJob.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteJob.Name = "btnDeleteJob";
            this.btnDeleteJob.Size = new System.Drawing.Size(69, 27);
            this.btnDeleteJob.TabIndex = 8;
            this.btnDeleteJob.Text = "Delete Job";
            this.btnDeleteJob.UseVisualStyleBackColor = true;
            this.btnDeleteJob.Click += new System.EventHandler(this.btnDeleteJob_Click);
            // 
            // LoanApplicationSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 617);
            this.Controls.Add(this.grpJobHistory);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.grpAddress);
            this.Controls.Add(this.grpName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoanApplicationSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search -:|:- CB";
            this.grpName.ResumeLayout(false);
            this.grpName.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvJobHistory)).EndInit();
            this.grpJobHistory.ResumeLayout(false);
            this.grpJobHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobHistoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.GroupBox grpName;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Button btnModify;
       // private LoansDataSet loansDataSet;
        private System.Windows.Forms.BindingSource jobHistoryBindingSource;
        private System.Windows.Forms.DataGridView gvJobHistory;
        private System.Windows.Forms.GroupBox grpJobHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ttAddEditJob;
        private System.Windows.Forms.Button btnDeleteJob;
        //  private LoansDataSetTableAdapters.JobHistoryTableAdapter jobHistoryTableAdapter;
    }
}