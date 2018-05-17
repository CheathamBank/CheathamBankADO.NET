using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheathamBankADO.NET
{
    public partial class DeleteJob : Form
    {
        public DeleteJob()
        {
            InitializeComponent();
        }

        private Job deleteJob = new Job();
        public DataTable dtJobs;

        public void loadJobs()
        {
            gvDeleteJobs.DataSource = dtJobs;

            if (gvDeleteJobs.Columns.Count > 0)
            {
                gvDeleteJobs.Columns[0].Visible = false;
                gvDeleteJobs.Columns[1].Visible = false;
                gvDeleteJobs.Columns[3].Visible = false;
                gvDeleteJobs.Columns[5].Visible = false;
            }

        }

        private void gvDeleteJobs_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex; //Get row index


            if (index >= 0)// Checks if user clicked on top left box
            {
                DataGridViewRow selectedRowToDelete = gvDeleteJobs.Rows[index];
                deleteJob.JobID = Convert.ToInt32(selectedRowToDelete.Cells[1].Value);

                if (MessageBox.Show("Are you sure you want to delete this job?", "Confirm", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    if (ApplicantDB.DeleteJob(deleteJob))
                    {
                        MessageBox.Show("Job deleted", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Job could not be deleted", "Error");
                    }
                    this.Close();
                }
            }

        }
    }
}
