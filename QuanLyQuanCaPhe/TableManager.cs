using QuanLyQuanCaPhe.Data_DAO_;
using QuanLyQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    public partial class TableManager : Form
    {
        public login formLogin = new login();

        int total;
        string idCategory="1";
        public TableManager()
        {
            InitializeComponent();
            loadTable();
            loadCategory();
        }

        #region Method
        void loadTable()
        {
            textBoxTime.Text = DateTime.Now.ToString();
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
                bttn.Click += Bttn_Click;
                bttn.Tag = item;

            }


        }

        int Pay(int id)
        {
            listViewMenu.Items.Clear();

            List<MenuFood> listMenu = MenuDAO.Instance.GetListMenuByIdTable(id);
            total = 0;
            int i = 0;
            textBoxTableWatch.Text = "";
            foreach (MenuFood item in listMenu)
            {
                i++;
                ListViewItem listItem = new ListViewItem(i.ToString());
                listItem.SubItems.Add((item.NameFood.ToString()));
                listItem.SubItems.Add((item.Count.ToString()));
                listItem.SubItems.Add(item.Price.ToString());
                listItem.SubItems.Add(item.TotalPrice.ToString());
                total += item.TotalPrice;
                textBoxTableWatch.Text = item.NameTable;
                listViewMenu.Items.Add(listItem);

            }
            return total;
        }

        void loadCategory()
        {
            comboBoxCategory.DataSource = CategoryDAO.Instance.getCategory();
            comboBoxCategory.DisplayMember = "nameCategory";
            

        }

        #endregion

        #region Event

        private void Bttn_Click(object sender, EventArgs e)
        {
            numericUpDownSaleOff.Value=0;
            int id = ((sender as Button).Tag as Table).ID;
           
            total=Pay(id);

            //total = total - total * Convert.ToInt32(numericUpDownSaleOff.Value.ToString()) / 100;
            CultureInfo cultureRu = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = cultureRu;
            textBoxTotal.Text = total.ToString("c");

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

        private void buttonSaleOff_Click(object sender, EventArgs e)
        {

            total = total - total * Convert.ToInt32(numericUpDownSaleOff.Value.ToString()) / 100;
            CultureInfo cultureRu = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = cultureRu;
            textBoxTotal.Text = total.ToString("c");
           
        }




        #endregion

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCategory.ValueMember = "id";
            idCategory = comboBoxCategory.SelectedValue.ToString();
            comboBoxFood.DataSource = CategoryDAO.Instance.getFood(idCategory);
            comboBoxFood.DisplayMember = "nameFood";
           
        }

        private void comboBoxFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxFood.ValueMember = "id";
            string idFood = comboBoxFood.SelectedValue.ToString();
            comboBoxPrice.DataSource = CategoryDAO.Instance.getPrice(idFood);
            comboBoxPrice.DisplayMember = "price";
        }

       
    }

}

