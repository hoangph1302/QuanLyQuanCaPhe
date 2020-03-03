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
        public TableManager()
        {
            InitializeComponent();
            textBoxTime.Text = DateTime.Now.ToString();
        }

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
    }
}
