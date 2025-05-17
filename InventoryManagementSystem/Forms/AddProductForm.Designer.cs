namespace InventoryManagementSystem.Forms
{
    partial class AddProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cancelButton = new System.Windows.Forms.Button();
            this.pageTitleLabel = new System.Windows.Forms.Label();
            this.productMaxTextBox = new System.Windows.Forms.TextBox();
            this.productMaxLabel = new System.Windows.Forms.Label();
            this.productMinTextBox = new System.Windows.Forms.TextBox();
            this.productMinLabel = new System.Windows.Forms.Label();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productInventoryTextBox = new System.Windows.Forms.TextBox();
            this.productInventoryLabel = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.productIDLabel = new System.Windows.Forms.Label();
            this.partSearchText = new System.Windows.Forms.TextBox();
            this.PartSearchButton = new System.Windows.Forms.Button();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvAssociatedParts = new System.Windows.Forms.DataGridView();
            this.candidatePartsLabel = new System.Windows.Forms.Label();
            this.associatedProductLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(1684, 946);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(123, 55);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // pageTitleLabel
            // 
            this.pageTitleLabel.AutoSize = true;
            this.pageTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitleLabel.Location = new System.Drawing.Point(35, 67);
            this.pageTitleLabel.Name = "pageTitleLabel";
            this.pageTitleLabel.Size = new System.Drawing.Size(134, 29);
            this.pageTitleLabel.TabIndex = 12;
            this.pageTitleLabel.Text = "Page Title";
            // 
            // productMaxTextBox
            // 
            this.productMaxTextBox.Location = new System.Drawing.Point(413, 641);
            this.productMaxTextBox.Name = "productMaxTextBox";
            this.productMaxTextBox.Size = new System.Drawing.Size(85, 31);
            this.productMaxTextBox.TabIndex = 33;
            // 
            // productMaxLabel
            // 
            this.productMaxLabel.AutoSize = true;
            this.productMaxLabel.Location = new System.Drawing.Point(304, 641);
            this.productMaxLabel.Name = "productMaxLabel";
            this.productMaxLabel.Size = new System.Drawing.Size(53, 25);
            this.productMaxLabel.TabIndex = 37;
            this.productMaxLabel.Text = "Max";
            // 
            // productMinTextBox
            // 
            this.productMinTextBox.Location = new System.Drawing.Point(184, 644);
            this.productMinTextBox.Name = "productMinTextBox";
            this.productMinTextBox.Size = new System.Drawing.Size(85, 31);
            this.productMinTextBox.TabIndex = 32;
            // 
            // productMinLabel
            // 
            this.productMinLabel.AutoSize = true;
            this.productMinLabel.Location = new System.Drawing.Point(35, 647);
            this.productMinLabel.Name = "productMinLabel";
            this.productMinLabel.Size = new System.Drawing.Size(47, 25);
            this.productMinLabel.TabIndex = 36;
            this.productMinLabel.Text = "Min";
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Location = new System.Drawing.Point(184, 556);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(252, 31);
            this.productPriceTextBox.TabIndex = 30;
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Location = new System.Drawing.Point(35, 559);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(61, 25);
            this.productPriceLabel.TabIndex = 34;
            this.productPriceLabel.Text = "Price";
            // 
            // productInventoryTextBox
            // 
            this.productInventoryTextBox.Location = new System.Drawing.Point(184, 475);
            this.productInventoryTextBox.Name = "productInventoryTextBox";
            this.productInventoryTextBox.Size = new System.Drawing.Size(252, 31);
            this.productInventoryTextBox.TabIndex = 29;
            // 
            // productInventoryLabel
            // 
            this.productInventoryLabel.AutoSize = true;
            this.productInventoryLabel.Location = new System.Drawing.Point(35, 478);
            this.productInventoryLabel.Name = "productInventoryLabel";
            this.productInventoryLabel.Size = new System.Drawing.Size(100, 25);
            this.productInventoryLabel.TabIndex = 31;
            this.productInventoryLabel.Text = "Inventory";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(184, 401);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(252, 31);
            this.productNameTextBox.TabIndex = 27;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(35, 404);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(68, 25);
            this.productNameLabel.TabIndex = 28;
            this.productNameLabel.Text = "Name";
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.Location = new System.Drawing.Point(184, 321);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.ReadOnly = true;
            this.productIDTextBox.Size = new System.Drawing.Size(252, 31);
            this.productIDTextBox.TabIndex = 26;
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Location = new System.Drawing.Point(35, 321);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(32, 25);
            this.productIDLabel.TabIndex = 25;
            this.productIDLabel.Text = "ID";
            // 
            // partSearchText
            // 
            this.partSearchText.Location = new System.Drawing.Point(1410, 64);
            this.partSearchText.Name = "partSearchText";
            this.partSearchText.Size = new System.Drawing.Size(378, 31);
            this.partSearchText.TabIndex = 38;
            // 
            // PartSearchButton
            // 
            this.PartSearchButton.Location = new System.Drawing.Point(1282, 61);
            this.PartSearchButton.Name = "PartSearchButton";
            this.PartSearchButton.Size = new System.Drawing.Size(122, 37);
            this.PartSearchButton.TabIndex = 39;
            this.PartSearchButton.Text = "Search";
            this.PartSearchButton.UseVisualStyleBackColor = true;
            this.PartSearchButton.Click += new System.EventHandler(this.PartSearchButton_Click);
            // 
            // dgvParts
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParts.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvParts.Location = new System.Drawing.Point(610, 117);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.RowHeadersWidth = 82;
            this.dgvParts.RowTemplate.Height = 33;
            this.dgvParts.Size = new System.Drawing.Size(1197, 319);
            this.dgvParts.TabIndex = 40;
            this.dgvParts.TabStop = false;
            // 
            // dgvAssociatedParts
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssociatedParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssociatedParts.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvAssociatedParts.Location = new System.Drawing.Point(610, 563);
            this.dgvAssociatedParts.Name = "dgvAssociatedParts";
            this.dgvAssociatedParts.RowHeadersWidth = 82;
            this.dgvAssociatedParts.RowTemplate.Height = 33;
            this.dgvAssociatedParts.Size = new System.Drawing.Size(1197, 319);
            this.dgvAssociatedParts.TabIndex = 41;
            this.dgvAssociatedParts.TabStop = false;
            // 
            // candidatePartsLabel
            // 
            this.candidatePartsLabel.AutoSize = true;
            this.candidatePartsLabel.Location = new System.Drawing.Point(605, 67);
            this.candidatePartsLabel.Name = "candidatePartsLabel";
            this.candidatePartsLabel.Size = new System.Drawing.Size(192, 25);
            this.candidatePartsLabel.TabIndex = 42;
            this.candidatePartsLabel.Text = "All candidate Parts";
            // 
            // associatedProductLabel
            // 
            this.associatedProductLabel.AutoSize = true;
            this.associatedProductLabel.Location = new System.Drawing.Point(610, 518);
            this.associatedProductLabel.Name = "associatedProductLabel";
            this.associatedProductLabel.Size = new System.Drawing.Size(338, 25);
            this.associatedProductLabel.TabIndex = 43;
            this.associatedProductLabel.Text = "Parts Associated with this Product";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(1678, 453);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(129, 50);
            this.AddButton.TabIndex = 44;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(1532, 951);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(129, 50);
            this.DeleteButton.TabIndex = 45;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1379, 951);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(129, 50);
            this.SaveButton.TabIndex = 46;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1074);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.associatedProductLabel);
            this.Controls.Add(this.candidatePartsLabel);
            this.Controls.Add(this.dgvAssociatedParts);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.partSearchText);
            this.Controls.Add(this.PartSearchButton);
            this.Controls.Add(this.productMaxTextBox);
            this.Controls.Add(this.productMaxLabel);
            this.Controls.Add(this.productMinTextBox);
            this.Controls.Add(this.productMinLabel);
            this.Controls.Add(this.productPriceTextBox);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.productInventoryTextBox);
            this.Controls.Add(this.productInventoryLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(this.productIDLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.pageTitleLabel);
            this.Name = "AddProductForm";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label pageTitleLabel;
        private System.Windows.Forms.TextBox productMaxTextBox;
        private System.Windows.Forms.Label productMaxLabel;
        private System.Windows.Forms.TextBox productMinTextBox;
        private System.Windows.Forms.Label productMinLabel;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.TextBox productInventoryTextBox;
        private System.Windows.Forms.Label productInventoryLabel;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.TextBox partSearchText;
        private System.Windows.Forms.Button PartSearchButton;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvAssociatedParts;
        private System.Windows.Forms.Label candidatePartsLabel;
        private System.Windows.Forms.Label associatedProductLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
    }
}