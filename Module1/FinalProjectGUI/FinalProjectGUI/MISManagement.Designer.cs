namespace FinalProjectGUI
{
    partial class MISManagement
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.exitEmplButton = new System.Windows.Forms.Button();
            this.clearEmplButton = new System.Windows.Forms.Button();
            this.listViewEmployees = new System.Windows.Forms.ListView();
            this.EmployeeIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JobTitleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListEmployeeButton = new System.Windows.Forms.Button();
            this.updateEmployeeButton = new System.Windows.Forms.Button();
            this.searchEmployeeButton = new System.Windows.Forms.Button();
            this.deleteEmployeeButton = new System.Windows.Forms.Button();
            this.saveEmployeeButton = new System.Windows.Forms.Button();
            this.jobTitleComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.exitUserButton = new System.Windows.Forms.Button();
            this.clearUserButton = new System.Windows.Forms.Button();
            this.employeeIDcomboBox = new System.Windows.Forms.ComboBox();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listUserButton = new System.Windows.Forms.Button();
            this.updateUserButton = new System.Windows.Forms.Button();
            this.searchUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.saveUserButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(600, 449);
            this.tabControl.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.exitEmplButton);
            this.tabPage1.Controls.Add(this.clearEmplButton);
            this.tabPage1.Controls.Add(this.listViewEmployees);
            this.tabPage1.Controls.Add(this.ListEmployeeButton);
            this.tabPage1.Controls.Add(this.updateEmployeeButton);
            this.tabPage1.Controls.Add(this.searchEmployeeButton);
            this.tabPage1.Controls.Add(this.deleteEmployeeButton);
            this.tabPage1.Controls.Add(this.saveEmployeeButton);
            this.tabPage1.Controls.Add(this.jobTitleComboBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lastNameTextBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.firstNameTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.employeeIDTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employee";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // exitEmplButton
            // 
            this.exitEmplButton.Location = new System.Drawing.Point(380, 379);
            this.exitEmplButton.Name = "exitEmplButton";
            this.exitEmplButton.Size = new System.Drawing.Size(75, 23);
            this.exitEmplButton.TabIndex = 15;
            this.exitEmplButton.Text = "Exit";
            this.exitEmplButton.UseVisualStyleBackColor = true;
            this.exitEmplButton.Click += new System.EventHandler(this.exitEmplButton_Click);
            // 
            // clearEmplButton
            // 
            this.clearEmplButton.Location = new System.Drawing.Point(135, 379);
            this.clearEmplButton.Name = "clearEmplButton";
            this.clearEmplButton.Size = new System.Drawing.Size(75, 23);
            this.clearEmplButton.TabIndex = 14;
            this.clearEmplButton.Text = "Clear";
            this.clearEmplButton.UseVisualStyleBackColor = true;
            this.clearEmplButton.Click += new System.EventHandler(this.clearEmplButton_Click);
            // 
            // listViewEmployees
            // 
            this.listViewEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmployeeIDColumn,
            this.FirstNameColumn,
            this.LastNameColumn,
            this.JobTitleColumn});
            this.listViewEmployees.GridLines = true;
            this.listViewEmployees.Location = new System.Drawing.Point(23, 185);
            this.listViewEmployees.Name = "listViewEmployees";
            this.listViewEmployees.Size = new System.Drawing.Size(551, 166);
            this.listViewEmployees.TabIndex = 13;
            this.listViewEmployees.UseCompatibleStateImageBehavior = false;
            this.listViewEmployees.View = System.Windows.Forms.View.Details;
            this.listViewEmployees.SelectedIndexChanged += new System.EventHandler(this.listViewEmployees_SelectedIndexChanged);
            // 
            // EmployeeIDColumn
            // 
            this.EmployeeIDColumn.Text = "EmployeeID";
            this.EmployeeIDColumn.Width = 108;
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.Text = "FirstName";
            this.FirstNameColumn.Width = 153;
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.Text = "LastName";
            this.LastNameColumn.Width = 134;
            // 
            // JobTitleColumn
            // 
            this.JobTitleColumn.Text = "JobTitle";
            this.JobTitleColumn.Width = 129;
            // 
            // ListEmployeeButton
            // 
            this.ListEmployeeButton.Location = new System.Drawing.Point(498, 121);
            this.ListEmployeeButton.Name = "ListEmployeeButton";
            this.ListEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.ListEmployeeButton.TabIndex = 12;
            this.ListEmployeeButton.Text = "List";
            this.ListEmployeeButton.UseVisualStyleBackColor = true;
            this.ListEmployeeButton.Click += new System.EventHandler(this.ListEmployeeButton_Click);
            // 
            // updateEmployeeButton
            // 
            this.updateEmployeeButton.Location = new System.Drawing.Point(135, 121);
            this.updateEmployeeButton.Name = "updateEmployeeButton";
            this.updateEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.updateEmployeeButton.TabIndex = 11;
            this.updateEmployeeButton.Text = "Update";
            this.updateEmployeeButton.UseVisualStyleBackColor = true;
            this.updateEmployeeButton.Click += new System.EventHandler(this.updateEmployeeButton_Click);
            // 
            // searchEmployeeButton
            // 
            this.searchEmployeeButton.Location = new System.Drawing.Point(255, 121);
            this.searchEmployeeButton.Name = "searchEmployeeButton";
            this.searchEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.searchEmployeeButton.TabIndex = 10;
            this.searchEmployeeButton.Text = "Search";
            this.searchEmployeeButton.UseVisualStyleBackColor = true;
            this.searchEmployeeButton.Click += new System.EventHandler(this.searchEmployeeButton_Click);
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.Location = new System.Drawing.Point(380, 121);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.deleteEmployeeButton.TabIndex = 9;
            this.deleteEmployeeButton.Text = "Delete";
            this.deleteEmployeeButton.UseVisualStyleBackColor = true;
            this.deleteEmployeeButton.Click += new System.EventHandler(this.deleteEmployeeButton_Click);
            // 
            // saveEmployeeButton
            // 
            this.saveEmployeeButton.Location = new System.Drawing.Point(23, 121);
            this.saveEmployeeButton.Name = "saveEmployeeButton";
            this.saveEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.saveEmployeeButton.TabIndex = 8;
            this.saveEmployeeButton.Text = "Save";
            this.saveEmployeeButton.UseVisualStyleBackColor = true;
            this.saveEmployeeButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // jobTitleComboBox
            // 
            this.jobTitleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobTitleComboBox.FormattingEnabled = true;
            this.jobTitleComboBox.Items.AddRange(new object[] {
            "MIS Manager",
            "Sales Manager",
            "Inventory Controller",
            "Order Clerk"});
            this.jobTitleComboBox.Location = new System.Drawing.Point(452, 54);
            this.jobTitleComboBox.Name = "jobTitleComboBox";
            this.jobTitleComboBox.Size = new System.Drawing.Size(121, 21);
            this.jobTitleComboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(448, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Job Title";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(305, 55);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(301, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(157, 54);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(153, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee ID";
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.Location = new System.Drawing.Point(22, 54);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.employeeIDTextBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.exitUserButton);
            this.tabPage2.Controls.Add(this.clearUserButton);
            this.tabPage2.Controls.Add(this.employeeIDcomboBox);
            this.tabPage2.Controls.Add(this.listViewUsers);
            this.tabPage2.Controls.Add(this.listUserButton);
            this.tabPage2.Controls.Add(this.updateUserButton);
            this.tabPage2.Controls.Add(this.searchUserButton);
            this.tabPage2.Controls.Add(this.deleteUserButton);
            this.tabPage2.Controls.Add(this.saveUserButton);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.passwordTextBox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.userNameTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // exitUserButton
            // 
            this.exitUserButton.Location = new System.Drawing.Point(318, 370);
            this.exitUserButton.Name = "exitUserButton";
            this.exitUserButton.Size = new System.Drawing.Size(75, 23);
            this.exitUserButton.TabIndex = 24;
            this.exitUserButton.Text = "Exit";
            this.exitUserButton.UseVisualStyleBackColor = true;
            this.exitUserButton.Click += new System.EventHandler(this.exitUserButton_Click);
            // 
            // clearUserButton
            // 
            this.clearUserButton.Location = new System.Drawing.Point(128, 370);
            this.clearUserButton.Name = "clearUserButton";
            this.clearUserButton.Size = new System.Drawing.Size(75, 23);
            this.clearUserButton.TabIndex = 23;
            this.clearUserButton.Text = "Clear";
            this.clearUserButton.UseVisualStyleBackColor = true;
            this.clearUserButton.Click += new System.EventHandler(this.clearUserButton_Click);
            // 
            // employeeIDcomboBox
            // 
            this.employeeIDcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeIDcomboBox.FormattingEnabled = true;
            this.employeeIDcomboBox.Location = new System.Drawing.Point(408, 63);
            this.employeeIDcomboBox.Name = "employeeIDcomboBox";
            this.employeeIDcomboBox.Size = new System.Drawing.Size(121, 21);
            this.employeeIDcomboBox.TabIndex = 22;
            // 
            // listViewUsers
            // 
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserName,
            this.Password,
            this.EmployeeID});
            this.listViewUsers.GridLines = true;
            this.listViewUsers.Location = new System.Drawing.Point(47, 172);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(477, 192);
            this.listViewUsers.TabIndex = 21;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            // 
            // UserName
            // 
            this.UserName.Text = "UserName";
            this.UserName.Width = 121;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 151;
            // 
            // EmployeeID
            // 
            this.EmployeeID.Text = "EmployeeID";
            this.EmployeeID.Width = 169;
            // 
            // listUserButton
            // 
            this.listUserButton.Location = new System.Drawing.Point(429, 113);
            this.listUserButton.Name = "listUserButton";
            this.listUserButton.Size = new System.Drawing.Size(75, 23);
            this.listUserButton.TabIndex = 20;
            this.listUserButton.Text = "List";
            this.listUserButton.UseVisualStyleBackColor = true;
            this.listUserButton.Click += new System.EventHandler(this.listUserButton_Click);
            // 
            // updateUserButton
            // 
            this.updateUserButton.Location = new System.Drawing.Point(128, 113);
            this.updateUserButton.Name = "updateUserButton";
            this.updateUserButton.Size = new System.Drawing.Size(55, 23);
            this.updateUserButton.TabIndex = 19;
            this.updateUserButton.Text = "Update";
            this.updateUserButton.UseVisualStyleBackColor = true;
            this.updateUserButton.Click += new System.EventHandler(this.updateUserButton_Click);
            // 
            // searchUserButton
            // 
            this.searchUserButton.Location = new System.Drawing.Point(225, 113);
            this.searchUserButton.Name = "searchUserButton";
            this.searchUserButton.Size = new System.Drawing.Size(64, 23);
            this.searchUserButton.TabIndex = 18;
            this.searchUserButton.Text = "Search";
            this.searchUserButton.UseVisualStyleBackColor = true;
            this.searchUserButton.Click += new System.EventHandler(this.searchUserButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(327, 113);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(66, 23);
            this.deleteUserButton.TabIndex = 17;
            this.deleteUserButton.Text = "Delete";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // saveUserButton
            // 
            this.saveUserButton.Location = new System.Drawing.Point(47, 113);
            this.saveUserButton.Name = "saveUserButton";
            this.saveUserButton.Size = new System.Drawing.Size(50, 23);
            this.saveUserButton.TabIndex = 16;
            this.saveUserButton.Text = "Save";
            this.saveUserButton.UseVisualStyleBackColor = true;
            this.saveUserButton.Click += new System.EventHandler(this.saveUserButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(404, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Employee ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(225, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(225, 65);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(47, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "User Name";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(47, 65);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.userNameTextBox.TabIndex = 10;
            // 
            // MISManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 465);
            this.Controls.Add(this.tabControl);
            this.Name = "MISManagement";
            this.Text = "MISManagement";
            this.Load += new System.EventHandler(this.MISManagement_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button ListEmployeeButton;
        private System.Windows.Forms.Button updateEmployeeButton;
        private System.Windows.Forms.Button searchEmployeeButton;
        private System.Windows.Forms.Button deleteEmployeeButton;
        private System.Windows.Forms.Button saveEmployeeButton;
        private System.Windows.Forms.ComboBox jobTitleComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button listUserButton;
        private System.Windows.Forms.Button updateUserButton;
        private System.Windows.Forms.Button searchUserButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button saveUserButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.ListView listViewEmployees;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader EmployeeIDColumn;
        private System.Windows.Forms.ColumnHeader FirstNameColumn;
        private System.Windows.Forms.ColumnHeader LastNameColumn;
        private System.Windows.Forms.ColumnHeader JobTitleColumn;
        private System.Windows.Forms.ComboBox employeeIDcomboBox;
        private System.Windows.Forms.Button exitEmplButton;
        private System.Windows.Forms.Button clearEmplButton;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader EmployeeID;
        private System.Windows.Forms.Button exitUserButton;
        private System.Windows.Forms.Button clearUserButton;
    }
}