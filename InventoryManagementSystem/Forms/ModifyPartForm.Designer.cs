﻿namespace InventoryManagementSystem.Forms
{
    partial class ModifyPartForm
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
            this.pageTitleLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.partSaveButton = new System.Windows.Forms.Button();
            this.partDynamicTextBox = new System.Windows.Forms.TextBox();
            this.partDynamicLabel = new System.Windows.Forms.Label();
            this.partMaxTextBox = new System.Windows.Forms.TextBox();
            this.partMaxLabel = new System.Windows.Forms.Label();
            this.partMinTextBox = new System.Windows.Forms.TextBox();
            this.partMinLabel = new System.Windows.Forms.Label();
            this.partPriceTextBox = new System.Windows.Forms.TextBox();
            this.partPriceLabel = new System.Windows.Forms.Label();
            this.partInventoryTextBox = new System.Windows.Forms.TextBox();
            this.partInventoryLabel = new System.Windows.Forms.Label();
            this.partNameTextBox = new System.Windows.Forms.TextBox();
            this.partNameLabel = new System.Windows.Forms.Label();
            this.partIDTextBox = new System.Windows.Forms.TextBox();
            this.partIDLabel = new System.Windows.Forms.Label();
            this.outsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.houseRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // pageTitleLabel
            // 
            this.pageTitleLabel.AutoSize = true;
            this.pageTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitleLabel.Location = new System.Drawing.Point(33, 65);
            this.pageTitleLabel.Name = "pageTitleLabel";
            this.pageTitleLabel.Size = new System.Drawing.Size(134, 29);
            this.pageTitleLabel.TabIndex = 2;
            this.pageTitleLabel.Text = "Page Title";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(1023, 805);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(123, 55);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // partSaveButton
            // 
            this.partSaveButton.Location = new System.Drawing.Point(857, 804);
            this.partSaveButton.Name = "partSaveButton";
            this.partSaveButton.Size = new System.Drawing.Size(123, 55);
            this.partSaveButton.TabIndex = 39;
            this.partSaveButton.Text = "Save";
            this.partSaveButton.UseVisualStyleBackColor = true;
            this.partSaveButton.Click += new System.EventHandler(this.PartSaveButton_Click);
            // 
            // partDynamicTextBox
            // 
            this.partDynamicTextBox.Location = new System.Drawing.Point(609, 628);
            this.partDynamicTextBox.Name = "partDynamicTextBox";
            this.partDynamicTextBox.Size = new System.Drawing.Size(252, 31);
            this.partDynamicTextBox.TabIndex = 37;
            // 
            // partDynamicLabel
            // 
            this.partDynamicLabel.AutoSize = true;
            this.partDynamicLabel.Location = new System.Drawing.Point(388, 634);
            this.partDynamicLabel.Name = "partDynamicLabel";
            this.partDynamicLabel.Size = new System.Drawing.Size(109, 25);
            this.partDynamicLabel.TabIndex = 41;
            this.partDynamicLabel.Text = "(Dynamic)";
            // 
            // partMaxTextBox
            // 
            this.partMaxTextBox.Location = new System.Drawing.Point(888, 538);
            this.partMaxTextBox.Name = "partMaxTextBox";
            this.partMaxTextBox.Size = new System.Drawing.Size(85, 31);
            this.partMaxTextBox.TabIndex = 36;
            // 
            // partMaxLabel
            // 
            this.partMaxLabel.AutoSize = true;
            this.partMaxLabel.Location = new System.Drawing.Point(751, 541);
            this.partMaxLabel.Name = "partMaxLabel";
            this.partMaxLabel.Size = new System.Drawing.Size(53, 25);
            this.partMaxLabel.TabIndex = 40;
            this.partMaxLabel.Text = "Max";
            // 
            // partMinTextBox
            // 
            this.partMinTextBox.Location = new System.Drawing.Point(609, 541);
            this.partMinTextBox.Name = "partMinTextBox";
            this.partMinTextBox.Size = new System.Drawing.Size(85, 31);
            this.partMinTextBox.TabIndex = 34;
            // 
            // partMinLabel
            // 
            this.partMinLabel.AutoSize = true;
            this.partMinLabel.Location = new System.Drawing.Point(388, 547);
            this.partMinLabel.Name = "partMinLabel";
            this.partMinLabel.Size = new System.Drawing.Size(47, 25);
            this.partMinLabel.TabIndex = 38;
            this.partMinLabel.Text = "Min";
            // 
            // partPriceTextBox
            // 
            this.partPriceTextBox.Location = new System.Drawing.Point(609, 453);
            this.partPriceTextBox.Name = "partPriceTextBox";
            this.partPriceTextBox.Size = new System.Drawing.Size(252, 31);
            this.partPriceTextBox.TabIndex = 33;
            // 
            // partPriceLabel
            // 
            this.partPriceLabel.AutoSize = true;
            this.partPriceLabel.Location = new System.Drawing.Point(388, 459);
            this.partPriceLabel.Name = "partPriceLabel";
            this.partPriceLabel.Size = new System.Drawing.Size(123, 25);
            this.partPriceLabel.TabIndex = 35;
            this.partPriceLabel.Text = "Price / Cost";
            // 
            // partInventoryTextBox
            // 
            this.partInventoryTextBox.Location = new System.Drawing.Point(609, 372);
            this.partInventoryTextBox.Name = "partInventoryTextBox";
            this.partInventoryTextBox.Size = new System.Drawing.Size(252, 31);
            this.partInventoryTextBox.TabIndex = 31;
            // 
            // partInventoryLabel
            // 
            this.partInventoryLabel.AutoSize = true;
            this.partInventoryLabel.Location = new System.Drawing.Point(388, 378);
            this.partInventoryLabel.Name = "partInventoryLabel";
            this.partInventoryLabel.Size = new System.Drawing.Size(100, 25);
            this.partInventoryLabel.TabIndex = 32;
            this.partInventoryLabel.Text = "Inventory";
            // 
            // partNameTextBox
            // 
            this.partNameTextBox.Location = new System.Drawing.Point(609, 298);
            this.partNameTextBox.Name = "partNameTextBox";
            this.partNameTextBox.Size = new System.Drawing.Size(252, 31);
            this.partNameTextBox.TabIndex = 30;
            // 
            // partNameLabel
            // 
            this.partNameLabel.AutoSize = true;
            this.partNameLabel.Location = new System.Drawing.Point(388, 304);
            this.partNameLabel.Name = "partNameLabel";
            this.partNameLabel.Size = new System.Drawing.Size(68, 25);
            this.partNameLabel.TabIndex = 29;
            this.partNameLabel.Text = "Name";
            // 
            // partIDTextBox
            // 
            this.partIDTextBox.Location = new System.Drawing.Point(609, 218);
            this.partIDTextBox.Name = "partIDTextBox";
            this.partIDTextBox.ReadOnly = true;
            this.partIDTextBox.Size = new System.Drawing.Size(252, 31);
            this.partIDTextBox.TabIndex = 28;
            // 
            // partIDLabel
            // 
            this.partIDLabel.AutoSize = true;
            this.partIDLabel.Location = new System.Drawing.Point(388, 221);
            this.partIDLabel.Name = "partIDLabel";
            this.partIDLabel.Size = new System.Drawing.Size(32, 25);
            this.partIDLabel.TabIndex = 25;
            this.partIDLabel.Text = "ID";
            // 
            // outsourcedRadioButton
            // 
            this.outsourcedRadioButton.AutoSize = true;
            this.outsourcedRadioButton.Location = new System.Drawing.Point(707, 66);
            this.outsourcedRadioButton.Name = "outsourcedRadioButton";
            this.outsourcedRadioButton.Size = new System.Drawing.Size(154, 29);
            this.outsourcedRadioButton.TabIndex = 27;
            this.outsourcedRadioButton.TabStop = true;
            this.outsourcedRadioButton.Text = "Outsourced";
            this.outsourcedRadioButton.UseVisualStyleBackColor = true;
            // 
            // houseRadioButton
            // 
            this.houseRadioButton.AutoSize = true;
            this.houseRadioButton.Location = new System.Drawing.Point(393, 65);
            this.houseRadioButton.Name = "houseRadioButton";
            this.houseRadioButton.Size = new System.Drawing.Size(129, 29);
            this.houseRadioButton.TabIndex = 26;
            this.houseRadioButton.TabStop = true;
            this.houseRadioButton.Text = "In-House";
            this.houseRadioButton.UseVisualStyleBackColor = true;
            this.houseRadioButton.CheckedChanged += new System.EventHandler(this.HouseRadioButton_CheckedChanged);
            // 
            // ModifyPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 932);
            this.Controls.Add(this.partSaveButton);
            this.Controls.Add(this.partDynamicTextBox);
            this.Controls.Add(this.partDynamicLabel);
            this.Controls.Add(this.partMaxTextBox);
            this.Controls.Add(this.partMaxLabel);
            this.Controls.Add(this.partMinTextBox);
            this.Controls.Add(this.partMinLabel);
            this.Controls.Add(this.partPriceTextBox);
            this.Controls.Add(this.partPriceLabel);
            this.Controls.Add(this.partInventoryTextBox);
            this.Controls.Add(this.partInventoryLabel);
            this.Controls.Add(this.partNameTextBox);
            this.Controls.Add(this.partNameLabel);
            this.Controls.Add(this.partIDTextBox);
            this.Controls.Add(this.partIDLabel);
            this.Controls.Add(this.outsourcedRadioButton);
            this.Controls.Add(this.houseRadioButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.pageTitleLabel);
            this.Name = "ModifyPartForm";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pageTitleLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button partSaveButton;
        private System.Windows.Forms.TextBox partDynamicTextBox;
        private System.Windows.Forms.Label partDynamicLabel;
        private System.Windows.Forms.TextBox partMaxTextBox;
        private System.Windows.Forms.Label partMaxLabel;
        private System.Windows.Forms.TextBox partMinTextBox;
        private System.Windows.Forms.Label partMinLabel;
        private System.Windows.Forms.TextBox partPriceTextBox;
        private System.Windows.Forms.Label partPriceLabel;
        private System.Windows.Forms.TextBox partInventoryTextBox;
        private System.Windows.Forms.Label partInventoryLabel;
        private System.Windows.Forms.TextBox partNameTextBox;
        private System.Windows.Forms.Label partNameLabel;
        private System.Windows.Forms.TextBox partIDTextBox;
        private System.Windows.Forms.Label partIDLabel;
        private System.Windows.Forms.RadioButton outsourcedRadioButton;
        private System.Windows.Forms.RadioButton houseRadioButton;
    }
}