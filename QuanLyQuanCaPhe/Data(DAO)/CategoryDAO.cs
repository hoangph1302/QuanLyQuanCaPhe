using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.Data_DAO_
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance { get { if (instance == null) instance = new CategoryDAO(); return instance; } set { instance = value; } }

        private CategoryDAO() { }
        public DataTable getCategory()
        {
            DataTable listcategory = new DataTable();

            string query = " SELECT * FROM dbo.FoodCategory";

            listcategory =DataProvider.Instance.ExecuteQuery(query);

            return listcategory;
        }

        public DataTable getFood(string id)
        {
            DataTable listFood = new DataTable();

            string query = "  SELECT f.id,f.nameFood,f.price FROM dbo.Food AS f ,dbo.FoodCategory AS c WHERE c.id =f.idCategory AND c.id="+id;

           listFood = DataProvider.Instance.ExecuteQuery(query);

            return listFood;
        }
        public DataTable getPrice(string id)
        {
            DataTable price = new DataTable();

            string query = " SELECT price FROM dbo.Food WHERE id="+id;

            price = DataProvider.Instance.ExecuteQuery(query);

            return price;
        }
    }
}
