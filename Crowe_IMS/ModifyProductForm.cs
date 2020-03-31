using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crowe_IMS
{
    public partial class ModifyProductForm : Form
    {
        productsdb initialProduct = new productsdb();
        List<productspart> initialListProductParts = new List<productspart>();
        List<partsdb> initialListParts = new List<partsdb>();

        BindingList<partsdb> addedParts = new BindingList<partsdb>();
        BindingList<partsdb> allParts = new BindingList<partsdb>();

        int intParse; int productIndex;

        #region Hide Main Form
        Form1 test;
        public ModifyProductForm(Form1 pform, int index) : this()
        {
            test = pform;
            productIndex = index;
        }

        bool isNew = false;
        public ModifyProductForm(Form1 pform) : this()
        {
            test = pform;
            isNew = true;
        }

        private void closeChildForm()
        {
            test.Show();
            this.Close();
        }
        public ModifyProductForm() { InitializeComponent(); }

        #endregion

        private void btModifyProductCancel_Click(object sender, EventArgs e)
        {
            closeChildForm();
        }

        private bool isDifferent()
        {
            //Check product itself
            if (tbModifyProductInventory.Text != initialProduct.instock.ToString()) return true;
            if (tbModifyProductMax.Text != initialProduct.max.ToString()) return true;
            if (tbModifyProductMin.Text != initialProduct.min.ToString()) return true;
            if (tbModifyProductName.Text != initialProduct.name.ToString()) return true;
            if (tbModifyProductPrice.Text != initialProduct.price.ToString("#,0.00")) return true;

            //Check List
            bool result3 = convertToInt(initialListParts.OrderBy(n => n.partid).ToList()).SequenceEqual(convertToInt(addedParts.OrderBy(m => m.partid).ToList()));

            if (result3 == true)
            {
                MessageBox.Show("This product has not been altered. Please make changes before you attempt to save it.");
                return false;
            }
            return true;

            List<int> convertToInt(List<partsdb> listIn)
            {
                List<int> tempList = new List<int>();
                for (int i = 0; i < listIn.Count(); i++)
                {
                    tempList.Add(listIn[i].partid);
                }
                return tempList;
            }
        }

        private void btModifyProductSave_Click(object sender, EventArgs e)
        {
            if (!isNew)
            {
                if (isDifferent() == false) return;
            }

            if (addedParts.Count() == 0)
            {
                MessageBox.Show("You must add a part to the product.");
                return;
            }
            if (l_Modify_ProductName.Visible == true || l_Modify_Price.Visible == true || l_Modify_ProductInventory.Visible == true || l_Modify_Max.Visible == true || l_Modify_Min.Visible == true)
            {
                MessageBox.Show("You must fix the red boxes before you can save."); return;
            }
            if (Int32.Parse(tbModifyProductMax.Text) <= Int32.Parse(tbModifyProductMin.Text))
            {
                MessageBox.Show("Max must be greater than Min."); return;
            }
            if ((Int32.Parse(tbModifyProductInventory.Text) <= Int32.Parse(tbModifyProductMin.Text)) || (Int32.Parse(tbModifyProductInventory.Text) >= Int32.Parse(tbModifyProductMax.Text)))
            {
                MessageBox.Show("Inventory must be greater than min and less than max."); return;
            }

            productsdb tempProduct = new productsdb();
            tempProduct.name = tbModifyProductName.Text; tempProduct.min = Int32.Parse(tbModifyProductMin.Text);
            tempProduct.max = Int32.Parse(tbModifyProductMax.Text); tempProduct.instock = Int32.Parse(tbModifyProductInventory.Text); tempProduct.price = Decimal.Parse(tbModifyProductPrice.Text);
            tempProduct.createdby = dbHelper.currentUser.userid;

            if (isNew)
            {
                tempProduct.lastmodified = DateTime.Now;
                int productIndex = dbHelper.AddProduct(tempProduct);
                for (int i = 0; i < addedParts.Count; i++)
                {
                    dbHelper.AddAssocPart(productIndex, addedParts[i].partid);
                }
            }
            else
            {
                tempProduct.productid = Int32.Parse(tbModifyProductID.Text);
                dbHelper.ModifyProductImproved(tempProduct, addedParts.ToList<partsdb>(), initialListProductParts);
            }
            closeChildForm();
        }

        private void btModifyProductDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (addedParts.Count() == 0) { MessageBox.Show("You must add a part to the product."); return; }
                if (!addedParts.Any()) { MessageBox.Show("There are no parts to remove."); return; }
                if (modifyProductRemovePartsIndex == -1) { MessageBox.Show("You must make a selection to remove a part."); return; }

                var result = MessageBox.Show("Are you sure you want to delete this part?", "Confirmation Dialog", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    addedParts.Remove(partToRemove);
                    dgvModifyProductAddParts.ClearSelection();
                }
                else { return; }
            }
            catch
            {
                MessageBox.Show("Error in btPartDelete_Click");
            }
            modifyProductRemovePartsIndex = -1;
        }

        private void btModifyProductAdd_Click(object sender, EventArgs e)
        {
            if (modifyProductAllPartsIndex == -1) { MessageBox.Show("You must make a selection"); return; }
            addedParts.Add(chosenPart);
            dgvModifyProductAddParts.ClearSelection();
        }

        private int modifyProductAllPartsIndex { get; set; } = -1;
        private int modifyProductRemovePartsIndex { get; set; } = -1;

        partsdb chosenPart;
        private void dgvModifyProductAllParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            modifyProductAllPartsIndex = dgvModifyProductAllParts.CurrentCell.RowIndex;
            chosenPart = allParts[modifyProductAllPartsIndex];
        }

        partsdb partToRemove;
        private void dgvModifyProductAddParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            modifyProductRemovePartsIndex = dgvModifyProductAddParts.CurrentCell.RowIndex;
            partToRemove = addedParts[modifyProductRemovePartsIndex];
        }

        private void hasText(TextBox text, Label label)
        {
            if (text.Text.Length == 0)
            {
                label.Visible = true;
                label.Text = "You must enter information.";
                text.BackColor = Color.Red;
            }
            else
            {
                label.Visible = false;
                label.Text = "";
                text.BackColor = Color.White;
            }
        }

        private void tbModifyProductName_KeyUp(object sender, KeyEventArgs e)
        {
            hasText(tbModifyProductName, l_Modify_ProductName);
        }

        private void validateInt(TextBox text, Label label)
        {
            if (!int.TryParse(text.Text, out intParse))
            {
                label.Visible = true;
                text.BackColor = Color.Red;
                label.Text = "Must be an integer";
            }
            else
            {
                label.Visible = false;
                label.Text = "";
                text.BackColor = Color.White;
            }
        }

        private void tbModifyProductInventory_KeyUp(object sender, KeyEventArgs e)
        {
            validateInt(tbModifyProductInventory, l_Modify_ProductInventory);
        }

        private void tbModifyProductMax_KeyUp(object sender, KeyEventArgs e)
        {
            validateInt(tbModifyProductMax, l_Modify_Max);
        }

        private void tbModifyProductMin_KeyUp(object sender, KeyEventArgs e)
        {
            validateInt(tbModifyProductMin, l_Modify_Min);
        }

        private void checkDecimal(TextBox text, Label label)
        {
            decimal decParse;
            if (!decimal.TryParse(text.Text, out decParse))
            {
                label.Visible = true;
                text.BackColor = Color.Red;
                label.Text = "Must be a decimal";
            }
            else
            {
                label.Visible = false;
                label.Text = "";
                text.BackColor = Color.White;
            }
        }

        private void tbModifyProductPrice_KeyUp(object sender, KeyEventArgs e)
        {
            checkDecimal(tbModifyProductPrice, l_Modify_Price);
        }

        private void tbModifyProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            string senderText = (sender as TextBox).Text;
            string senderName = (sender as TextBox).Name;
            string[] splitByDecimal = senderText.Split('.');
            int cursorPosition = (sender as TextBox).SelectionStart;

            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if (e.KeyChar == '.'
                && senderText.IndexOf('.') > -1)
            {
                e.Handled = true;
            }


            if (!char.IsControl(e.KeyChar)
                && senderText.IndexOf('.') < cursorPosition
                && splitByDecimal.Length > 1
                && splitByDecimal[1].Length == 2)
            {
                e.Handled = true;
            }
            //This method was designed to limit the textbox to two decimals and only one decimal point. https://stackoverflow.com/a/26690208
        }

        private void loadDgvModifyProduct()
        {
            dgvModifyProductAllParts.DataSource = null;
            dgvModifyProductAllParts.DataSource = allParts;
            dgvModifyProductAllParts.ClearSelection();
            dgvFormatter(dgvModifyProductAllParts);

            dgvModifyProductAddParts.DataSource = null;
            dgvModifyProductAddParts.DataSource = addedParts;
            dgvModifyProductAddParts.ClearSelection();
            dgvFormatter(dgvModifyProductAddParts);
        }

        private void dgvFormatter(DataGridView dgvStyle)
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

        private void ModifyProductForm_Load(object sender, EventArgs e)
        {
            allParts = new BindingList<partsdb>(dbHelper.GetAllParts());
            if (isNew)
            {
                SetLabels();
                loadDgvModifyProduct();
                return;
            }

            initialProduct = dbHelper.GetProduct(productIndex);
            initialListProductParts = dbHelper.GetAllAssocParts(productIndex);
            initialListParts = dbHelper.GetDerivedParts(productIndex);

            addedParts = new BindingList<partsdb>(dbHelper.GetDerivedParts(productIndex));
            loadDgvModifyProduct();

            productsdb modify = dbHelper.GetProduct(productIndex);
            tbModifyProductID.Text = Convert.ToString(modify.productid);
            tbModifyProductName.Text = modify.name;
            tbModifyProductPrice.Text = modify.price.ToString("#,0.00");
            tbModifyProductInventory.Text = Convert.ToString(modify.instock);
            tbModifyProductMin.Text = Convert.ToString(modify.min);
            tbModifyProductMax.Text = Convert.ToString(modify.max);
        }

        private void SetLabels()
        {
            label1.Text = "Add Product"; this.Text = "Add Product Form";
            tbModifyProductName.BackColor = Color.Red;
            tbModifyProductInventory.BackColor = Color.Red;
            tbModifyProductMax.BackColor = Color.Red;
            tbModifyProductMin.BackColor = Color.Red;
            tbModifyProductPrice.BackColor = Color.Red;
            l_Modify_ProductName.Visible = true;
            l_Modify_Price.Visible = true;
            l_Modify_ProductInventory.Visible = true;
            l_Modify_Max.Visible = true;
            l_Modify_Min.Visible = true;
        }
    }
}
