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
    public partial class LoanApplicationSearch : Form
    {
        private bool hasSearched = false;
        private DataTable dt;
        private string currentApplicant;

        public LoanApplicationSearch()
        {
            InitializeComponent();
        }

        private Applicant application;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.GetApplication(txtSearch.Text);            
            if (application == null)
            {
                MessageBox.Show("No application found with this ID.", "No product found");
                this.ClearAll();
                hasSearched = false;
            }
            else
            {
                this.DisplayApplication();
                hasSearched = true;
            }
            this.GetApplicantJobHistory(txtSearch.Text);


        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //Load all textboxes into array
            int txtBoxCount = 6;
            TextBox[] txtBoxes = new TextBox[txtBoxCount];
            txtBoxes[0] = txtFname;
            txtBoxes[1] = txtLname;
            txtBoxes[2] = txtStreet;
            txtBoxes[3] = txtCity;
            txtBoxes[4] = txtState;
            txtBoxes[5] = txtZip;

            if (hasSearched)
            {
                if (btnModify.Text == "Edit")
                {
                    for (int i = 0; i < txtBoxes.Length; i++)
                    {
                        txtBoxes[i].ReadOnly = false;
                    }

                    btnModify.Text = "Save";
                }
                else
                {
                    btnModify.Text = "Edit";
                    for (int i = 0; i < txtBoxes.Length; i++)
                    {
                        txtBoxes[i].ReadOnly = true;
                    }

                    this.UpdateApplicant(txtSearch.Text);


                }
            }
            else
            {
                MessageBox.Show("Please search for an applicant first.");
            }    
        }

        private void btnModifyJobHist_Click(object sender, EventArgs e)
        {
            if (gvJobHistory.SelectedRows.Count == 0 || gvJobHistory.SelectedRows.Count > 1)
            {
                MessageBox.Show("You must select a job to perform this action");
            }
            else
            {

                


            }

        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            addModifyJob newJob = new addModifyJob();

        }

        private void GetApplication (string CustID)
        {
            try
            {
                application = ApplicantDB.GetApplication(CustID);
                
                if (application != null)
                {
                    currentApplicant = application.CustID;
                }


            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void GetApplicantJobHistory (string CustID)
        {
            dt = ApplicantDB.GetApplicantJobHistory(CustID);

            gvJobHistory.DataSource = dt;

            if (gvJobHistory.Columns.Count > 0)// Count will be > 0 if no applicant / job found.
            {
                gvJobHistory.Columns[0].Visible = false;
                gvJobHistory.Columns[1].Visible = false;
            }



            
        }

        private void UpdateApplicant (string CustID)
        {
            Applicant newApplicant = new Applicant();

            this.PutApplicantData(newApplicant);

            try
            {
                if (ApplicantDB.UpdateApplicant(application, newApplicant))
                {
                    MessageBox.Show("Applicant Saved");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void PutApplicantData(Applicant applicant)
        {
            applicant.CustID = txtSearch.Text;
            applicant.FirstName = txtFname.Text;
            applicant.LastName = txtLname.Text;
            applicant.Street = txtStreet.Text;
            applicant.City = txtCity.Text;
            applicant.State = txtState.Text;
            applicant.Zip = Int32.Parse(txtZip.Text);

            //Fill Data Table

        }

        private void DisplayApplication()
        {
            txtFname.Text = application.FirstName;
            txtLname.Text = application.LastName;
            txtStreet.Text = application.Street;
            txtCity.Text = application.City;
            txtState.Text = application.State;
            txtZip.Text = application.Zip.ToString();
        }



        private void ClearAll()
        {
            txtSearch.Clear();
            txtFname.Clear();
            txtLname.Clear();
            txtStreet.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtZip.Clear();
        }

        private void gvJobHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex; //Get row index
            Job modifyJob = new Job();

            if (index >= 0)// Checks if user clicked on top left box
            {
                DataGridViewRow selectedRow = gvJobHistory.Rows[index];


                if (!DBNull.Value.Equals(selectedRow.Cells[0].Value))// If custID DBnulls, then an empty row was selected... create new job
                {
                    modifyJob.CustID = Convert.ToInt32(selectedRow.Cells[0].Value);
                    modifyJob.JobID = Convert.ToInt32(selectedRow.Cells[1].Value);
                    modifyJob.Job_Title = selectedRow.Cells[2].Value.ToString();
                    modifyJob.Start_Date = Convert.ToDateTime(selectedRow.Cells[3].Value);
                    modifyJob.End_Date = Convert.ToDateTime(selectedRow.Cells[4].Value);
                    modifyJob.Salary = Convert.ToInt32(selectedRow.Cells[5].Value);
                }
                else
                {
                    modifyJob.CustID = Convert.ToInt32(currentApplicant);
                }
                addModifyJob modifyJobForm = new addModifyJob();
                modifyJobForm.job = modifyJob;
                modifyJobForm.initializeForm();
                modifyJobForm.Show();
            }
            
        }

        private void grpJobHistory_Enter(object sender, EventArgs e)
        {

        }

        private void btnDeleteJob_Click(object sender, EventArgs e)
        {
            DeleteJob deleteJobForm = new DeleteJob();
            deleteJobForm.dtJobs = dt;
            deleteJobForm.loadJobs();

            deleteJobForm.Show();
        }
    }
}
