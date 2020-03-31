using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crowe_IMS
{
    public partial class partByUser : Form
    {
        List<partsdb> partList = new List<partsdb>();
        List<productsdb> productList = new List<productsdb>();
        List<usertable> userList = new List<usertable>();
        Form1 formHolder = null;
        
        public partByUser(Form1 fh)
        {
            formHolder = fh;
            InitializeComponent();

        }

        private void partByUser_Load(object sender, EventArgs e)
        {
            userList = dbHelper.getOrderedeUsers();
            comboBox1.DataSource = userList;
            comboBox1.DisplayMember = "username";
        }

        usertable userHolder = new usertable();
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            userHolder = comboBox1.SelectedItem as usertable;
            updateDgv(userHolder);
        }
              
        private void updateDgv(usertable user)
        {
            if (rbParts.Checked == true)
            {
                partList = dbHelper.GetAllPartsByUser(user.userid);
                label2.Text = "Total # of Parts: " + partList.Count();
                if (partList.Count() == 0) MessageBox.Show("User hasn't created any parts.");
                dgvPart.DataSource = partList;

            }
            else
            {
                productList = dbHelper.GetAllProductsByUser(user.userid);
                label2.Text = "Total # of Products: " + productList.Count();
                if (productList.Count() == 0) MessageBox.Show("User hasn't created any products.");
                dgvPart.DataSource = productList;
            }
            
            dgvPart.RowHeadersVisible = false;
            dgvPart.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            dgvPart.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            dgvPart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPart.AllowUserToAddRows = false;
            dgvPart.ClearSelection();
            dgvPart.Columns["usertable"].Visible = false;
            dgvPart.Columns["productsparts"].Visible = false;
            dgvPart.Columns["createdby"].Visible = false;
            dgvPart.Columns["price"].DefaultCellStyle.Format = "c";
            dgvPart.Columns["lastmodified"].Width = 150;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formHolder.Show();
            this.Close();
        }

        private void rbParts_CheckedChanged(object sender, EventArgs e)
        {
            updateDgv(userHolder);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            updateDgv(userHolder);
        }
    }
}
