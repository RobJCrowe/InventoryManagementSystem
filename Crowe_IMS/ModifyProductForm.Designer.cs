namespace Crowe_IMS
{
    partial class ModifyProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btModifyProductSave = new System.Windows.Forms.Button();
            this.btModifyProductCancel = new System.Windows.Forms.Button();
            this.btModifyProductDelete = new System.Windows.Forms.Button();
            this.btModifyProductAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvModifyProductAddParts = new System.Windows.Forms.DataGridView();
            this.dgvModifyProductAllParts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbModifyProductMin = new System.Windows.Forms.TextBox();
            this.tbModifyProductMax = new System.Windows.Forms.TextBox();
            this.tbModifyProductPrice = new System.Windows.Forms.TextBox();
            this.tbModifyProductInventory = new System.Windows.Forms.TextBox();
            this.tbModifyProductName = new System.Windows.Forms.TextBox();
            this.tbModifyProductID = new System.Windows.Forms.TextBox();
            this.l_Modify_Min = new System.Windows.Forms.Label();
            this.l_Modify_Max = new System.Windows.Forms.Label();
            this.l_Modify_Price = new System.Windows.Forms.Label();
            this.l_Modify_ProductInventory = new System.Windows.Forms.Label();
            this.l_Modify_ProductName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifyProductAddParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifyProductAllParts)).BeginInit();
            this.SuspendLayout();
            // 
            // btModifyProductSave
            // 
            this.btModifyProductSave.Location = new System.Drawing.Point(755, 524);
            this.btModifyProductSave.Name = "btModifyProductSave";
            this.btModifyProductSave.Size = new System.Drawing.Size(75, 23);
            this.btModifyProductSave.TabIndex = 5;
            this.btModifyProductSave.Text = "Save";
            this.btModifyProductSave.UseVisualStyleBackColor = true;
            this.btModifyProductSave.Click += new System.EventHandler(this.btModifyProductSave_Click);
            // 
            // btModifyProductCancel
            // 
            this.btModifyProductCancel.Location = new System.Drawing.Point(836, 524);
            this.btModifyProductCancel.Name = "btModifyProductCancel";
            this.btModifyProductCancel.Size = new System.Drawing.Size(75, 23);
            this.btModifyProductCancel.TabIndex = 6;
            this.btModifyProductCancel.Text = "Cancel";
            this.btModifyProductCancel.UseVisualStyleBackColor = true;
            this.btModifyProductCancel.Click += new System.EventHandler(this.btModifyProductCancel_Click);
            // 
            // btModifyProductDelete
            // 
            this.btModifyProductDelete.Location = new System.Drawing.Point(795, 495);
            this.btModifyProductDelete.Name = "btModifyProductDelete";
            this.btModifyProductDelete.Size = new System.Drawing.Size(75, 23);
            this.btModifyProductDelete.TabIndex = 10;
            this.btModifyProductDelete.Text = "Delete";
            this.btModifyProductDelete.UseVisualStyleBackColor = true;
            this.btModifyProductDelete.Click += new System.EventHandler(this.btModifyProductDelete_Click);
            // 
            // btModifyProductAdd
            // 
            this.btModifyProductAdd.Location = new System.Drawing.Point(795, 271);
            this.btModifyProductAdd.Name = "btModifyProductAdd";
            this.btModifyProductAdd.Size = new System.Drawing.Size(75, 23);
            this.btModifyProductAdd.TabIndex = 9;
            this.btModifyProductAdd.Text = "Add";
            this.btModifyProductAdd.UseVisualStyleBackColor = true;
            this.btModifyProductAdd.Click += new System.EventHandler(this.btModifyProductAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(355, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "Parts Associated with this Product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "All candidate Parts";
            // 
            // dgvModifyProductAddParts
            // 
            this.dgvModifyProductAddParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModifyProductAddParts.Location = new System.Drawing.Point(358, 308);
            this.dgvModifyProductAddParts.Name = "dgvModifyProductAddParts";
            this.dgvModifyProductAddParts.ReadOnly = true;
            this.dgvModifyProductAddParts.Size = new System.Drawing.Size(553, 181);
            this.dgvModifyProductAddParts.TabIndex = 72;
            this.dgvModifyProductAddParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModifyProductAddParts_CellClick);
            // 
            // dgvModifyProductAllParts
            // 
            this.dgvModifyProductAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModifyProductAllParts.Location = new System.Drawing.Point(358, 81);
            this.dgvModifyProductAllParts.Name = "dgvModifyProductAllParts";
            this.dgvModifyProductAllParts.ReadOnly = true;
            this.dgvModifyProductAllParts.Size = new System.Drawing.Size(553, 181);
            this.dgvModifyProductAllParts.TabIndex = 71;
            this.dgvModifyProductAllParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModifyProductAllParts_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 70;
            this.label1.Text = "Modify Product";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(214, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Price / Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "ID";
            // 
            // tbModifyProductMin
            // 
            this.tbModifyProductMin.Location = new System.Drawing.Point(267, 268);
            this.tbModifyProductMin.Name = "tbModifyProductMin";
            this.tbModifyProductMin.Size = new System.Drawing.Size(68, 20);
            this.tbModifyProductMin.TabIndex = 4;
            this.tbModifyProductMin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbModifyProductMin_KeyUp);
            // 
            // tbModifyProductMax
            // 
            this.tbModifyProductMax.Location = new System.Drawing.Point(126, 268);
            this.tbModifyProductMax.Name = "tbModifyProductMax";
            this.tbModifyProductMax.Size = new System.Drawing.Size(68, 20);
            this.tbModifyProductMax.TabIndex = 3;
            this.tbModifyProductMax.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbModifyProductMax_KeyUp);
            // 
            // tbModifyProductPrice
            // 
            this.tbModifyProductPrice.Location = new System.Drawing.Point(126, 242);
            this.tbModifyProductPrice.Name = "tbModifyProductPrice";
            this.tbModifyProductPrice.Size = new System.Drawing.Size(142, 20);
            this.tbModifyProductPrice.TabIndex = 2;
            this.tbModifyProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbModifyProductPrice_KeyPress);
            this.tbModifyProductPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbModifyProductPrice_KeyUp);
            // 
            // tbModifyProductInventory
            // 
            this.tbModifyProductInventory.Location = new System.Drawing.Point(126, 216);
            this.tbModifyProductInventory.Name = "tbModifyProductInventory";
            this.tbModifyProductInventory.Size = new System.Drawing.Size(142, 20);
            this.tbModifyProductInventory.TabIndex = 1;
            this.tbModifyProductInventory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbModifyProductInventory_KeyUp);
            // 
            // tbModifyProductName
            // 
            this.tbModifyProductName.Location = new System.Drawing.Point(126, 190);
            this.tbModifyProductName.Name = "tbModifyProductName";
            this.tbModifyProductName.Size = new System.Drawing.Size(142, 20);
            this.tbModifyProductName.TabIndex = 0;
            this.tbModifyProductName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbModifyProductName_KeyUp);
            // 
            // tbModifyProductID
            // 
            this.tbModifyProductID.Location = new System.Drawing.Point(126, 164);
            this.tbModifyProductID.Name = "tbModifyProductID";
            this.tbModifyProductID.ReadOnly = true;
            this.tbModifyProductID.Size = new System.Drawing.Size(142, 20);
            this.tbModifyProductID.TabIndex = 58;
            // 
            // l_Modify_Min
            // 
            this.l_Modify_Min.AutoSize = true;
            this.l_Modify_Min.ForeColor = System.Drawing.Color.Red;
            this.l_Modify_Min.Location = new System.Drawing.Point(24, 404);
            this.l_Modify_Min.Name = "l_Modify_Min";
            this.l_Modify_Min.Size = new System.Drawing.Size(171, 13);
            this.l_Modify_Min.TabIndex = 79;
            this.l_Modify_Min.Text = "Please enter an integer for the min.";
            this.l_Modify_Min.Visible = false;
            // 
            // l_Modify_Max
            // 
            this.l_Modify_Max.AutoSize = true;
            this.l_Modify_Max.ForeColor = System.Drawing.Color.Red;
            this.l_Modify_Max.Location = new System.Drawing.Point(24, 383);
            this.l_Modify_Max.Name = "l_Modify_Max";
            this.l_Modify_Max.Size = new System.Drawing.Size(174, 13);
            this.l_Modify_Max.TabIndex = 78;
            this.l_Modify_Max.Text = "Please enter an integer for the max.";
            this.l_Modify_Max.Visible = false;
            // 
            // l_Modify_Price
            // 
            this.l_Modify_Price.AutoSize = true;
            this.l_Modify_Price.ForeColor = System.Drawing.Color.Red;
            this.l_Modify_Price.Location = new System.Drawing.Point(24, 360);
            this.l_Modify_Price.Name = "l_Modify_Price";
            this.l_Modify_Price.Size = new System.Drawing.Size(215, 13);
            this.l_Modify_Price.TabIndex = 77;
            this.l_Modify_Price.Text = "Please specify an amount in the format xx.xx";
            this.l_Modify_Price.Visible = false;
            // 
            // l_Modify_ProductInventory
            // 
            this.l_Modify_ProductInventory.AutoSize = true;
            this.l_Modify_ProductInventory.ForeColor = System.Drawing.Color.Red;
            this.l_Modify_ProductInventory.Location = new System.Drawing.Point(24, 334);
            this.l_Modify_ProductInventory.Name = "l_Modify_ProductInventory";
            this.l_Modify_ProductInventory.Size = new System.Drawing.Size(169, 13);
            this.l_Modify_ProductInventory.TabIndex = 76;
            this.l_Modify_ProductInventory.Text = "Inventory: Please enter an integer.";
            this.l_Modify_ProductInventory.Visible = false;
            // 
            // l_Modify_ProductName
            // 
            this.l_Modify_ProductName.AutoSize = true;
            this.l_Modify_ProductName.ForeColor = System.Drawing.Color.Red;
            this.l_Modify_ProductName.Location = new System.Drawing.Point(24, 308);
            this.l_Modify_ProductName.Name = "l_Modify_ProductName";
            this.l_Modify_ProductName.Size = new System.Drawing.Size(154, 13);
            this.l_Modify_ProductName.TabIndex = 75;
            this.l_Modify_ProductName.Text = "Please input a name as a string";
            this.l_Modify_ProductName.Visible = false;
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 561);
            this.Controls.Add(this.l_Modify_Min);
            this.Controls.Add(this.l_Modify_Max);
            this.Controls.Add(this.l_Modify_Price);
            this.Controls.Add(this.l_Modify_ProductInventory);
            this.Controls.Add(this.l_Modify_ProductName);
            this.Controls.Add(this.btModifyProductSave);
            this.Controls.Add(this.btModifyProductCancel);
            this.Controls.Add(this.btModifyProductDelete);
            this.Controls.Add(this.btModifyProductAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvModifyProductAddParts);
            this.Controls.Add(this.dgvModifyProductAllParts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbModifyProductMin);
            this.Controls.Add(this.tbModifyProductMax);
            this.Controls.Add(this.tbModifyProductPrice);
            this.Controls.Add(this.tbModifyProductInventory);
            this.Controls.Add(this.tbModifyProductName);
            this.Controls.Add(this.tbModifyProductID);
            this.Name = "ModifyProductForm";
            this.Text = "Modify Product Form";
            this.Load += new System.EventHandler(this.ModifyProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifyProductAddParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifyProductAllParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btModifyProductSave;
        private System.Windows.Forms.Button btModifyProductCancel;
        private System.Windows.Forms.Button btModifyProductDelete;
        private System.Windows.Forms.Button btModifyProductAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvModifyProductAddParts;
        private System.Windows.Forms.DataGridView dgvModifyProductAllParts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbModifyProductMin;
        private System.Windows.Forms.TextBox tbModifyProductMax;
        private System.Windows.Forms.TextBox tbModifyProductPrice;
        private System.Windows.Forms.TextBox tbModifyProductInventory;
        private System.Windows.Forms.TextBox tbModifyProductName;
        private System.Windows.Forms.TextBox tbModifyProductID;
        private System.Windows.Forms.Label l_Modify_Min;
        private System.Windows.Forms.Label l_Modify_Max;
        private System.Windows.Forms.Label l_Modify_Price;
        private System.Windows.Forms.Label l_Modify_ProductInventory;
        private System.Windows.Forms.Label l_Modify_ProductName;
    }
}