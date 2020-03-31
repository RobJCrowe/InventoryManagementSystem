namespace Crowe_IMS
{
    partial class Form1
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
            this.btPartSearch = new System.Windows.Forms.Button();
            this.btProductSearch = new System.Windows.Forms.Button();
            this.tbPartSearch = new System.Windows.Forms.TextBox();
            this.tbProductSearch = new System.Windows.Forms.TextBox();
            this.dgvMainPart = new System.Windows.Forms.DataGridView();
            this.dgvMainProduct = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btPartDelete = new System.Windows.Forms.Button();
            this.btProductDelete = new System.Windows.Forms.Button();
            this.btPartModify = new System.Windows.Forms.Button();
            this.btProductModify = new System.Windows.Forms.Button();
            this.btPartAdd = new System.Windows.Forms.Button();
            this.btProductAdd = new System.Windows.Forms.Button();
            this.partCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.productCb = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runUnitTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventorySummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financialSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainProduct)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btPartSearch
            // 
            this.btPartSearch.Location = new System.Drawing.Point(256, 280);
            this.btPartSearch.Name = "btPartSearch";
            this.btPartSearch.Size = new System.Drawing.Size(75, 23);
            this.btPartSearch.TabIndex = 7;
            this.btPartSearch.Text = "Search";
            this.btPartSearch.UseVisualStyleBackColor = true;
            this.btPartSearch.Click += new System.EventHandler(this.btPartSearch_Click);
            // 
            // btProductSearch
            // 
            this.btProductSearch.Location = new System.Drawing.Point(259, 560);
            this.btProductSearch.Name = "btProductSearch";
            this.btProductSearch.Size = new System.Drawing.Size(75, 23);
            this.btProductSearch.TabIndex = 9;
            this.btProductSearch.Text = "Search";
            this.btProductSearch.UseVisualStyleBackColor = true;
            this.btProductSearch.Click += new System.EventHandler(this.btProductSearch_Click);
            // 
            // tbPartSearch
            // 
            this.tbPartSearch.Location = new System.Drawing.Point(337, 283);
            this.tbPartSearch.Name = "tbPartSearch";
            this.tbPartSearch.Size = new System.Drawing.Size(155, 20);
            this.tbPartSearch.TabIndex = 8;
            this.tbPartSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPartSearch_KeyDown);
            // 
            // tbProductSearch
            // 
            this.tbProductSearch.Location = new System.Drawing.Point(340, 562);
            this.tbProductSearch.Name = "tbProductSearch";
            this.tbProductSearch.Size = new System.Drawing.Size(155, 20);
            this.tbProductSearch.TabIndex = 10;
            this.tbProductSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbProductSearch_KeyDown);
            // 
            // dgvMainPart
            // 
            this.dgvMainPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainPart.Location = new System.Drawing.Point(13, 58);
            this.dgvMainPart.Name = "dgvMainPart";
            this.dgvMainPart.ReadOnly = true;
            this.dgvMainPart.Size = new System.Drawing.Size(775, 207);
            this.dgvMainPart.TabIndex = 11;
            this.dgvMainPart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMainPart_CellClick);
            // 
            // dgvMainProduct
            // 
            this.dgvMainProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainProduct.Location = new System.Drawing.Point(17, 347);
            this.dgvMainProduct.Name = "dgvMainProduct";
            this.dgvMainProduct.ReadOnly = true;
            this.dgvMainProduct.Size = new System.Drawing.Size(771, 207);
            this.dgvMainProduct.TabIndex = 12;
            this.dgvMainProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMainProduct_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Products";
            // 
            // btPartDelete
            // 
            this.btPartDelete.Location = new System.Drawing.Point(175, 281);
            this.btPartDelete.Name = "btPartDelete";
            this.btPartDelete.Size = new System.Drawing.Size(75, 23);
            this.btPartDelete.TabIndex = 2;
            this.btPartDelete.Text = "Delete";
            this.btPartDelete.UseVisualStyleBackColor = true;
            this.btPartDelete.Click += new System.EventHandler(this.btPartDelete_Click);
            // 
            // btProductDelete
            // 
            this.btProductDelete.Location = new System.Drawing.Point(178, 560);
            this.btProductDelete.Name = "btProductDelete";
            this.btProductDelete.Size = new System.Drawing.Size(75, 23);
            this.btProductDelete.TabIndex = 5;
            this.btProductDelete.Text = "Delete";
            this.btProductDelete.UseVisualStyleBackColor = true;
            this.btProductDelete.Click += new System.EventHandler(this.btProductDelete_Click);
            // 
            // btPartModify
            // 
            this.btPartModify.Location = new System.Drawing.Point(94, 281);
            this.btPartModify.Name = "btPartModify";
            this.btPartModify.Size = new System.Drawing.Size(75, 23);
            this.btPartModify.TabIndex = 1;
            this.btPartModify.Text = "Modify";
            this.btPartModify.UseVisualStyleBackColor = true;
            this.btPartModify.Click += new System.EventHandler(this.btPartModify_Click);
            // 
            // btProductModify
            // 
            this.btProductModify.Location = new System.Drawing.Point(97, 560);
            this.btProductModify.Name = "btProductModify";
            this.btProductModify.Size = new System.Drawing.Size(75, 23);
            this.btProductModify.TabIndex = 4;
            this.btProductModify.Text = "Modify";
            this.btProductModify.UseVisualStyleBackColor = true;
            this.btProductModify.Click += new System.EventHandler(this.btProductModify_Click);
            // 
            // btPartAdd
            // 
            this.btPartAdd.Location = new System.Drawing.Point(13, 281);
            this.btPartAdd.Name = "btPartAdd";
            this.btPartAdd.Size = new System.Drawing.Size(75, 23);
            this.btPartAdd.TabIndex = 0;
            this.btPartAdd.Text = "Add";
            this.btPartAdd.UseVisualStyleBackColor = true;
            this.btPartAdd.Click += new System.EventHandler(this.btPartAdd_Click);
            // 
            // btProductAdd
            // 
            this.btProductAdd.Location = new System.Drawing.Point(16, 560);
            this.btProductAdd.Name = "btProductAdd";
            this.btProductAdd.Size = new System.Drawing.Size(75, 23);
            this.btProductAdd.TabIndex = 3;
            this.btProductAdd.Text = "Add";
            this.btProductAdd.UseVisualStyleBackColor = true;
            this.btProductAdd.Click += new System.EventHandler(this.btProductAdd_Click);
            // 
            // partCb
            // 
            this.partCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partCb.FormattingEnabled = true;
            this.partCb.Items.AddRange(new object[] {
            "All",
            "Details",
            "Instock",
            "LastModified",
            "Max",
            "Min",
            "Name",
            "PartId",
            "Price",
            "Type"});
            this.partCb.Location = new System.Drawing.Point(622, 281);
            this.partCb.Name = "partCb";
            this.partCb.Size = new System.Drawing.Size(121, 21);
            this.partCb.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(498, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "SEARCH FILTER:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(501, 565);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "SEARCH FILTER:";
            // 
            // productCb
            // 
            this.productCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productCb.FormattingEnabled = true;
            this.productCb.Items.AddRange(new object[] {
            "All",
            "Instock",
            "LastModified",
            "Max",
            "Min",
            "Name",
            "Price",
            "ProductId"});
            this.productCb.Location = new System.Drawing.Point(615, 562);
            this.productCb.Name = "productCb";
            this.productCb.Size = new System.Drawing.Size(121, 21);
            this.productCb.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 29);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runUnitTestsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // runUnitTestsToolStripMenuItem
            // 
            this.runUnitTestsToolStripMenuItem.Name = "runUnitTestsToolStripMenuItem";
            this.runUnitTestsToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.runUnitTestsToolStripMenuItem.Text = "Run unit tests";
            this.runUnitTestsToolStripMenuItem.Click += new System.EventHandler(this.runUnitTestsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventorySummaryToolStripMenuItem,
            this.financialSummaryToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // inventorySummaryToolStripMenuItem
            // 
            this.inventorySummaryToolStripMenuItem.Name = "inventorySummaryToolStripMenuItem";
            this.inventorySummaryToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.inventorySummaryToolStripMenuItem.Text = "User Item Summary";
            this.inventorySummaryToolStripMenuItem.Click += new System.EventHandler(this.inventorySummaryToolStripMenuItem_Click);
            // 
            // financialSummaryToolStripMenuItem
            // 
            this.financialSummaryToolStripMenuItem.Name = "financialSummaryToolStripMenuItem";
            this.financialSummaryToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.financialSummaryToolStripMenuItem.Text = "Inventory Financials";
            this.financialSummaryToolStripMenuItem.Click += new System.EventHandler(this.financialSummaryToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 660);
            this.Controls.Add(this.productCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.partCb);
            this.Controls.Add(this.btProductAdd);
            this.Controls.Add(this.btPartAdd);
            this.Controls.Add(this.btProductModify);
            this.Controls.Add(this.btPartModify);
            this.Controls.Add(this.btProductDelete);
            this.Controls.Add(this.btPartDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMainProduct);
            this.Controls.Add(this.dgvMainPart);
            this.Controls.Add(this.tbProductSearch);
            this.Controls.Add(this.tbPartSearch);
            this.Controls.Add(this.btProductSearch);
            this.Controls.Add(this.btPartSearch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Inventory Management System";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainProduct)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btPartSearch;
        private System.Windows.Forms.Button btProductSearch;
        private System.Windows.Forms.TextBox tbPartSearch;
        private System.Windows.Forms.TextBox tbProductSearch;
        private System.Windows.Forms.DataGridView dgvMainPart;
        private System.Windows.Forms.DataGridView dgvMainProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btPartDelete;
        private System.Windows.Forms.Button btProductDelete;
        private System.Windows.Forms.Button btPartModify;
        private System.Windows.Forms.Button btProductModify;
        private System.Windows.Forms.Button btPartAdd;
        private System.Windows.Forms.Button btProductAdd;
        private System.Windows.Forms.ComboBox partCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox productCb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runUnitTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventorySummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financialSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

