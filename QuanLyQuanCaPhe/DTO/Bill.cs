using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.DTO
{
    public class Bill
    {
        private int iD;
        private DateTime timeCheckIn;
        private int idTable;
        private int statusPay;
        private DateTime timeCheckOut;
        public Bill(int id, DateTime timeCheckIn, int idTable,int statusPay,DateTime timeCheckOut)
        {
            this.ID = id;
            this.TimeCheckIn = timeCheckIn;
            this.IdTable = idTable;
            this.StatusPay = statusPay;
            this.TimeCheckOut = timeCheckOut;
        }
        public Bill(DataRow data)
        {
            this.ID = (int)data["id"];
            //this.TimeCheckIn = (DateTime)data["timeCheckIn"];
            //this.IdTable = (int)data["idTable"];
            //this.StatusPay = (int)data["statusPay"];
            //this.TimeCheckOut=(DateTime)data["timeCheckOut"];
        }

        public int ID { get => iD; set => iD = value; }
        public DateTime TimeCheckIn { get => timeCheckIn; set => timeCheckIn = value; }
        public int IdTable { get => idTable; set => idTable = value; }
        public int StatusPay { get => statusPay; set => statusPay = value; }
        public DateTime TimeCheckOut { get => timeCheckOut; set => timeCheckOut = value; }
    }
}
