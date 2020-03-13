using QuanLyQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.Data_DAO_
{
   public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO();return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }
        private TableDAO() {}

        public List<Table> loadListTable()
        {
            List<Table> listTable = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC dbo.USP_TABLE");
            foreach (DataRow  item in data.Rows)
            {
                Table table = new Table(item);
                listTable.Add(table);
            }

            return listTable;
        }
        public void ChangeStatus(int id)
        {
            DataProvider.Instance.ExecuteQuery("UPDATE dbo.TableService SET statusTable=N'Có Người'WHERE id=" + id.ToString());
        }
       

    }
}
