﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyQuanCaPhe.Data_DAO_;

namespace QuanLyQuanCaPhe
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            loadData();
        }

        private void buttonWatchPass_Click(object sender, EventArgs e)
        {
            bool status = textBoxPass.UseSystemPasswordChar;
            if (status)
                textBoxPass.UseSystemPasswordChar = false;
            else textBoxPass.UseSystemPasswordChar = true;
        }

        void loadData()
        {
            string query = "SELECT* FROM dbo.Accout";

           
            dataGridViewAccount.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }
    }
}
