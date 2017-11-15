using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryClient;
using System.Data.SqlClient;
using ClassLibraryClient.Bussiness;


namespace FinalProjectGUI
{
    public partial class SalesMan : Form
    {
        DataSet dsClients = new DataSet("DBClients");
        DataTable dtClients = new DataTable("Clients");

        private void UpdateDB()
        {
            if (dsClients.HasChanges())
            {
                SqlDataAdapter sqlDA = UtilityDB.GetDataAdapter();
                SqlCommandBuilder sqlCmd = new SqlCommandBuilder(sqlDA);

                sqlDA.Update(dsClients.Tables["Clients"]);

                MessageBox.Show("DataBase successfully updated.");
            }
            else
            {
                MessageBox.Show("No changes, No DataBase updated.");
            }
        }

        public SalesMan()
        {
            InitializeComponent();
        }

        private void SalesMan_Load(object sender, EventArgs e)
        {
            dsClients.Tables.Add(dtClients);
            dsClients = UtilityDB.GetDataSet(dsClients, dtClients);

            dataGridViewClients.DataSource = dsClients;
            dataGridViewClients.DataMember = "Clients";
        }
        private void saveClientButton_Click(object sender, EventArgs e)
        {
            if (Validation.ISValidText(clientNameTextBox.Text) && Validation.ISValidText(clientStreetTextBox.Text)
                && Validation.ISValidText(clientCityTextBox.Text) && Validation.ISValidText(clientPostalCodeTextBox.Text)
                && Validation.ISValidText(clientPhoneTextBox.Text) && Validation.ISValidText(clientFaxTextBox.Text))
            {
                ClientClass cl = new ClientClass();

                cl.Name = clientNameTextBox.Text;
                cl.Street = clientStreetTextBox.Text;
                cl.City = clientCityTextBox.Text;
                cl.PostalCode = clientPostalCodeTextBox.Text;
                cl.Phone = clientPhoneTextBox.Text;
                cl.Fax = clientFaxTextBox.Text;
                cl.MaxCredits = Convert.ToInt32(clientMaxCreditsTextBox.Text);

                dtClients.Rows.Add(null, cl.Name, cl.Street, cl.City, cl.PostalCode, cl.Phone, cl.Fax, cl.MaxCredits);

                UpdateDB();
                MessageBox.Show("Client successfully saved ");
            }
            else { MessageBox.Show("Client not saved, enter valid information "); }
            
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void updateClientButton_Click(object sender, EventArgs e)
        {
            if (Validation.ISValidText(clientNameTextBox.Text) && Validation.ISValidText(clientStreetTextBox.Text)
                && Validation.ISValidText(clientCityTextBox.Text) && Validation.ISValidText(clientPostalCodeTextBox.Text)
                && Validation.ISValidText(clientPhoneTextBox.Text) && Validation.ISValidText(clientFaxTextBox.Text))
            {
                
            if (clientNameTextBox.Text != "")
                {
                    DataRow dr = dtClients.Rows.Find(clientIDTextBox.Text);

                    if (dr != null)
                    {
                        dr["ClientName"] = clientNameTextBox.Text;
                        dr["ClientStreet"] = clientStreetTextBox.Text;
                        dr["ClientCity"] = clientCityTextBox.Text;
                        dr["ClientPostalCode"] = clientPostalCodeTextBox.Text;
                        dr["ClientPhone"] = clientPostalCodeTextBox.Text;
                        dr["ClientFax"] = clientFaxTextBox.Text;
                        dr["ClientMaxCredits"] = Convert.ToInt32(clientMaxCreditsTextBox.Text);


                        MessageBox.Show("Client Successfully Updated.");

                        UpdateDB();
                    }

                    else
                    {
                        MessageBox.Show("Client not found by ID");

                    }

                }

                else
                {
                    MessageBox.Show("Please enter valid Client name.");
                }
            }
            else { MessageBox.Show("Client not saved, enter valid information "); }
        }
        private void ListClientButton_Click(object sender, EventArgs e)
        {
            dsClients = UtilityDB.GetDataSet(dsClients, dtClients);

            dataGridViewClients.DataSource = dsClients;
            dataGridViewClients.DataMember = "Clients";
        }
        private void deleteClientButton_Click(object sender, EventArgs e)
        {
            DataRow dr = dtClients.Rows.Find(clientIDTextBox.Text);

            if (dr != null)
            {
                dr.Delete();
                MessageBox.Show("Client Successfully Deleted.");
                UpdateDB();
            }
            else
            {
                MessageBox.Show("Client not found by ID");

            }

        }

        private void listViewClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchClientButton_Click(object sender, EventArgs e)
        {
            DataRow dr = dtClients.Rows.Find(clientIDTextBox.Text);
            if (dr != null)
            {
                clientIDTextBox.Text = dr["ClientID"].ToString();
                clientNameTextBox.Text = dr["ClientName"].ToString() ;
                clientStreetTextBox.Text = dr["ClientStreet"].ToString();
                clientCityTextBox.Text = dr["ClientCity"].ToString()  ;
                clientPostalCodeTextBox.Text = dr["ClientPostalCode"].ToString() ;
                clientPostalCodeTextBox.Text = dr["ClientPhone"].ToString();
                clientFaxTextBox.Text = dr["ClientFax"].ToString() ;
                clientMaxCreditsTextBox.Text = dr["ClientMaxCredits"].ToString() ;
            }
            else
            {
                MessageBox.Show("Client not found.");

            }
        }

        private void clearEmplButton_Click(object sender, EventArgs e)
        {
            clientIDTextBox.Clear();
            clientNameTextBox.Clear();
            clientStreetTextBox.Clear();
            clientCityTextBox.Clear();
            clientPostalCodeTextBox.Clear();
            clientPostalCodeTextBox.Clear();
            clientFaxTextBox.Clear();
            clientMaxCreditsTextBox.Clear();
            
            dataGridViewClients.ClearSelection();
            
        }

        private void exitEmplButton_Click(object sender, EventArgs e)
        {
            this.Close();
            UserLogin login = new UserLogin();
            login.Show();
        }
    }
}
