using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crowe_IMS
{
    public partial class financialForm : Form
    {
        Form1 formHolder = null;
        public financialForm(Form1 formHolder)
        {
            InitializeComponent();
            this.formHolder = formHolder;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formHolder.Show();
            this.Close();
        }

        private financials parts = null; private financials products = null;
        
        //bool isProductSelected = false;
        private void financialForm_Load(object sender, EventArgs e)
        {
            parts = new financials(false); products = new financials(true);
            loadView();
        }

        private void rbParts_CheckedChanged(object sender, EventArgs e){loadView();}

        private void rbProducts_CheckedChanged(object sender, EventArgs e){loadView();}

        private void loadView()
        {
            if (rbParts.Checked == true)
            {
                setLabels(parts);
                loadDgv(parts);
            }
            else
            {
                setLabels(products);
                loadDgv(products);
            }
        }

        private void loadDgv(financials holder)
        {
            dgvDisplay.DataSource = holder.getDisplayItems();
            dgvDisplay.RowHeadersVisible = false;
            dgvDisplay.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            dgvDisplay.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            dgvDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDisplay.AllowUserToAddRows = false;
            dgvDisplay.ClearSelection();
            dgvDisplay.Columns["Total_Value"].DefaultCellStyle.Format = "c";
            dgvDisplay.Columns["Total_Value"].Width = 120;
        }

        private void setLabels(financials holder)
        {
            lbCount.Text = "Total # of selected items: " + holder.getCount();
            lbTotal.Text = "Total value of selected items: " + holder.getTotal().ToString("c", new CultureInfo("en-US"));
            lbGrandTotal.Text = "Grand total parts and products: " + (parts.getTotal()+products.getTotal()).ToString("c", new CultureInfo("en-US"));
        }
    }
}
