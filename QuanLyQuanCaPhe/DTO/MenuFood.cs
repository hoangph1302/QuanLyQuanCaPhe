﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.DTO
{
    public class MenuFood
    {
        private string nameFood;
        private int count;
        private int price;
        private int totalPrice;
        private string nameTable;
        public MenuFood(string nameTable,string namefood, int count,int price,int totalPrice=0)
        {
            this.NameFood = namefood;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
            this.NameTable = nameTable;
        }

        public MenuFood(DataRow data)
        {
            this.NameFood = (string)data["nameFood"];
            this.Count = (int)data["coutFood"];
            this.Price = (int)data["price"];
            this.TotalPrice = (int)data["total"];
            this.NameTable = (string)data["nameTable"];
        }



        public string NameFood { get => nameFood; set => nameFood = value; }
        public int Count { get => count; set => count = value; }
        public int Price { get => price; set => price = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string NameTable { get => nameTable; set => nameTable = value; }
    }
}
