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
    public partial class ModifyPartForm : Form
    {
        int intParse;
        int partId;
        partsdb modify = new partsdb();
        partsdb newPart = new partsdb();
        Form1 test;
        bool isPart = false;

        public ModifyPartForm(Form1 pform) : this()
        {
            test = pform;
            isPart = true;
        }

        public ModifyPartForm(Form1 pform, int index) : this()
        {
            test = pform;
            partId = index;
        }

        public ModifyPartForm() { InitializeComponent(); }

        private void btAddPartCancel_Click(object sender, EventArgs e)
        {
            test.Show(); this.Close();
        }

        private void ModifyPartForm_Load(object sender, EventArgs e)
        {
            if (isPart)
            {
                label1.Text = "Add Part"; this.Text = "Add Part Form";
                setColors();
                return;
            }

            label1.Text = "Modify Part"; this.Text = "Modify Part Form";
            modify = dbHelper.GetPart(partId);

            if (modify != null)
            {
                newPart.type = modify.type;
                if (modify.createdby != null) { newPart.createdby = modify.createdby; }

                tbModifyPartID.Text = Convert.ToString(modify.partid);
                tbModifyPartName.Text = modify.name;
                tbModifyPartPrice.Text = modify.price.ToString("#,0.00");
                tbModifyPartInventory.Text = Convert.ToString(modify.instock);
                tbModifyPartMax.Text = Convert.ToString(modify.max);
                tbModifyPartMin.Text = Convert.ToString(modify.min);
                if (modify.type == "i")
                {
                    rdbModifyPartInHouse.Checked = true;
                    tbModifyPartMachineIdCompanyName.Text = Convert.ToString(modify.details);
                }
                if (modify.type == "o")
                {
                    rdbModifyPartOutsourced.Checked = true;
                    tbModifyPartMachineIdCompanyName.Text = Convert.ToString(modify.details);
                }
            }
        }

        private void setColors()
        {
            tbModifyPartName.BackColor = Color.Red;
            tbModifyPartPrice.BackColor = Color.Red;
            tbModifyPartInventory.BackColor = Color.Red;
            tbModifyPartMin.BackColor = Color.Red;
            tbModifyPartMax.BackColor = Color.Red;
            tbModifyPartMachineIdCompanyName.BackColor = Color.Red;

            l_Modify_PartName.Visible = true;
            l_Modify_Price.Visible = true;
            l_Modify_PartInventory.Visible = true;
            l_Modify_Min.Visible = true;
            l_Modify_Max.Visible = true;
            l_Modify_MachineIDName.Visible = true;
        }
        private void btAddPartSave_Click(object sender, EventArgs e)
        {
            if (l_Modify_PartName.Visible == true || l_Modify_Price.Visible == true || l_Modify_PartInventory.Visible == true || l_Modify_Max.Visible == true || l_Modify_Min.Visible == true || l_Modify_MachineIDName.Visible == true)
            {
                MessageBox.Show("You must fix the red boxes before you can save."); 
                return;
            }

            if (Int32.Parse(tbModifyPartMax.Text) <= Int32.Parse(tbModifyPartMin.Text))
            {
                MessageBox.Show("Max must be greater than Min.");
                return;
            }
            if ((Int32.Parse(tbModifyPartInventory.Text) <= Int32.Parse(tbModifyPartMin.Text)) || (Int32.Parse(tbModifyPartInventory.Text) >= Int32.Parse(tbModifyPartMax.Text)))
            {
                MessageBox.Show("Inventory must be greater than min and less than max.");
                return;
            }
            if (isPart)
            {
                partsdb tempPart = new partsdb();
                tempPart.createdby = dbHelper.currentUser.userid;
                tempPart.name = tbModifyPartName.Text;
                tempPart.price = Decimal.Parse(tbModifyPartPrice.Text);
                tempPart.instock = Int32.Parse(tbModifyPartInventory.Text);
                tempPart.min = Int32.Parse(tbModifyPartMin.Text);
                tempPart.max = Int32.Parse(tbModifyPartMax.Text);
                tempPart.details = tbModifyPartMachineIdCompanyName.Text;
                tempPart.lastmodified = DateTime.Now;
                tempPart.type = rdbModifyPartInHouse.Checked ? "i" : "o";
                dbHelper.AddPart(tempPart);
            }
            else
            {
                BuildPart();
                if (IsSame())
                {
                    MessageBox.Show("You haven't modified any part details", "Warning");
                    return;
                }
                dbHelper.UpdatePart(newPart);
            }

            test.Show();
            this.Close(); ;
        }

        private void tbModifyPartName_KeyUp(object sender, KeyEventArgs e)
        {
            hasText(tbModifyPartName, l_Modify_PartName);
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

        private void tbModifyPartPrice_KeyUp(object sender, KeyEventArgs e)
        {
            hasText(tbModifyPartPrice, l_Modify_Price);
            checkDecimal(tbModifyPartPrice, l_Modify_Price);
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

        private void tbModifyPartInventory_KeyUp(object sender, KeyEventArgs e)
        {
            validateInt(tbModifyPartInventory, l_Modify_PartInventory);
        }

        private void tbModifyPartMax_KeyUp(object sender, KeyEventArgs e)
        {
            validateInt(tbModifyPartMax, l_Modify_Max);
        }

        private void tbModifyPartMin_KeyUp(object sender, KeyEventArgs e)
        {
            validateInt(tbModifyPartMin, l_Modify_Min);
        }

        private void tbModifyPartMachineIdCompanyName_KeyUp(object sender, KeyEventArgs e)
        {
            hasText(tbModifyPartMachineIdCompanyName, l_Modify_MachineIDName);
            if (rdbModifyPartInHouse.Checked == true)
            {
                validateInt(tbModifyPartMachineIdCompanyName, l_Modify_MachineIDName);
                return;
            }
        }

        private void rdbModifyPartInHouse_Click(object sender, EventArgs e)
        {
                hasText(tbModifyPartMachineIdCompanyName, l_Modify_MachineIDName);
                validateInt(tbModifyPartMachineIdCompanyName, l_Modify_MachineIDName);
        }

        private void rdbModifyPartOutsourced_Click(object sender, EventArgs e)
        {
                hasText(tbModifyPartMachineIdCompanyName, l_Modify_MachineIDName);
        }

        private void BuildPart()
        {
            newPart.partid = modify.partid;
            newPart.name = tbModifyPartName.Text;
            newPart.instock = Int32.Parse(tbModifyPartInventory.Text);
            newPart.min = Int32.Parse(tbModifyPartMin.Text);
            newPart.max = Int32.Parse(tbModifyPartMax.Text);
            newPart.price = Decimal.Parse(tbModifyPartPrice.Text);
            newPart.details = tbModifyPartMachineIdCompanyName.Text;
        }

        private bool IsSame()
        {
            if ((modify.name == newPart.name) && (modify.instock == newPart.instock) && (modify.min == newPart.min) && (modify.max == newPart.max)
                && (modify.type == newPart.type) && (modify.details == newPart.details) && (modify.price.ToString("#,0.00") == tbModifyPartPrice.Text)) return true;
            else { return false; }
        }

        private void rdbModifyPartInHouse_CheckedChanged(object sender, EventArgs e)
        {
            lbAddPartMachineIdCompanyName.Text = "Machine ID";
            newPart.type = "i";
        }

        private void rdbModifyPartOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            lbAddPartMachineIdCompanyName.Text = "Company Name";
            newPart.type = "o";
        }

        private void tbModifyPartPrice_KeyPress(object sender, KeyPressEventArgs e)
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

    }
}

