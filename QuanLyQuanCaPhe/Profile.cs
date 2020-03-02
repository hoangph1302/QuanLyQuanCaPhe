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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void buttonWatchPass_Click(object sender, EventArgs e)
        {
            bool status = textBoxPass.UseSystemPasswordChar;
            if (status)
                textBoxPass.UseSystemPasswordChar = false;
            else textBoxPass.UseSystemPasswordChar = true;
        }

        
    }
}
