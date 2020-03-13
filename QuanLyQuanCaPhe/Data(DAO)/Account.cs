using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.Data_DAO_
{
   public class Account
    {
        private static Account instance;

        public static Account Instance
        {
            get { if (instance == null) instance = new Account(); return Account.instance; }
            private set { Account.instance = value; }
        }

        private Account() { }

        public bool passAuthentication(string userName, string pass)
        {
            bool res=false;
            string query = "EXEC dbo.USP_LOGIN @UserName ,  @Pass";
            if (DataProvider.Instance.ExecuteQuery(query, new object[] { userName, pass }).Rows.Count > 0)
                res=true;

          
            return res;
        }

        public void CreatAccout(string displayName,string userName,string pass)
        {

            DataProvider.Instance.ExecuteQuery("EXEC dbo.USP_CREATACCOUNT @DisplayName = N'" + displayName + "', @UserName = N'" + userName + "', @Pass = N'" + pass + "' ");
        }
    }
}
