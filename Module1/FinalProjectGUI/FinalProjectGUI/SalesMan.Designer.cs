namespace FinalProjectGUI
{
    partial class SalesMan
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
            this.searchClientButton = new System.Windows.Forms.Button();
            this.ListClientButton = new System.Windows.Forms.Button();
            this.updateClientButton = new System.Windows.Forms.Button();
            this.deleteClientButton = new System.Windows.Forms.Button();
            this.saveClientButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clientMaxCreditsTextBox = new System.Windows.Forms.MaskedTextBox();
            this.clientFaxTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.clientPhoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.clientPostalCodeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.clientCityTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.clientStreetTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.clientIDTextBox = new System.Windows.Forms.MaskedTextBox();
            this.exitEmplButton = new System.Windows.Forms.Button();
            this.clearEmplButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // searchClientButton
            // 
            this.searchClientButton.Location = new System.Drawing.Point(306, 180);
            this.searchClientButton.Name = "searchClientButton";
            this.searchClientButton.Size = new System.Drawing.Size(75, 23);
            this.searchClientButton.TabIndex = 15;
            this.searchClientButton.Text = "Search";
            this.searchClientButton.UseVisualStyleBackColor = true;
            this.searchClientButton.Click += new System.EventHandler(this.searchClientButton_Click);
            // 
            // ListClientButton
            // 
            this.ListClientButton.Location = new System.Drawing.Point(407, 180);
            this.ListClientButton.Name = "ListClientButton";
            this.ListClientButton.Size = new System.Drawing.Size(75, 23);
            this.ListClientButton.TabIndex = 24;
            this.ListClientButton.Text = "List";
            this.ListClientButton.UseVisualStyleBackColor = true;
            this.ListClientButton.Click += new System.EventHandler(this.ListClientButton_Click);
            // 
            // updateClientButton
            // 
            this.updateClientButton.Location = new System.Drawing.Point(110, 180);
            this.updateClientButton.Name = "updateClientButton";
            this.updateClientButton.Size = new System.Drawing.Size(75, 23);
            this.updateClientButton.TabIndex = 23;
            this.updateClientButton.Text = "Update";
            this.updateClientButton.UseVisualStyleBackColor = true;
            this.updateClientButton.Click += new System.EventHandler(this.updateClientButton_Click);
            // 
            // deleteClientButton
            // 
            this.deleteClientButton.Location = new System.Drawing.Point(209, 180);
            this.deleteClientButton.Name = "deleteClientButton";
            this.deleteClientButton.Size = new System.Drawing.Size(75, 23);
            this.deleteClientButton.TabIndex = 22;
            this.deleteClientButton.Text = "Delete";
            this.deleteClientButton.UseVisualStyleBackColor = true;
            this.deleteClientButton.Click += new System.EventHandler(this.deleteClientButton_Click);
            // 
            // saveClientButton
            // 
            this.saveClientButton.Location = new System.Drawing.Point(22, 180);
            this.saveClientButton.Name = "saveClientButton";
            this.saveClientButton.Size = new System.Drawing.Size(75, 23);
            this.saveClientButton.TabIndex = 21;
            this.saveClientButton.Text = "Save";
            this.saveClientButton.UseVisualStyleBackColor = true;
            this.saveClientButton.Click += new System.EventHandler(this.saveClientButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clientIDTextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.clientMaxCreditsTextBox);
            this.groupBox1.Controls.Add(this.clientFaxTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.clientPhoneTextBox);
            this.groupBox1.Controls.Add(this.clientPostalCodeTextBox);
            this.groupBox1.Controls.Add(this.clientCityTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.clientNameTextBox);
            this.groupBox1.Controls.Add(this.clientStreetTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 153);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // clientMaxCreditsTextBox
            // 
            this.clientMaxCreditsTextBox.Location = new System.Drawing.Point(263, 115);
            this.clientMaxCreditsTextBox.Mask = "00000";
            this.clientMaxCreditsTextBox.Name = "clientMaxCreditsTextBox";
            this.clientMaxCreditsTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientMaxCreditsTextBox.TabIndex = 17;
            this.clientMaxCreditsTextBox.ValidatingType = typeof(int);
            // 
            // clientFaxTextBox
            // 
            this.clientFaxTextBox.Location = new System.Drawing.Point(137, 115);
            this.clientFaxTextBox.Mask = "9990000000";
            this.clientFaxTextBox.Name = "clientFaxTextBox";
            this.clientFaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientFaxTextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(259, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Max of Credits";
            // 
            // clientPhoneTextBox
            // 
            this.clientPhoneTextBox.Location = new System.Drawing.Point(10, 115);
            this.clientPhoneTextBox.Mask = "9990000000";
            this.clientPhoneTextBox.Name = "clientPhoneTextBox";
            this.clientPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientPhoneTextBox.TabIndex = 14;
            // 
            // clientPostalCodeTextBox
            // 
            this.clientPostalCodeTextBox.Location = new System.Drawing.Point(382, 56);
            this.clientPostalCodeTextBox.Mask = "A0A0A0";
            this.clientPostalCodeTextBox.Name = "clientPostalCodeTextBox";
            this.clientPostalCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientPostalCodeTextBox.TabIndex = 13;
            // 
            // clientCityTextBox
            // 
            this.clientCityTextBox.Location = new System.Drawing.Point(263, 56);
            this.clientCityTextBox.Name = "clientCityTextBox";
            this.clientCityTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientCityTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(259, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(378, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "PostalCode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "PhoneNumber";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(133, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fax";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(144, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Street";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Institution Name";
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(10, 56);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.clientNameTextBox.TabIndex = 4;
            // 
            // clientStreetTextBox
            // 
            this.clientStreetTextBox.Location = new System.Drawing.Point(148, 56);
            this.clientStreetTextBox.Name = "clientStreetTextBox";
            this.clientStreetTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientStreetTextBox.TabIndex = 7;
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(12, 228);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(504, 198);
            this.dataGridViewClients.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(378, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Client ID";
            // 
            // clientIDTextBox
            // 
            this.clientIDTextBox.Location = new System.Drawing.Point(382, 115);
            this.clientIDTextBox.Mask = "00000";
            this.clientIDTextBox.Name = "clientIDTextBox";
            this.clientIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientIDTextBox.TabIndex = 20;
            this.clientIDTextBox.ValidatingType = typeof(int);
            // 
            // exitEmplButton
            // 
            this.exitEmplButton.Location = new System.Drawing.Point(352, 450);
            this.exitEmplButton.Name = "exitEmplButton";
            this.exitEmplButton.Size = new System.Drawing.Size(75, 23);
            this.exitEmplButton.TabIndex = 29;
            this.exitEmplButton.Text = "Exit";
            this.exitEmplButton.UseVisualStyleBackColor = true;
            this.exitEmplButton.Click += new System.EventHandler(this.exitEmplButton_Click);
            // 
            // clearEmplButton
            // 
            this.clearEmplButton.Location = new System.Drawing.Point(107, 450);
            this.clearEmplButton.Name = "clearEmplButton";
            this.clearEmplButton.Size = new System.Drawing.Size(75, 23);
            this.clearEmplButton.TabIndex = 28;
            this.clearEmplButton.Text = "Clear";
            this.clearEmplButton.UseVisualStyleBackColor = true;
            this.clearEmplButton.Click += new System.EventHandler(this.clearEmplButton_Click);
            // 
            // SalesMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 497);
            this.Controls.Add(this.exitEmplButton);
            this.Controls.Add(this.clearEmplButton);
            this.Controls.Add(this.dataGridViewClients);
            this.Controls.Add(this.searchClientButton);
            this.Controls.Add(this.ListClientButton);
            this.Controls.Add(this.updateClientButton);
            this.Controls.Add(this.deleteClientButton);
            this.Controls.Add(this.saveClientButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "SalesMan";
            this.Text = "Sales Management";
            this.Load += new System.EventHandler(this.SalesMan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button searchClientButton;
        private System.Windows.Forms.Button ListClientButton;
        private System.Windows.Forms.Button updateClientButton;
        private System.Windows.Forms.Button deleteClientButton;
        private System.Windows.Forms.Button saveClientButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox clientMaxCreditsTextBox;
        private System.Windows.Forms.MaskedTextBox clientFaxTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox clientPhoneTextBox;
        private System.Windows.Forms.MaskedTextBox clientPostalCodeTextBox;
        private System.Windows.Forms.TextBox clientCityTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.TextBox clientStreetTextBox;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.MaskedTextBox clientIDTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button exitEmplButton;
        private System.Windows.Forms.Button clearEmplButton;
    }
}