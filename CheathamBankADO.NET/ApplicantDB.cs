using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CheathamBankADO.NET
{
    public class ApplicantDB
    {

        public static Applicant GetApplication(string primaryKey)
        {
            //establish new connection by
            //accessing connection string in LoansDB

            SqlConnection c = LoansDB.GetConnection();

            //Build SQL statement
            string selectStatement = "SELECT CustID, CustFirstName, CustLastName, CustStreet, CustCity, CustState, CustZip "
                + "FROM LoanApplicant "
                + "WHERE CustID = @CustID ";

            //Put statment and connection string in to SQLCommand obj

            SqlCommand selectCommand = new SqlCommand(selectStatement, c);

            //replaces parameter in statement with passed PK look-up value
            selectCommand.Parameters.AddWithValue("@CustID", primaryKey);

            try
            {
                //Open connection and instantiate SQL reader
                //Describe query results as SingleRow
                c.Open();
                SqlDataReader applicationReader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);

                //.Read() advances reader to the next record. 
                if (applicationReader.Read())
                {
                    //instantiate new app obj and fill properties from DB
                    Applicant application = new Applicant();
                    application.CustID = applicationReader["CustID"].ToString();
                    application.FirstName = applicationReader["CustFirstName"].ToString();
                    application.LastName = applicationReader["CustLastName"].ToString();
                    application.Street = applicationReader["CustStreet"].ToString();
                    application.City = applicationReader["CustCity"].ToString();
                    application.State = applicationReader["CustState"].ToString();
                    application.Zip = Convert.ToInt32(applicationReader["CustZip"]);

                    return application;
                }
                else
                {
                    return null;
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                c.Close();
            }
            
        }

        public static DataTable GetApplicantJobHistory(string primaryKey)
        {
            SqlConnection c = LoansDB.GetConnection();
            string selectStatement = "SELECT CustID, JobID, JobTitle, StartDate, EndDate, Salary " +
                "FROM JobHistory " +
                "WHERE CustID = @CustID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, c);

            selectCommand.Parameters.AddWithValue("@CustID", primaryKey);

            try
            {
                    c.Open();
                    SqlDataReader reader = selectCommand.ExecuteReader();

                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        return dt;
                    }
                    else
                    {
                        return null;
                    }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                c.Close();
            }
        }

        public static bool UpdateApplicant(Applicant oldApplicant, Applicant newApplicant)
        {
            SqlConnection c = LoansDB.GetConnection() ;

            string updateStatement = "UPDATE LoanApplicant SET " +
                "CustFirstName = @NewFName, " +
                "CustLastName = @NewLName, " +
                "CustStreet = @NewStreet, " +
                "CustCity = @NewCity, " +
                "CustState = @NewState, " +
                "CustZip = @NewZip " +
                "WHERE CustID = @OldCustID";
      

            SqlCommand updateCommand = new SqlCommand(updateStatement, c);

            updateCommand.Parameters.AddWithValue(
                "@NewFName", newApplicant.FirstName);
            updateCommand.Parameters.AddWithValue(
                "@NewLName", newApplicant.LastName);
            updateCommand.Parameters.AddWithValue(
                "@NewStreet", newApplicant.Street);
            updateCommand.Parameters.AddWithValue(
                "@NewCity", newApplicant.City);
            updateCommand.Parameters.AddWithValue(
                "@NewState", newApplicant.State);
            updateCommand.Parameters.AddWithValue(
                "@NewZip", newApplicant.Zip);

            updateCommand.Parameters.AddWithValue(
                "@OldCustID", oldApplicant.CustID);

            try
            {
                c.Open();
                int count = updateCommand.ExecuteNonQuery();

                if(count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                c.Close();
            }
        }

        public static bool UpdateJob(Job oldJob, Job newJob)
        {
            SqlConnection c = LoansDB.GetConnection();

            string updateStatement = "UPDATE JobHistory SET " +
                "JobTitle = @NewJobTitle, " +
                "StartDate = @NewStartDate, " +
                "EndDate = @NewEndDate, " +
                "Salary  = @NewSalary " +
                "WHERE JobID = @oldJobID";

            SqlCommand updateCommand = new SqlCommand(updateStatement, c);

            updateCommand.Parameters.AddWithValue(
                "@NewJobTitle", newJob.Job_Title);
            updateCommand.Parameters.AddWithValue(
                "@NewStartDate", newJob.Start_Date);
            updateCommand.Parameters.AddWithValue(
                "@NewEndDate", newJob.End_Date);
            updateCommand.Parameters.AddWithValue(
                "@newSalary", newJob.Salary);

            updateCommand.Parameters.AddWithValue(
                "@oldJobID", oldJob.JobID);

            try
            {
                c.Open();

                int count = updateCommand.ExecuteNonQuery();

                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                c.Close();
            }
         }

        public static bool DeleteJob(Job job)
        {
            SqlConnection c = LoansDB.GetConnection();

            string deleteStatement = "DELETE FROM JobHistory " +
                "WHERE JobID = @JobID;";

            SqlCommand deleteCommand = new SqlCommand(deleteStatement, c);

            deleteCommand.Parameters.AddWithValue(
                "@JobID", job.JobID);


            try
            {
                c.Open();

                int count = deleteCommand.ExecuteNonQuery();

                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                c.Close();
            }
        }

        public static bool InsertNewJob (Job job)
        {

            {
                SqlConnection c = LoansDB.GetConnection();

                string insertStatement = "INSERT INTO JobHistory " +
                    "(JobID, CustID, JobTitle, StartDate, EndDate, Salary) " +
                    "VALUES (@NewJobID, @NewCustID, @NewJobTitle, @NewStartDate, @NewEndDate, @NewSalary);";

                SqlCommand insertCommand = new SqlCommand(insertStatement, c);

                insertCommand.Parameters.AddWithValue(
                    "@NewJobID", job.JobID);
                insertCommand.Parameters.AddWithValue(
                    "@NewCustID", job.CustID);
                insertCommand.Parameters.AddWithValue(
                    "@NewJobTitle", job.Job_Title);
                insertCommand.Parameters.AddWithValue(
                    "@NewStartDate", job.Start_Date);
                insertCommand.Parameters.AddWithValue(
                    "@NewEndDate", job.End_Date);
                insertCommand.Parameters.AddWithValue(
                    "@NewSalary", job.Salary);


                try
                {
                    c.Open();

                    int count = insertCommand.ExecuteNonQuery();

                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    c.Close();
                }
            }
        }
    }
}
