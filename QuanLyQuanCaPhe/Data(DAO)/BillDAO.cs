using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.Data_DAO_
{
     public class BillDAO
    {
        private static BillDAO instansce;

        public static BillDAO Instansce { get { if (instansce == null) instansce = new BillDAO(); return instansce; } private set { instansce = value; } }

        private BillDAO() { }

        public void InsertBillByIdTable(int id)
        {
            DataProvider.Instance.ExecuteQuery("EXEC dbo.USP_INSERTBILL @idTable =" + id.ToString());
        }
        public void InsertBillInfor(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteQuery("EXEC dbo.USP_INSERTBILLINFO @idBill =" + idBill.ToString() + ",  @idFood =" + idFood.ToString() + ",  @countFood = " + count.ToString());
        }

        public DataTable getMaxIdBill()
        {

        return DataProvider.Instance.ExecuteQuery("SELECT MAX(id) AS id FROM dbo.Bill");

        }

    }

}
