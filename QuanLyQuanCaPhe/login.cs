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
using QuanLyQuanCaPhe.Data_DAO_;

namespace QuanLyQuanCaPhe
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

           // MessageBox.Show(DataProvider.Instance.ExecuteNonQuery("SELECT * FROM dbo.Accout WHERE username='Addtmin'").ToString());


        }


        void RunTableManager()
        {
            Application.Run(new TableManager());
        }
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (Account.Instance.passAuthentication(TextBoxUserName.Text, textBoxPass.Text))
            {

                TableManager formShow = new TableManager();
                this.Hide();
                formShow.ShowDialog();
                textBoxUserName.Text = "";
                textBoxPass.Text = "";
                this.Show();

            }
            else MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
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

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            SignUp formSignUp = new SignUp();
            this.Hide();
            formSignUp.ShowDialog();
            this.Show();

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPass.Text != "" && TextBoxUserName.Text != "")
                buttonSignIn.Enabled = true;
            else buttonSignIn.Enabled = false;
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

            if (textBoxPass.Text != "" && TextBoxUserName.Text != "")
                buttonSignIn.Enabled = true;

            else buttonSignIn.Enabled = false;



        }
    }
}
