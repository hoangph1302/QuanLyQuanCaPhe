using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyQuanCaPhe.Data_DAO_
{
    public class DataProvider
    {
       public DataTable ExecuteQuery(string query)
        {
            DataTable dataAccount = new DataTable();
            string connectionStr = "Data Source=DESKTOP-JPB583J;Initial Catalog=QuanLyQuanCaPhe;Integrated Security=True";
            using (SqlConnection connectionAccount = new SqlConnection(connectionStr))
            {
                connectionAccount.Open();
                SqlCommand commandAccount = new SqlCommand(query, connectionAccount);
              
                SqlDataAdapter adaterAccount = new SqlDataAdapter(commandAccount);
                adaterAccount.Fill(dataAccount);
                connectionAccount.Close();
            }
            return dataAccount;
        }
    }

}
