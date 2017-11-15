using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersBussinessSide;


namespace FinalProjectGUI
{
    public partial class MISManagement : Form
    {
        public MISManagement()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            employeeIDTextBox.Clear();

            if (firstNameTextBox.Text != "" || lastNameTextBox.Text != "")
            {

                EmployeeClass emp = new EmployeeClass();
                emp.FirstName = firstNameTextBox.Text;
                emp.LastName = lastNameTextBox.Text;
                emp.JobTitle = jobTitleComboBox.Text;

                bool saved = emp.SaveEmployee(emp);

                if (saved)
                {
                    MessageBox.Show("Employee Successfully saved.");
                }
                else
                {
                    MessageBox.Show("Employee already exists.");
                }

            }
            else
            {
                MessageBox.Show("Please enter Employee first and last name.");
            }
            
        }

        private void updateEmployeeButton_Click(object sender, EventArgs e)
        {
            if (Validation.IsValidID(employeeIDTextBox.Text))
            {
                if (firstNameTextBox.Text != "" || lastNameTextBox.Text != "")
                {
                    EmployeeClass emp = new EmployeeClass();
                    emp.EmployeeID = Convert.ToInt32(employeeIDTextBox.Text);
                    emp.FirstName = firstNameTextBox.Text;
                    emp.LastName = lastNameTextBox.Text;
                    emp.JobTitle = jobTitleComboBox.Text;

                    bool updated = emp.UpdateEmployee(emp);

                    if (updated)
                    {
                        MessageBox.Show("Employee Successfully updated.");
                    }
                    else
                    {
                        MessageBox.Show("Employee does not exists.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter Employee first and last name.");
                }
            }
            else
            {
                MessageBox.Show("ID is not in a valid format.");
            }
        }

        private void searchEmployeeButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            jobTitleComboBox.Text = "";

            if (Validation.IsValidID(employeeIDTextBox.Text))
            {
                firstNameTextBox.ReadOnly=true;
                lastNameTextBox.ReadOnly = true;

                EmployeeClass emp = new EmployeeClass();

                emp.EmployeeID = Convert.ToInt32(employeeIDTextBox.Text);
                emp = emp.SearchEmployee(emp.EmployeeID);
                 

                if (emp== null)
                {
                    MessageBox.Show("Employee Not found.");
                }
                else
                {
                    firstNameTextBox.Text = emp.FirstName;
                    lastNameTextBox.Text = emp.LastName;
                    jobTitleComboBox.Text = emp.JobTitle;
                }
            }
            else
            {
                MessageBox.Show("ID is not in a valid format.");
            }
        }

        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            jobTitleComboBox.Text = "";

