using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace QuanLyQuanCaPhe
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        void RunTableManager()
        {
            Application.Run(new TableManager());
        }
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
      
            TableManager formShow = new TableManager();
            this.Hide();
            formShow.ShowDialog();
            textBoxUserName.Text = "";
            textBoxPass.Text = "";
            this.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hay không?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
               != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
             
            }
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            SignUp formSignUp = new SignUp();
            this.Hide();
            formSignUp.ShowDialog();
            this.Show();
           

        }
    }
}
