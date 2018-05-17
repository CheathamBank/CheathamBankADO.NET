using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CheathamBankADO.NET
{
    class LoansDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
             "Data Source =(LocalDB)\\MSSQLLocalDB;AttachDbFileName=|DataDirectory|\\Loans.mdf;" +
             "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

                return connection;
        }


    }
}
