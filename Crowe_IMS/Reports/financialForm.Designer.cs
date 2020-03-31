namespace Crowe_IMS
{
    partial class financialForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.rbParts = new System.Windows.Forms.RadioButton();
            this.rbProducts = new System.Windows.Forms.RadioButton();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.lbCount = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbGrandTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbParts
            // 
            this.rbParts.AutoSize = true;
            this.rbParts.Checked = true;
            this.rbParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbParts.Location = new System.Drawing.Point(22, 25);
            this.rbParts.Name = "rbParts";
            this.rbParts.Size = new System.Drawing.Size(64, 24);
            this.rbParts.TabIndex = 1;
            this.rbParts.TabStop = true;
            this.rbParts.Text = "Parts";
            this.rbParts.UseVisualStyleBackColor = true;
            this.rbParts.CheckedChanged += new System.EventHandler(this.rbParts_CheckedChanged);
            // 
            // rbProducts
            // 
            this.rbProducts.AutoSize = true;
            this.rbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProducts.Location = new System.Drawing.Point(22, 55);
            this.rbProducts.Name = "rbProducts";
            this.rbProducts.Size = new System.Drawing.Size(90, 24);
            this.rbProducts.TabIndex = 2;
            this.rbProducts.Text = "Products";
            this.rbProducts.UseVisualStyleBackColor = true;
            this.rbProducts.CheckedChanged += new System.EventHandler(this.rbProducts_CheckedChanged);
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.AllowUserToAddRows = false;
            this.dgvDisplay.AllowUserToDeleteRows = false;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(22, 114);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.ReadOnly = true;
            this.dgvDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDisplay.Size = new System.Drawing.Size(421, 517);
            this.dgvDisplay.TabIndex = 3;
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCount.Location = new System.Drawing.Point(182, 27);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(185, 20);
            this.lbCount.TabIndex = 4;
            this.lbCount.Text = "Total # of selected items:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(154, 47);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(213, 20);
            this.lbTotal.TabIndex = 5;
            this.lbTotal.Text = "Total value of selected items:";
            // 
            // lbGrandTotal
            // 
            this.lbGrandTotal.AutoSize = true;
            this.lbGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrandTotal.Location = new System.Drawing.Point(138, 67);
            this.lbGrandTotal.Name = "lbGrandTotal";
            this.lbGrandTotal.Size = new System.Drawing.Size(230, 20);
            this.lbGrandTotal.TabIndex = 6;
            this.lbGrandTotal.Text = "Grand total parts and products:";
            // 
            // financialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 657);
            this.Controls.Add(this.lbGrandTotal);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.dgvDisplay);
            this.Controls.Add(this.rbProducts);
            this.Controls.Add(this.rbParts);
            this.Controls.Add(this.button1);
            this.Name = "financialForm";
            this.Text = "Finance Report";
            this.Load += new System.EventHandler(this.financialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbParts;
        private System.Windows.Forms.RadioButton rbProducts;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbGrandTotal;
    }
}