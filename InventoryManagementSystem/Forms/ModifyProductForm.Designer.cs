namespace InventoryManagementSystem.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.associatedProductLabel = new System.Windows.Forms.Label();
            this.candidatePartsLabel = new System.Windows.Forms.Label();
            this.dgvAssociatedParts = new System.Windows.Forms.DataGridView();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.partSearchText = new System.Windows.Forms.TextBox();
            this.PartSearchButton = new System.Windows.Forms.Button();
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.pageTitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1555, 916);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(129, 50);
            this.SaveButton.TabIndex = 69;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(1708, 916);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(129, 50);
            this.DeleteButton.TabIndex = 68;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(1855, 421);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(129, 50);
            this.AddButton.TabIndex = 67;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // associatedProductLabel
            // 
            this.associatedProductLabel.AutoSize = true;
            this.associatedProductLabel.Location = new System.Drawing.Point(627, 483);
            this.associatedProductLabel.Name = "associatedProductLabel";
            this.associatedProductLabel.Size = new System.Drawing.Size(338, 25);
            this.associatedProductLabel.TabIndex = 66;
            this.associatedProductLabel.Text = "Parts Associated with this Product";
            // 
            // candidatePartsLabel
            // 
            this.candidatePartsLabel.AutoSize = true;
            this.candidatePartsLabel.Location = new System.Drawing.Point(622, 32);
            this.candidatePartsLabel.Name = "candidatePartsLabel";
            this.candidatePartsLabel.Size = new System.Drawing.Size(192, 25);
            this.candidatePartsLabel.TabIndex = 65;
            this.candidatePartsLabel.Text = "All candidate Parts";
            // 
            // dgvAssociatedParts
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssociatedParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssociatedParts.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAssociatedParts.Location = new System.Drawing.Point(627, 528);
            this.dgvAssociatedParts.Name = "dgvAssociatedParts";
            this.dgvAssociatedParts.RowHeadersWidth = 82;
            this.dgvAssociatedParts.RowTemplate.Height = 33;
            this.dgvAssociatedParts.Size = new System.Drawing.Size(1357, 319);
            this.dgvAssociatedParts.TabIndex = 64;
            this.dgvAssociatedParts.TabStop = false;
            // 
            // dgvParts
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParts.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvParts.Location = new System.Drawing.Point(627, 82);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.RowHeadersWidth = 82;
            this.dgvParts.RowTemplate.Height = 33;
            this.dgvParts.Size = new System.Drawing.Size(1357, 319);
            this.dgvParts.TabIndex = 63;
            this.dgvParts.TabStop = false;
            // 
            // partSearchText
            // 
            this.partSearchText.Location = new System.Drawing.Point(1607, 29);
            this.partSearchText.Name = "partSearchText";
            this.partSearchText.Size = new System.Drawing.Size(378, 31);
            this.partSearchText.TabIndex = 61;
            // 
            // PartSearchButton
            // 
            this.PartSearchButton.Location = new System.Drawing.Point(1479, 26);
            this.PartSearchButton.Name = "PartSearchButton";
            this.PartSearchButton.Size = new System.Drawing.Size(122, 37);
            this.PartSearchButton.TabIndex = 62;
            this.PartSearchButton.Text = "Search";
            this.PartSearchButton.UseVisualStyleBackColor = true;
            this.PartSearchButton.Click += new System.EventHandler(this.PartSearchButton_Click);
            // 
            // productMaxTextBox
            // 
            this.productMaxTextBox.Location = new System.Drawing.Point(430, 606);
            this.productMaxTextBox.Name = "productMaxTextBox";
            this.productMaxTextBox.Size = new System.Drawing.Size(85, 31);
            this.productMaxTextBox.TabIndex = 57;
            // 
            // productMaxLabel
            // 
            this.productMaxLabel.AutoSize = true;
            this.productMaxLabel.Location = new System.Drawing.Point(321, 606);
            this.productMaxLabel.Name = "productMaxLabel";
            this.productMaxLabel.Size = new System.Drawing.Size(53, 25);
            this.productMaxLabel.TabIndex = 60;
            this.productMaxLabel.Text = "Max";
            // 
            // productMinTextBox
            // 
            this.productMinTextBox.Location = new System.Drawing.Point(201, 609);
            this.productMinTextBox.Name = "productMinTextBox";
            this.productMinTextBox.Size = new System.Drawing.Size(85, 31);
            this.productMinTextBox.TabIndex = 56;
            // 
            // productMinLabel
            // 
            this.productMinLabel.AutoSize = true;
            this.productMinLabel.Location = new System.Drawing.Point(52, 612);
            this.productMinLabel.Name = "productMinLabel";
            this.productMinLabel.Size = new System.Drawing.Size(47, 25);
            this.productMinLabel.TabIndex = 59;
            this.productMinLabel.Text = "Min";
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Location = new System.Drawing.Point(201, 521);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(252, 31);
            this.productPriceTextBox.TabIndex = 54;
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Location = new System.Drawing.Point(52, 524);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(61, 25);
            this.productPriceLabel.TabIndex = 58;
            this.productPriceLabel.Text = "Price";
            // 
            // productInventoryTextBox
            // 
            this.productInventoryTextBox.Location = new System.Drawing.Point(201, 440);
            this.productInventoryTextBox.Name = "productInventoryTextBox";
            this.productInventoryTextBox.Size = new System.Drawing.Size(252, 31);
            this.productInventoryTextBox.TabIndex = 53;
            // 
            // productInventoryLabel
            // 
            this.productInventoryLabel.AutoSize = true;
            this.productInventoryLabel.Location = new System.Drawing.Point(52, 443);
            this.productInventoryLabel.Name = "productInventoryLabel";
            this.productInventoryLabel.Size = new System.Drawing.Size(100, 25);
            this.productInventoryLabel.TabIndex = 55;
            this.productInventoryLabel.Text = "Inventory";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(201, 366);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(252, 31);
            this.productNameTextBox.TabIndex = 51;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(52, 369);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(68, 25);
            this.productNameLabel.TabIndex = 52;
            this.productNameLabel.Text = "Name";
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.Location = new System.Drawing.Point(201, 286);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.ReadOnly = true;
            this.productIDTextBox.Size = new System.Drawing.Size(252, 31);
            this.productIDTextBox.TabIndex = 50;
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Location = new System.Drawing.Point(52, 286);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(32, 25);
            this.productIDLabel.TabIndex = 49;
            this.productIDLabel.Text = "ID";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(1860, 911);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(123, 55);
            this.CancelButton.TabIndex = 48;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // pageTitleLabel
            // 
            this.pageTitleLabel.AutoSize = true;
            this.pageTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitleLabel.Location = new System.Drawing.Point(52, 32);
            this.pageTitleLabel.Name = "pageTitleLabel";
            this.pageTitleLabel.Size = new System.Drawing.Size(134, 29);
            this.pageTitleLabel.TabIndex = 47;
            this.pageTitleLabel.Text = "Page Title";
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2144, 1012);
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
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.pageTitleLabel);
            this.Name = "ModifyProductForm";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label associatedProductLabel;
        private System.Windows.Forms.Label candidatePartsLabel;
        private System.Windows.Forms.DataGridView dgvAssociatedParts;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.TextBox partSearchText;
        private System.Windows.Forms.Button PartSearchButton;
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
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label pageTitleLabel;
    }
}