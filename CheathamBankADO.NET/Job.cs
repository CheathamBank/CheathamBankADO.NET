using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheathamBankADO.NET
{
    public class Job
    {
        private int jobID;
        private int custID;
        private string jobTitle;
        private DateTime startDate;
        private DateTime endDate;
        private decimal salary;

        public Job() { }

        public int JobID
        {
            get
            {
                return jobID;
            }
            set
            {
                jobID = value;
            }

        }

        public int CustID
        {
            get
            {
                return custID;
            }
            set
            {
                custID = value;
            }
        }
        public string Job_Title
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }
        public DateTime Start_Date
        {
            get
            {
                return startDate;
            }
            set
            {
                startDate = value;
            }
        }
        public DateTime End_Date
        {
            get
            {
                return endDate;
            }
            set
            {
                endDate = value;
            }
        }
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
    }
}
