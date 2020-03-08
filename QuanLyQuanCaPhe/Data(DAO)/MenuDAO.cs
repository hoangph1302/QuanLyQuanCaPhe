using QuanLyQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.Data_DAO_
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance { get { if (instance == null) instance = new MenuDAO();  return instance; } private set { MenuDAO.instance = value; }}

        private MenuDAO() { }

        public List<MenuFood> GetListMenuByIdTable(int id)
        {
            List<MenuFood> listMenu = new List<MenuFood>();
            string query = "SELECT f.nameFood, bf.coutFood,f.price,f.price*bf.coutFood AS total FROM dbo.BillInfo AS bf, " +
                "dbo.Food AS f, dbo.Bill AS b, dbo.TableService AS t WHERE b.id = bf.idBill AND bf.idFood=f.id AND t.id=" + id.ToString();
            foreach (System.Data.DataRow item in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                listMenu.Add(new MenuFood(item));

            }


            return listMenu;
        }
    }
}
