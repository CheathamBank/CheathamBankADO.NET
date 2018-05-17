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
    public partial class addModifyJob : Form
    {

        public addModifyJob()
        {
            InitializeComponent();


            
        }
        public Applicant applicant;
        public Job job;
        private string suffix = "-:|:- CB";

        public void initializeForm() //Custom form initialization before displaying
        {
                if (job.Job_Title != null) //if Title is not NULL, then user is modifying an existing job
                { 
                txtJobTitle.Text = job.Job_Title.ToString();
                dtpStartDate.Value = job.Start_Date;
                dtpEndDate.Value = job.End_Date;
                txtSalary.Text = job.Salary.ToString();
                this.Text = "Modify Job " + suffix;
                }
                else //User is adding a new Job
                {
                this.Text = "Create New Job " + suffix;

          
                }


        }

        private void ckCurrentlyEmployed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.Text == "Modify Job " + suffix) //Update existing job
            {
                Job newJob = new Job();

                newJob.Job_Title = txtJobTitle.Text;
                newJob.Start_Date = dtpStartDate.Value;
                newJob.End_Date = dtpEndDate.Value;
                newJob.Salary = Convert.ToDecimal(txtSalary.Text);

                if (ApplicantDB.UpdateJob(job, newJob))
                {
                    MessageBox.Show("Updated job.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The job could not be updated.");
                }
            }
            else if (this.Text == "Create New Job " + suffix)
            {
                Job newJob = new Job();
                Random rnd = new Random();

                newJob.JobID = rnd.Next(20, 10000);
                newJob.CustID = job.CustID;
                newJob.Job_Title = txtJobTitle.Text;
                newJob.Start_Date = dtpStartDate.Value;
                newJob.End_Date = dtpEndDate.Value;
                newJob.Salary = Convert.ToDecimal(txtSalary.Text);

                if (ApplicantDB.InsertNewJob(newJob))
                {
                    MessageBox.Show("Job added.", "Success");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Job could not be added", "Error");

                }
            }
        }
    }
}
