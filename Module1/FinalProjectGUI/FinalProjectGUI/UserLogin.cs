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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            UsersBussinessSide.UserClass urs = new UsersBussinessSide.UserClass();

            urs.UserName = userNameTextBox.Text;
            urs.Password = passwordTextBox.Text;

            urs = urs.SearchUser(urs.UserName);

             if ( urs != null)
            {
                UsersBussinessSide.EmployeeClass empl = new UsersBussinessSide.EmployeeClass();
                empl.EmployeeID = urs.EmployeeRec.EmployeeID;

                empl = empl.SearchEmployee(empl.EmployeeID);

                if (empl != null)
                {
                    if (empl.JobTitle == "MIS Manager")
                    {
                        MISManagement misForm = new MISManagement();
                        misForm.Show();
                    }
                    else if (empl.JobTitle == "Sales Manager")
                    {
                        SalesMan salesForm = new SalesMan();
                        salesForm.Show();
                    }
                    else if (empl.JobTitle == "Inventory Controller")
                    {
                        InvMan invMan = new InvMan();
                        invMan.Show();

                    }
                    else if (empl.JobTitle == "Order Clerk")
                    {
                        Clerks clrk = new Clerks();
                        clrk.Show();

                    }
                    else
                    {
                        MessageBox.Show("This User does not have a valid title in the company.");
                    }
                }
              }
              else
            {
                MessageBox.Show("UserName or Password is not valid. ");
            }
        }

        private void ExitLogonButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
