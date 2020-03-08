using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.DTO
{
   public class Table
    {
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }

        private string name;
        private string status;
        
        public Table(DataRow datarow)
        {
            this.ID = (int)datarow["id"];
            this.Name = datarow["nameTable"].ToString();
            this.Status = datarow["statusTable"].ToString();
        }
        public Table(int id, string name, string status)
        {
            this.iD = id;
            this.Name = name;
            this.Status = status;
        }
    }
}
