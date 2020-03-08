





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
        private static DataProvider instance;

        public static DataProvider Instance 
        { 
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        
        }

        public DataTable ExecuteQuery(string query, object[] parameter=null)
        {
            DataTable dataAccount = new DataTable();
            string connectionStr = "Data Source=DESKTOP-JPB583J;Initial Catalog=QuanLyQuanCaPhe;Integrated Security=True";
            using (SqlConnection connectionAccount = new SqlConnection(connectionStr))
            {
                connectionAccount.Open();
                SqlCommand commandAccount = new SqlCommand(query, connectionAccount);
                if (parameter != null)
                {
                    string[] listQuery = query.Split(' ');
                    int i = 0;
                    foreach (string item in listQuery)
                    {
                        if (item.Contains('@'))
                        {
                            commandAccount.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adaterAccount = new SqlDataAdapter(commandAccount);
                adaterAccount.Fill(dataAccount);
                connectionAccount.Close();
            }
            return dataAccount;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data;
            string connectionStr = "Data Source=DESKTOP-JPB583J;Initial Catalog=QuanLyQuanCaPhe;Integrated Security=True";
            using (SqlConnection connectionAccount = new SqlConnection(connectionStr))
            {
                connectionAccount.Open();
                SqlCommand commandAccount = new SqlCommand(query, connectionAccount);
                if (parameter != null)
                {
                    string[] listQuery = query.Split(' ');
                    int i = 0;
                    foreach (string item in listQuery)
                    {
                        if (item.Contains('@'))
                        {
                            commandAccount.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = commandAccount.ExecuteNonQuery();
                connectionAccount.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data=0;
            string connectionStr = "Data Source=DESKTOP-JPB583J;Initial Catalog=QuanLyQuanCaPhe;Integrated Security=True";
            using (SqlConnection connectionAccount = new SqlConnection(connectionStr))
            {
                connectionAccount.Open();
                SqlCommand commandAccount = new SqlCommand(query, connectionAccount);
                if (parameter != null)
                {
                    string[] listQuery = query.Split(' ');
                    int i = 0;
                    foreach (string item in listQuery)
                    {
                        if (item.Contains('@'))
                        {
                            commandAccount.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = commandAccount.ExecuteScalar();
                connectionAccount.Close();
            }
            return data;
        }
    }
}


