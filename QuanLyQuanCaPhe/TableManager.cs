using QuanLyQuanCaPhe.Data_DAO_;
using QuanLyQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    public partial class TableManager : Form
    {
        public login formLogin = new login();
        public TableManager()
        {
            InitializeComponent();
            textBoxTime.Text = DateTime.Now.ToString();
            loadTable();
        }

        #region Method
        void loadTable()
        {
           List<Table> tableList = TableDAO.Instance.loadListTable();

            foreach ( Table item in tableList)
            {
                Button bttn = new Button();
                bttn.Text = item.Name + "\n" + item.Status;
                bttn.Width = 80;
                bttn.Height = 80;
                if (item.Status == "Trống")
                    bttn.BackColor = Color.Pink;
                else bttn.BackColor = Color.DarkSalmon;
                flowLayoutPanelTable.Controls.Add(bttn);

            }
        }
        #endregion

        #region Event

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile formProfile = new Profile();
            formProfile.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePass formChangePass = new ChangePass();
            formChangePass.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin formAdimin = new Admin();
            formAdimin.ShowDialog();
        }
        #endregion
    }

}

