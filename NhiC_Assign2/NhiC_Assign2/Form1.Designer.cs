namespace NhiC_Assign2
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.quantitySoldLabel = new System.Windows.Forms.Label();
            this.quantityRestockedLabel = new System.Windows.Forms.Label();
            this.groceryListBox = new System.Windows.Forms.ListBox();
            this.loadDataGroupBox = new System.Windows.Forms.GroupBox();
            this.loadDataButton = new System.Windows.Forms.Button();
            this.updateDataGroupBox = new System.Windows.Forms.GroupBox();
            this.qtyRestockedTextBox = new System.Windows.Forms.TextBox();
            this.qtySoldTextBox = new System.Windows.Forms.TextBox();
            this.sortItemButton = new System.Windows.Forms.Button();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.updateRestockedQtyButton = new System.Windows.Forms.Button();
            this.updateSoldQtyButton = new System.Windows.Forms.Button();
            this.saveDataGroupBox = new System.Windows.Forms.GroupBox();
            this.saveRestockNeedsButton = new System.Windows.Forms.Button();
            this.saveSalesReportButton = new System.Windows.Forms.Button();
            this.saveDataButton = new System.Windows.Forms.Button();
            this.operationStatusLabel = new System.Windows.Forms.Label();
            this.loadDataGroupBox.SuspendLayout();
            this.updateDataGroupBox.SuspendLayout();
            this.saveDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(291, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(618, 37);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Super Store Grocery Management System";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantitySoldLabel
            // 
            this.quantitySoldLabel.AutoSize = true;
            this.quantitySoldLabel.Location = new System.Drawing.Point(25, 30);
            this.quantitySoldLabel.Name = "quantitySoldLabel";
            this.quantitySoldLabel.Size = new System.Drawing.Size(76, 13);
            this.quantitySoldLabel.TabIndex = 1;
            this.quantitySoldLabel.Text = "Quantity Sold: ";
            // 
            // quantityRestockedLabel
            // 
            this.quantityRestockedLabel.AutoSize = true;
            this.quantityRestockedLabel.Location = new System.Drawing.Point(264, 30);
            this.quantityRestockedLabel.Name = "quantityRestockedLabel";
            this.quantityRestockedLabel.Size = new System.Drawing.Size(104, 13);
            this.quantityRestockedLabel.TabIndex = 2;
            this.quantityRestockedLabel.Text = "Quantity Restocked:";
            // 
            // groceryListBox
            // 
            this.groceryListBox.Font = new System.Drawing.Font("Consolas", 10.25F);
            this.groceryListBox.FormattingEnabled = true;
            this.groceryListBox.ItemHeight = 17;
            this.groceryListBox.Location = new System.Drawing.Point(52, 82);
            this.groceryListBox.Name = "groceryListBox";
            this.groceryListBox.Size = new System.Drawing.Size(1076, 344);
            this.groceryListBox.TabIndex = 3;
            this.groceryListBox.SelectedIndexChanged += new System.EventHandler(this.groceryListBox_SelectedIndexChanged);
            // 
            // loadDataGroupBox
            // 
            this.loadDataGroupBox.BackColor = System.Drawing.Color.Beige;
            this.loadDataGroupBox.Controls.Add(this.loadDataButton);
            this.loadDataGroupBox.Location = new System.Drawing.Point(52, 469);
            this.loadDataGroupBox.Name = "loadDataGroupBox";
            this.loadDataGroupBox.Size = new System.Drawing.Size(268, 194);
            this.loadDataGroupBox.TabIndex = 4;
            this.loadDataGroupBox.TabStop = false;
            this.loadDataGroupBox.Text = "Load Data";
            // 
            // loadDataButton
            // 
            this.loadDataButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.loadDataButton.Location = new System.Drawing.Point(34, 75);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(196, 45);
            this.loadDataButton.TabIndex = 4;
            this.loadDataButton.Text = "Load Grocery Data";
            this.loadDataButton.UseVisualStyleBackColor = true;
            this.loadDataButton.Click += new System.EventHandler(this.loadDataButton_Click);
            // 
            // updateDataGroupBox
            // 
            this.updateDataGroupBox.BackColor = System.Drawing.Color.Beige;
            this.updateDataGroupBox.Controls.Add(this.qtyRestockedTextBox);
            this.updateDataGroupBox.Controls.Add(this.qtySoldTextBox);
            this.updateDataGroupBox.Controls.Add(this.sortItemButton);
            this.updateDataGroupBox.Controls.Add(this.deleteItemButton);
            this.updateDataGroupBox.Controls.Add(this.updateRestockedQtyButton);
            this.updateDataGroupBox.Controls.Add(this.updateSoldQtyButton);
            this.updateDataGroupBox.Controls.Add(this.quantitySoldLabel);
            this.updateDataGroupBox.Controls.Add(this.quantityRestockedLabel);
            this.updateDataGroupBox.Location = new System.Drawing.Point(338, 469);
            this.updateDataGroupBox.Name = "updateDataGroupBox";
            this.updateDataGroupBox.Size = new System.Drawing.Size(515, 194);
            this.updateDataGroupBox.TabIndex = 5;
            this.updateDataGroupBox.TabStop = false;
            this.updateDataGroupBox.Text = "Update Data";
            this.updateDataGroupBox.Enter += new System.EventHandler(this.updateDataGroupBox_Enter);
            // 
            // qtyRestockedTextBox
            // 
            this.qtyRestockedTextBox.Location = new System.Drawing.Point(374, 27);
            this.qtyRestockedTextBox.Name = "qtyRestockedTextBox";
            this.qtyRestockedTextBox.Size = new System.Drawing.Size(89, 20);
            this.qtyRestockedTextBox.TabIndex = 8;
            // 
            // qtySoldTextBox
            // 
            this.qtySoldTextBox.Location = new System.Drawing.Point(105, 28);
            this.qtySoldTextBox.Name = "qtySoldTextBox";
            this.qtySoldTextBox.Size = new System.Drawing.Size(118, 20);
            this.qtySoldTextBox.TabIndex = 7;
            // 
            // sortItemButton
            // 
            this.sortItemButton.Location = new System.Drawing.Point(267, 123);
            this.sortItemButton.Name = "sortItemButton";
            this.sortItemButton.Size = new System.Drawing.Size(196, 45);
            this.sortItemButton.TabIndex = 6;
            this.sortItemButton.Text = "Sort Item Based On Sales";
            this.sortItemButton.UseVisualStyleBackColor = true;
            this.sortItemButton.Click += new System.EventHandler(this.sortItemButton_Click);
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Location = new System.Drawing.Point(28, 123);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(196, 45);
            this.deleteItemButton.TabIndex = 5;
            this.deleteItemButton.Text = "Delete Selected Grocery Item";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.deleteItemButton_Click);
            // 
            // updateRestockedQtyButton
            // 
            this.updateRestockedQtyButton.Location = new System.Drawing.Point(267, 62);
            this.updateRestockedQtyButton.Name = "updateRestockedQtyButton";
            this.updateRestockedQtyButton.Size = new System.Drawing.Size(196, 45);
            this.updateRestockedQtyButton.TabIndex = 4;
            this.updateRestockedQtyButton.Text = "Update Restocked Qty For Selected Item";
            this.updateRestockedQtyButton.UseVisualStyleBackColor = true;
            this.updateRestockedQtyButton.Click += new System.EventHandler(this.updateRestockedQtyButton_Click);
            // 
            // updateSoldQtyButton
            // 
            this.updateSoldQtyButton.Location = new System.Drawing.Point(28, 62);
            this.updateSoldQtyButton.Name = "updateSoldQtyButton";
            this.updateSoldQtyButton.Size = new System.Drawing.Size(196, 45);
            this.updateSoldQtyButton.TabIndex = 3;
            this.updateSoldQtyButton.Text = "Update Sold Qty For Selected Item";
            this.updateSoldQtyButton.UseVisualStyleBackColor = true;
            this.updateSoldQtyButton.Click += new System.EventHandler(this.updateSoldQtyButton_Click);
            // 
            // saveDataGroupBox
            // 
            this.saveDataGroupBox.BackColor = System.Drawing.Color.Beige;
            this.saveDataGroupBox.Controls.Add(this.saveRestockNeedsButton);
            this.saveDataGroupBox.Controls.Add(this.saveSalesReportButton);
            this.saveDataGroupBox.Controls.Add(this.saveDataButton);
            this.saveDataGroupBox.Location = new System.Drawing.Point(877, 469);
            this.saveDataGroupBox.Name = "saveDataGroupBox";
            this.saveDataGroupBox.Size = new System.Drawing.Size(251, 194);
            this.saveDataGroupBox.TabIndex = 6;
            this.saveDataGroupBox.TabStop = false;
            this.saveDataGroupBox.Text = "Save Data";
            // 
            // saveRestockNeedsButton
            // 
            this.saveRestockNeedsButton.Location = new System.Drawing.Point(28, 129);
            this.saveRestockNeedsButton.Name = "saveRestockNeedsButton";
            this.saveRestockNeedsButton.Size = new System.Drawing.Size(196, 45);
            this.saveRestockNeedsButton.TabIndex = 6;
            this.saveRestockNeedsButton.Text = "Save Restock Needs Report";
            this.saveRestockNeedsButton.UseVisualStyleBackColor = true;
            this.saveRestockNeedsButton.Click += new System.EventHandler(this.saveRestockNeedsButton_Click);
            // 
            // saveSalesReportButton
            // 
            this.saveSalesReportButton.Location = new System.Drawing.Point(28, 78);
            this.saveSalesReportButton.Name = "saveSalesReportButton";
            this.saveSalesReportButton.Size = new System.Drawing.Size(196, 45);
            this.saveSalesReportButton.TabIndex = 5;
            this.saveSalesReportButton.Text = "Save Sales Report";
            this.saveSalesReportButton.UseVisualStyleBackColor = true;
            this.saveSalesReportButton.Click += new System.EventHandler(this.saveSalesReportButton_Click);
            // 
            // saveDataButton
            // 
            this.saveDataButton.Location = new System.Drawing.Point(28, 27);
            this.saveDataButton.Name = "saveDataButton";
            this.saveDataButton.Size = new System.Drawing.Size(196, 45);
            this.saveDataButton.TabIndex = 4;
            this.saveDataButton.Text = "Save Grocery Data";
            this.saveDataButton.UseVisualStyleBackColor = true;
            this.saveDataButton.Click += new System.EventHandler(this.saveDataButton_Click);
            // 
            // operationStatusLabel
            // 
            this.operationStatusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.operationStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.operationStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationStatusLabel.Location = new System.Drawing.Point(52, 688);
            this.operationStatusLabel.Name = "operationStatusLabel";
            this.operationStatusLabel.Size = new System.Drawing.Size(1076, 50);
            this.operationStatusLabel.TabIndex = 7;
            this.operationStatusLabel.Text = "Operation Status Update Displayed Here";
            this.operationStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1174, 749);
            this.Controls.Add(this.operationStatusLabel);
            this.Controls.Add(this.saveDataGroupBox);
            this.Controls.Add(this.updateDataGroupBox);
            this.Controls.Add(this.loadDataGroupBox);
            this.Controls.Add(this.groceryListBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.loadDataGroupBox.ResumeLayout(false);
            this.updateDataGroupBox.ResumeLayout(false);
            this.updateDataGroupBox.PerformLayout();
            this.saveDataGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label quantitySoldLabel;
        private System.Windows.Forms.Label quantityRestockedLabel;
        private System.Windows.Forms.ListBox groceryListBox;
        private System.Windows.Forms.GroupBox loadDataGroupBox;
        private System.Windows.Forms.GroupBox updateDataGroupBox;
        private System.Windows.Forms.GroupBox saveDataGroupBox;
        private System.Windows.Forms.Label operationStatusLabel;
        private System.Windows.Forms.Button loadDataButton;
        private System.Windows.Forms.TextBox qtyRestockedTextBox;
        private System.Windows.Forms.TextBox qtySoldTextBox;
        private System.Windows.Forms.Button sortItemButton;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Button updateRestockedQtyButton;
        private System.Windows.Forms.Button updateSoldQtyButton;
        private System.Windows.Forms.Button saveRestockNeedsButton;
        private System.Windows.Forms.Button saveSalesReportButton;
        private System.Windows.Forms.Button saveDataButton;
    }
}

