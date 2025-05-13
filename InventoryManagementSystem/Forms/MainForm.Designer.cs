namespace InventoryManagementSystem
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pageTitleLabel = new System.Windows.Forms.Label();
            this.partsTableLabel = new System.Windows.Forms.Label();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.productsTableLabel = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.partSearchButton = new System.Windows.Forms.Button();
            this.productSearchButton = new System.Windows.Forms.Button();
            this.partSearchText = new System.Windows.Forms.TextBox();
            this.productSearchText = new System.Windows.Forms.TextBox();
            this.partAddButton = new System.Windows.Forms.Button();
            this.partModifyButton = new System.Windows.Forms.Button();
            this.partDeleteButton = new System.Windows.Forms.Button();
            this.productDeleteButton = new System.Windows.Forms.Button();
            this.productModifyButton = new System.Windows.Forms.Button();
            this.productAddButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // pageTitleLabel
            // 
            this.pageTitleLabel.AutoSize = true;
            this.pageTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitleLabel.Location = new System.Drawing.Point(28, 56);
            this.pageTitleLabel.Name = "pageTitleLabel";
            this.pageTitleLabel.Size = new System.Drawing.Size(134, 29);
            this.pageTitleLabel.TabIndex = 0;
            this.pageTitleLabel.Text = "Page Title";
            // 
            // partsTableLabel
            // 
            this.partsTableLabel.AutoSize = true;
            this.partsTableLabel.Location = new System.Drawing.Point(64, 151);
            this.partsTableLabel.Name = "partsTableLabel";
            this.partsTableLabel.Size = new System.Drawing.Size(62, 25);
            this.partsTableLabel.TabIndex = 0;
            this.partsTableLabel.Text = "Parts";
            // 
            // dgvParts
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParts.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvParts.Location = new System.Drawing.Point(69, 196);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.RowHeadersWidth = 82;
            this.dgvParts.RowTemplate.Height = 33;
            this.dgvParts.Size = new System.Drawing.Size(1197, 593);
            this.dgvParts.TabIndex = 2;
            this.dgvParts.TabStop = false;
            // 
            // productsTableLabel
            // 
            this.productsTableLabel.AutoSize = true;
            this.productsTableLabel.Location = new System.Drawing.Point(1302, 151);
            this.productsTableLabel.Name = "productsTableLabel";
            this.productsTableLabel.Size = new System.Drawing.Size(97, 25);
            this.productsTableLabel.TabIndex = 3;
            this.productsTableLabel.Text = "Products";
            // 
            // dgvProducts
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProducts.Location = new System.Drawing.Point(1307, 196);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 82;
            this.dgvProducts.RowTemplate.Height = 33;
            this.dgvProducts.Size = new System.Drawing.Size(1193, 593);
            this.dgvProducts.TabIndex = 4;
            this.dgvProducts.TabStop = false;
            // 
            // partSearchButton
            // 
            this.partSearchButton.Location = new System.Drawing.Point(937, 145);
            this.partSearchButton.Name = "partSearchButton";
            this.partSearchButton.Size = new System.Drawing.Size(122, 37);
            this.partSearchButton.TabIndex = 1;
            this.partSearchButton.Text = "Search";
            this.partSearchButton.UseVisualStyleBackColor = true;
            // 
            // productSearchButton
            // 
            this.productSearchButton.Location = new System.Drawing.Point(2178, 145);
            this.productSearchButton.Name = "productSearchButton";
            this.productSearchButton.Size = new System.Drawing.Size(114, 37);
            this.productSearchButton.TabIndex = 6;
            this.productSearchButton.Text = "Search";
            this.productSearchButton.UseVisualStyleBackColor = true;
            // 
            // partSearchText
            // 
            this.partSearchText.Location = new System.Drawing.Point(1075, 145);
            this.partSearchText.Name = "partSearchText";
            this.partSearchText.Size = new System.Drawing.Size(188, 31);
            this.partSearchText.TabIndex = 0;
            // 
            // productSearchText
            // 
            this.productSearchText.Location = new System.Drawing.Point(2312, 145);
            this.productSearchText.Name = "productSearchText";
            this.productSearchText.Size = new System.Drawing.Size(188, 31);
            this.productSearchText.TabIndex = 5;
            // 
            // partAddButton
            // 
            this.partAddButton.Location = new System.Drawing.Point(912, 811);
            this.partAddButton.Name = "partAddButton";
            this.partAddButton.Size = new System.Drawing.Size(107, 51);
            this.partAddButton.TabIndex = 2;
            this.partAddButton.Text = "Add";
            this.partAddButton.UseVisualStyleBackColor = true;
            this.partAddButton.Click += new System.EventHandler(this.PartAddButton_Click);
            // 
            // partModifyButton
            // 
            this.partModifyButton.Location = new System.Drawing.Point(1037, 811);
            this.partModifyButton.Name = "partModifyButton";
            this.partModifyButton.Size = new System.Drawing.Size(107, 51);
            this.partModifyButton.TabIndex = 3;
            this.partModifyButton.Text = "Modify";
            this.partModifyButton.UseVisualStyleBackColor = true;
            // 
            // partDeleteButton
            // 
            this.partDeleteButton.Location = new System.Drawing.Point(1160, 811);
            this.partDeleteButton.Name = "partDeleteButton";
            this.partDeleteButton.Size = new System.Drawing.Size(107, 51);
            this.partDeleteButton.TabIndex = 4;
            this.partDeleteButton.Text = "Delete";
            this.partDeleteButton.UseVisualStyleBackColor = true;
            // 
            // productDeleteButton
            // 
            this.productDeleteButton.Location = new System.Drawing.Point(2390, 811);
            this.productDeleteButton.Name = "productDeleteButton";
            this.productDeleteButton.Size = new System.Drawing.Size(107, 51);
            this.productDeleteButton.TabIndex = 9;
            this.productDeleteButton.Text = "Delete";
            this.productDeleteButton.UseVisualStyleBackColor = true;
            // 
            // productModifyButton
            // 
            this.productModifyButton.Location = new System.Drawing.Point(2267, 811);
            this.productModifyButton.Name = "productModifyButton";
            this.productModifyButton.Size = new System.Drawing.Size(107, 51);
            this.productModifyButton.TabIndex = 8;
            this.productModifyButton.Text = "Modify";
            this.productModifyButton.UseVisualStyleBackColor = true;
            // 
            // productAddButton
            // 
            this.productAddButton.Location = new System.Drawing.Point(2142, 811);
            this.productAddButton.Name = "productAddButton";
            this.productAddButton.Size = new System.Drawing.Size(107, 51);
            this.productAddButton.TabIndex = 7;
            this.productAddButton.Text = "Add";
            this.productAddButton.UseVisualStyleBackColor = true;
            this.productAddButton.Click += new System.EventHandler(this.ProductAddButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(2374, 936);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(123, 55);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2556, 1052);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.productDeleteButton);
            this.Controls.Add(this.productModifyButton);
            this.Controls.Add(this.productAddButton);
            this.Controls.Add(this.partDeleteButton);
            this.Controls.Add(this.partModifyButton);
            this.Controls.Add(this.partAddButton);
            this.Controls.Add(this.productSearchText);
            this.Controls.Add(this.partSearchText);
            this.Controls.Add(this.productSearchButton);
            this.Controls.Add(this.partSearchButton);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.productsTableLabel);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.partsTableLabel);
            this.Controls.Add(this.pageTitleLabel);
            this.Name = "MainForm";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pageTitleLabel;
        private System.Windows.Forms.Label partsTableLabel;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.Label productsTableLabel;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button partSearchButton;
        private System.Windows.Forms.Button productSearchButton;
        private System.Windows.Forms.TextBox partSearchText;
        private System.Windows.Forms.TextBox productSearchText;
        private System.Windows.Forms.Button partAddButton;
        private System.Windows.Forms.Button partModifyButton;
        private System.Windows.Forms.Button partDeleteButton;
        private System.Windows.Forms.Button productDeleteButton;
        private System.Windows.Forms.Button productModifyButton;
        private System.Windows.Forms.Button productAddButton;
        private System.Windows.Forms.Button exitButton;
    }
}

