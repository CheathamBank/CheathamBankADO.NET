using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheathamBankADO.NET
{
    public class Applicant
    {
        private string custID;
        private string fName;
        private string lName;
        private string street;
        private string city;
        private string state;
        private int zip;

        public Applicant() { }

        public Applicant(string custID, string fName, string lName, string street, string city,
            string state, int zip)
        {

        }
        public string CustID
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
        public string FirstName
        {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lName;
            }
            set
            {
                lName = value;
            }
        }
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
        public int Zip
        {
            get
            {
                return zip;
            }
            set
            {
                zip = value;
            }
        }
    }
}