            if (Validation.IsValidID(employeeIDTextBox.Text))
            {
                EmployeeClass emp = new EmployeeClass();
                emp.EmployeeID = Convert.ToInt32(employeeIDTextBox.Text);
            
                bool deleted = emp.DeleteEmployee(Convert.ToInt32(employeeIDTextBox.Text));

                if (deleted)
                {
                    MessageBox.Show("Employee Successfully deleted.");
                }
                else
                {
                    MessageBox.Show("Employee does not exists.");
                }

            }
            else
            {
                MessageBox.Show("ID is not in a valid format.");
            }
        }

        private void ListEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeClass emp = new EmployeeClass();
            List<EmployeeClass> listE = emp.ListEmployees();
            

            listViewEmployees.Items.Clear();
            foreach (EmployeeClass anEmp in listE)
            {
                ListViewItem anItem = new ListViewItem(anEmp.EmployeeID.ToString());
                anItem.SubItems.Add(anEmp.FirstName);
                anItem.SubItems.Add(anEmp.LastName);
                anItem.SubItems.Add(anEmp.JobTitle);
                listViewEmployees.Items.Add(anItem);
            }

        }

        private void saveUserButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text != "")
            {
                if (Validation.IsValidPassword(passwordTextBox.Text))
                {
                    UserClass usr = new UserClass();

                    usr.UserName = userNameTextBox.Text;
                    usr.Password = passwordTextBox.Text;
                    usr.EmployeeRec.EmployeeID = Convert.ToInt32(employeeIDcomboBox.Text);

                    bool saved = usr.SaveUser(usr);

                    if (saved)
                    {
                        MessageBox.Show("Employee already exists.");
                    }
                    else
                    {
                        MessageBox.Show("User Not saved, Check if UserName or EmployeeID already exists.");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter a valid Password.");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid UserName.");
            }
        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text != "")
            {
                if (Validation.IsValidPassword(passwordTextBox.Text))
                {
                    UserClass usr = new UserClass();

                    usr.UserName = userNameTextBox.Text;
                    usr.Password = passwordTextBox.Text;
                    usr.EmployeeRec.EmployeeID = Convert.ToInt32(employeeIDcomboBox.Text);


                    UserClass exist = usr.SearchUser(usr.EmployeeRec.EmployeeID);
                if (exist != usr)
                {
                    bool updated = usr.UpdateUser(usr);

                    if (updated)
                    {
                        MessageBox.Show("User Successfully Updated.");
                    }
                    else
                    {
                        MessageBox.Show("User Not Updated, Check if input information is in correct format.");
                    }
                }
                else
                {

                    MessageBox.Show("User Not Updated, Check if UserName or EmployeeID already exists.");

                }

                }
            }
            else
            {
                MessageBox.Show("Please enter valid UserName.");
            }
        }

        private void searchUserButton_Click(object sender, EventArgs e)
        {
            userNameTextBox.Text = "";
            passwordTextBox.Text = "";

            if (Validation.IsValidID(employeeIDcomboBox.Text))
            {
                UserClass usr = new UserClass();

                userNameTextBox.ReadOnly = true;
                passwordTextBox.ReadOnly = true;

                usr = usr.SearchUser(Convert.ToInt32(employeeIDcomboBox.Text));

                if (usr == null)
                {
                    MessageBox.Show("Employee does not have an user account.");
                }
                else
                {
                    userNameTextBox.Text = usr.UserName;
                    passwordTextBox.Text = usr.Password;
                }
            }
            else
            {
                MessageBox.Show("Employee ID is not in a valid format.");
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (Validation.IsValidID(employeeIDcomboBox.Text))
            {

                UserClass usr = new UserClass();
                
                    bool deleted = usr.DeleteUser(Convert.ToInt32(employeeIDcomboBox.Text));

                    if (deleted)
                    {
                        MessageBox.Show("User Successfully deleted.");
                    }
                    else
                    {
                        MessageBox.Show("User Not deleted, Check if EmployeeID already exists.");
                    }
       
            }
            else
            {
                MessageBox.Show("Employee ID is not in a valid format.");
            }
        }

        private void listUserButton_Click(object sender, EventArgs e)
        {
            UserClass usr = new UserClass();
            List<UserClass> listU = usr.ListUsers();


            listViewUsers.Items.Clear();
            foreach (UserClass anUsr in listU)
            {
                EmployeeClass emp = new EmployeeClass();
                emp = emp.SearchEmployee(anUsr.EmployeeRec.EmployeeID);

                ListViewItem anItem = new ListViewItem(anUsr.UserName);
                anItem.SubItems.Add(anUsr.Password);
                anItem.SubItems.Add(Convert.ToString(anUsr.EmployeeRec.EmployeeID));

                listViewUsers.Items.Add(anItem);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void MISManagement_Load(object sender, EventArgs e)
        {
            EmployeeClass emp = new EmployeeClass();
            foreach (EmployeeClass item in emp.ListEmployees())
            {
                employeeIDcomboBox.Items.Add(item.EmployeeID );
            }
        }

        private void clearEmplButton_Click(object sender, EventArgs e)
        {
            employeeIDTextBox.Clear();
            employeeIDTextBox.ReadOnly = false;
            firstNameTextBox.Clear();
            firstNameTextBox.ReadOnly = false;
            lastNameTextBox.Clear();
            lastNameTextBox.ReadOnly = false;
            jobTitleComboBox.ResetText();
            listViewEmployees.Items.Clear();
        }

        private void clearUserButton_Click(object sender, EventArgs e)
        {
            userNameTextBox.Clear();
            userNameTextBox.ReadOnly = false;
            passwordTextBox.Clear();
            passwordTextBox.ReadOnly = false;
            employeeIDcomboBox.ResetText();
            listViewUsers.Items.Clear();

            EmployeeClass emp = new EmployeeClass();
            foreach (EmployeeClass item in emp.ListEmployees())
            {
                employeeIDcomboBox.Items.Add(item.EmployeeID);
            }
        }

        private void exitUserButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitEmplButton_Click(object sender, EventArgs e)
        {
            this.Close();
            UserLogin login = new UserLogin();
            login.Show();
        }

        private void listViewEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
