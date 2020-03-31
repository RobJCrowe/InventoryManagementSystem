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
    public partial class Form1 : Form
    {
        private int IndexPart { get; set; } = -1;
        private int IndexProduct { get; set; } = -1;
        login loginHolder = new login();
        BindingList<partsdb> allParts = new BindingList<partsdb>();
        BindingList<productsdb> allProducts = new BindingList<productsdb>();

        public Form1(login login)
        {
            InitializeComponent();
            loginHolder = login;
        }

        private void loadDGV()
        {
            allParts = new BindingList<partsdb>(dbHelper.GetAllParts());
            dgvMainPart.DataSource = allParts;
            DGVPartFormatter(dgvMainPart);

            allProducts = new BindingList<productsdb>(dbHelper.GetAllProducts());
            dgvMainProduct.DataSource = allProducts;
            DGVPartFormatter(dgvMainProduct);
        }

        private static void DGVPartFormatter(DataGridView dgvStyle)
        {
            dgvStyle.RowHeadersVisible = false;
            dgvStyle.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            dgvStyle.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            dgvStyle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStyle.AllowUserToAddRows = false;
            dgvStyle.ClearSelection();
            dgvStyle.Columns["usertable"].Visible = false;
            dgvStyle.Columns["productsparts"].Visible = false;
            dgvStyle.Columns["createdby"].Visible = false;
            dgvStyle.Columns["price"].DefaultCellStyle.Format = "c";
            dgvStyle.Columns["lastmodified"].Width = 150;
        }

        private void resetIndex() { IndexProduct = -1; IndexPart = -1; }

        private void btPartAdd_Click(object sender, EventArgs e)
        {
            ModifyPartForm addPartForm = new ModifyPartForm(this);
            this.Hide();
            addPartForm.Show();
            resetIndex();
        }

        private void btPartModify_Click(object sender, EventArgs e)
        {
            if (IndexPart >= 0)
            {
                ModifyPartForm modifyPartForm = new ModifyPartForm(this, partChosen);
                resetIndex();
                this.Hide();
                modifyPartForm.Show();
            }
            else
            {
                MessageBox.Show("You must make a selection.");
            }
        }

        private void btMainExit_Click(object sender, EventArgs e)
        {
            loginHolder.Show();
            this.Close();
        }

        private void btProductAdd_Click(object sender, EventArgs e)
        {
            ModifyProductForm addProductForm = new ModifyProductForm(this);
            resetIndex();
            this.Hide();
            addProductForm.Show();

        }

        private void btProductModify_Click(object sender, EventArgs e)
        {
            if (IndexProduct != -1)
            {
                ModifyProductForm modifyProductForm = new ModifyProductForm(this, productChosen);
                resetIndex();
                this.Hide();
                modifyProductForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must make a selection");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Inventory Management System: " + "Welcome, " + dbHelper.currentUser.username;
            loadDGV();
            partCb.SelectedItem = "All"; productCb.SelectedItem = "All";
        }

        private void btPartSearch_Click(object sender, EventArgs e)
        {
            dgvMainPart.ClearSelection();
            dgvMainPart.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            if (tbPartSearch.Text != "")
            {
                List<int> selectedRows = Crowe_IMS.search.partSearch(tbPartSearch.Text, allParts.ToList(), partCb.SelectedItem.ToString());
                if (selectedRows.Count() == 0)
                {
                    MessageBox.Show("Nothing found");
                    return;
                }

                for (int i = 0; i < selectedRows.Count(); i++)
                {
                    dgvMainPart.Rows[selectedRows[i]].Selected = true;
                }
            }
            else
            {
                MessageBox.Show("You haven't entered any text.");
            }
        }

        private void btProductSearch_Click(object sender, EventArgs e)
        {
            dgvMainProduct.ClearSelection();
            dgvMainProduct.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            if (tbProductSearch.Text != "")
            {
                List<int> selectedRows = Crowe_IMS.search.productSearch(tbProductSearch.Text, allProducts.ToList(), productCb.SelectedItem.ToString());
                if (selectedRows.Count() == 0)
                {
                    MessageBox.Show("Nothing found");
                    return;
                }

                for (int i = 0; i < selectedRows.Count(); i++)
                {
                    dgvMainProduct.Rows[selectedRows[i]].Selected = true;
                }
            }
            else
            {
                MessageBox.Show("You haven't entered any text.");
            }
        }

        private void tbProductSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btProductSearch.PerformClick();
            }
        }

        private void tbPartSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btPartSearch.PerformClick();
            }
        }

        int partChosen = new int();
        private void dgvMainPart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexPart = dgvMainPart.CurrentCell.RowIndex;
            partChosen = allParts[IndexPart].partid;
        }

        int productChosen = new int();
        private void dgvMainProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexProduct = dgvMainProduct.CurrentCell.RowIndex;
            productChosen = allProducts[IndexProduct].productid;
        }

        private void clearSelection()
        {
            dgvMainPart.ClearSelection();
            dgvMainProduct.ClearSelection();
            resetIndex();
        }

        private void btPartDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!allParts.Any())
                {
                    MessageBox.Show("There are no parts to remove."); return;
                }

                if (IndexPart == -1)
                {
                    MessageBox.Show("You must make a selection to remove a part."); return;
                }

                int keepIndex = IndexPart;
                var result = MessageBox.Show("Are you sure you want to delete this part?", "Confirmation Dialog", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) { clearSelection(); return; }

                List<productspart> partList = dbHelper.GetAllAssocPartsBasedOnPart(partChosen);
                var numberOfProducts = partList.Where(i => i.partid == partChosen).GroupBy(n => n.productid).ToList();
                if (partList.Count() == 0) { success(); }
                else
                {
                    var hasParts = MessageBox.Show("This part is associated with " + numberOfProducts.Count() + " products. Removing it will also remove it from any associated products. Proceed?", "Confirmation Dialog", MessageBoxButtons.YesNo);
                    if (hasParts == DialogResult.Yes)
                    {
                        for (int i = 0; i < partList.Count(); i++)
                        {
                            dbHelper.RemoveAssocPartByid(partList[i].productpartid);
                        }
                        success();
                    }
                    else { clearSelection(); return; }
                }

                void success()
                {
                    dbHelper.RemovePart(partChosen);
                    clearSelection();
                    MessageBox.Show("Part has been removed");
                }
            }
            catch
            {
                MessageBox.Show("Error in btPartDelete_Click");
            }

        }

        private void btProductDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!allProducts.Any()) { MessageBox.Show("There are no products to remove."); return; }
                if (IndexProduct == -1) { MessageBox.Show("You must make a selection to remove a product."); return; }

                var result = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation Dialog", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) { resetIndex(); return; }
                if (dbHelper.GetAllAssocParts(productChosen).Count() > 0)
                {
                    var result2 = MessageBox.Show("There is at least one part associated with this product. Products cannot be removed before all associated parts have been removed. Please confirm you want to remove all associated parts and remove the product.", "Confirmation Dialog", MessageBoxButtons.YesNo);
                    if (result2 == DialogResult.Yes)
                    {
                        removeProduct();
                    }
                    else{ resetIndex(); return;}
                }
                else{ removeProduct();}

                void removeProduct()
                {
                    dbHelper.RemoveProduct(productChosen);
                    clearSelection();
                    MessageBox.Show("Product has been removed");
                }
            }
            catch
            {
                MessageBox.Show("Error in btProductDelete_Click");
            }
        }

        private void Form1_Activated(object sender, EventArgs e){loadDGV();}

        private void inventorySummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            partByUser report1 = new partByUser(this);
            this.Hide();
            report1.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginHolder.Show();
            this.Close();
        }

        private void financialSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            financialForm report2 = new financialForm(this);
            report2.Show();
            this.Hide();
        }

        private void runUnitTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnitTesting.RunTests();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginHolder.Close();
            this.Close();
        }
    }
}
