namespace FinalProjectGUI
{
    partial class Clerks
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
            this.comboBoxEmployeeID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Client = new System.Windows.Forms.Label();
            this.comboBoxClientID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxProductID = new System.Windows.Forms.ComboBox();
            this.quantityTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDeliver = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.ListOrderButton = new System.Windows.Forms.Button();
            this.updateOrderButton = new System.Windows.Forms.Button();
            this.searchOrderButton = new System.Windows.Forms.Button();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.saveOrderButton = new System.Windows.Forms.Button();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePickerOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.exitOrderButton = new System.Windows.Forms.Button();
            this.clearOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxEmployeeID
            // 
            this.comboBoxEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployeeID.FormattingEnabled = true;
            this.comboBoxEmployeeID.Location = new System.Drawing.Point(22, 35);
            this.comboBoxEmployeeID.Name = "comboBoxEmployeeID";
            this.comboBoxEmployeeID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmployeeID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee ID";
            // 
            // Client
            // 
            this.Client.AutoSize = true;
            this.Client.Location = new System.Drawing.Point(170, 19);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(47, 13);
            this.Client.TabIndex = 2;
            this.Client.Text = "Client ID";
            // 
            // comboBoxClientID
            // 
            this.comboBoxClientID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientID.FormattingEnabled = true;
            this.comboBoxClientID.Location = new System.Drawing.Point(173, 35);
            this.comboBoxClientID.Name = "comboBoxClientID";
            this.comboBoxClientID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClientID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product ID";
            // 
            // comboBoxProductID
            // 
            this.comboBoxProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductID.FormattingEnabled = true;
            this.comboBoxProductID.Location = new System.Drawing.Point(315, 34);
            this.comboBoxProductID.Name = "comboBoxProductID";
            this.comboBoxProductID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProductID.TabIndex = 5;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(466, 35);
            this.quantityTextBox.Mask = "00000";
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 6;
            this.quantityTextBox.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity";
            // 
            // dateTimePickerDeliver
            // 
            this.dateTimePickerDeliver.Location = new System.Drawing.Point(597, 35);
            this.dateTimePickerDeliver.MaxDate = new System.DateTime(2090, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDeliver.MinDate = new System.DateTime(2017, 4, 25, 0, 0, 0, 0);
            this.dateTimePickerDeliver.Name = "dateTimePickerDeliver";
            this.dateTimePickerDeliver.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDeliver.TabIndex = 8;
            this.dateTimePickerDeliver.Value = new System.DateTime(2017, 4, 25, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Deliver Date";
            // 
            // ListOrderButton
            // 
            this.ListOrderButton.Location = new System.Drawing.Point(722, 82);
            this.ListOrderButton.Name = "ListOrderButton";
            this.ListOrderButton.Size = new System.Drawing.Size(75, 23);
            this.ListOrderButton.TabIndex = 17;
            this.ListOrderButton.Text = "List";
            this.ListOrderButton.UseVisualStyleBackColor = true;
            this.ListOrderButton.Click += new System.EventHandler(this.ListOrderButton_Click);
            // 
            // updateOrderButton
            // 
            this.updateOrderButton.Location = new System.Drawing.Point(479, 82);
            this.updateOrderButton.Name = "updateOrderButton";
            this.updateOrderButton.Size = new System.Drawing.Size(75, 23);
            this.updateOrderButton.TabIndex = 16;
            this.updateOrderButton.Text = "Update";
            this.updateOrderButton.UseVisualStyleBackColor = true;
            this.updateOrderButton.Click += new System.EventHandler(this.updateOrderButton_Click);
            // 
            // searchOrderButton
            // 
            this.searchOrderButton.Location = new System.Drawing.Point(560, 82);
            this.searchOrderButton.Name = "searchOrderButton";
            this.searchOrderButton.Size = new System.Drawing.Size(75, 23);
            this.searchOrderButton.TabIndex = 15;
            this.searchOrderButton.Text = "Search";
            this.searchOrderButton.UseVisualStyleBackColor = true;
            this.searchOrderButton.Click += new System.EventHandler(this.searchOrderButton_Click);
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Location = new System.Drawing.Point(641, 82);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(75, 23);
            this.deleteOrderButton.TabIndex = 14;
            this.deleteOrderButton.Text = "Delete";
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // saveOrderButton
            // 
            this.saveOrderButton.Location = new System.Drawing.Point(398, 82);
            this.saveOrderButton.Name = "saveOrderButton";
            this.saveOrderButton.Size = new System.Drawing.Size(75, 23);
            this.saveOrderButton.TabIndex = 13;
            this.saveOrderButton.Text = "Save";
            this.saveOrderButton.UseVisualStyleBackColor = true;
            this.saveOrderButton.Click += new System.EventHandler(this.saveOrderButton_Click);
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewOrders.GridLines = true;
            this.listViewOrders.Location = new System.Drawing.Point(22, 146);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(775, 274);
            this.listViewOrders.TabIndex = 18;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            this.listViewOrders.SelectedIndexChanged += new System.EventHandler(this.listViewOrders_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Client";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Employee";
            this.columnHeader3.Width = 109;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "OrderDate";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "DeliverDate";
            this.columnHeader5.Width = 99;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ShippingDate";
            this.columnHeader6.Width = 106;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "product";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Quantity";
            this.columnHeader8.Width = 74;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Price";
            // 
            // dateTimePickerOrderDate
            // 
            this.dateTimePickerOrderDate.Location = new System.Drawing.Point(22, 85);
            this.dateTimePickerOrderDate.MaxDate = new System.DateTime(2090, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            this.dateTimePickerOrderDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerOrderDate.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Order Date";
            // 
            // exitOrderButton
            // 
            this.exitOrderButton.Location = new System.Drawing.Point(466, 438);
            this.exitOrderButton.Name = "exitOrderButton";
            this.exitOrderButton.Size = new System.Drawing.Size(75, 23);
            this.exitOrderButton.TabIndex = 33;
            this.exitOrderButton.Text = "Exit";
            this.exitOrderButton.UseVisualStyleBackColor = true;
            this.exitOrderButton.Click += new System.EventHandler(this.exitOrderButton_Click);
            // 
            // clearOrderButton
            // 
            this.clearOrderButton.Location = new System.Drawing.Point(235, 438);
            this.clearOrderButton.Name = "clearOrderButton";
            this.clearOrderButton.Size = new System.Drawing.Size(75, 23);
            this.clearOrderButton.TabIndex = 32;
            this.clearOrderButton.Text = "Clear";
            this.clearOrderButton.UseVisualStyleBackColor = true;
            this.clearOrderButton.Click += new System.EventHandler(this.clearOrderButton_Click);
            // 
            // Clerks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 493);
            this.Controls.Add(this.exitOrderButton);
            this.Controls.Add(this.clearOrderButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerOrderDate);
            this.Controls.Add(this.listViewOrders);
            this.Controls.Add(this.ListOrderButton);
            this.Controls.Add(this.updateOrderButton);
            this.Controls.Add(this.searchOrderButton);
            this.Controls.Add(this.deleteOrderButton);
            this.Controls.Add(this.saveOrderButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerDeliver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.comboBoxProductID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxClientID);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEmployeeID);
            this.Name = "Clerks";
            this.Text = "Clerks";
            this.Load += new System.EventHandler(this.Clerks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Client;
        private System.Windows.Forms.ComboBox comboBoxClientID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxProductID;
        private System.Windows.Forms.MaskedTextBox quantityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeliver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ListOrderButton;
        private System.Windows.Forms.Button updateOrderButton;
        private System.Windows.Forms.Button searchOrderButton;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.Button saveOrderButton;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button exitOrderButton;
        private System.Windows.Forms.Button clearOrderButton;
    }
}