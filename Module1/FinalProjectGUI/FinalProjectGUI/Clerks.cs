using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectGUI
{
    public partial class Clerks : Form
    {
        HiTechDBEntities1 dbEntity = new HiTechDBEntities1();
        public Clerks()
        {
            InitializeComponent();
        }

        private void Clerks_Load(object sender, EventArgs e)
        {
            foreach (var item in dbEntity.Clients)
            {

                comboBoxClientID.Items.Add(item.ClientID + " " + item.ClientName);
            }
            foreach (var item in dbEntity.Employees)
            {
                if (item.JobTitle == "Order Clerk")
                {
                    comboBoxEmployeeID.Items.Add(item.EmployeeID + " " + item.FirstName + " " + item.LastName);
                }

            }
            foreach (var item in dbEntity.Products)
            {
                comboBoxProductID.Items.Add(item.ProductISBN +" "+ item.Title);
            }
        }

        private void saveOrderButton_Click(object sender, EventArgs e)
        {
            string[] stringSeparators = new string[] { " " };
            string[] productText = comboBoxProductID.Text.Split(stringSeparators, StringSplitOptions.None);
            string[] employeeText = comboBoxEmployeeID.Text.Split(stringSeparators, StringSplitOptions.None);
            string[] clientText = comboBoxClientID.Text.Split(stringSeparators, StringSplitOptions.None);

            Product product = dbEntity.Products.Find(Convert.ToInt32(productText[0]));
            Employee employee = dbEntity.Employees.Find(Convert.ToInt32(employeeText[0]));
            Client client = dbEntity.Clients.Find(Convert.ToInt32(clientText[0]));

            Order order = new Order();
            order.EmployeeID = employee.EmployeeID;
            order.ClientID = client.ClientID;
            order.OrderDate = Convert.ToDateTime(dateTimePickerOrderDate.Text);
            order.DeliverDate = Convert.ToDateTime(dateTimePickerDeliver.Text);
            order.ShippingDate = order.DeliverDate.Value.AddDays(-1);

            dbEntity.Orders.Add(order);
            dbEntity.SaveChanges();


            OrderLine orderLine = new OrderLine();
            orderLine.OrderID = order.OrderID;
            orderLine.ProductISBN = product.ProductISBN;
            orderLine.Quantity = Convert.ToInt32(quantityTextBox.Text);
            orderLine.Price = product.UnitPrice * orderLine.Quantity;

            dbEntity.OrderLines.Add(orderLine);
            dbEntity.SaveChanges();

            MessageBox.Show("Order Successfully saved.");

        }

        private void updateOrderButton_Click(object sender, EventArgs e)
        {
            string[] stringSeparators = new string[] { " " };
            string[] productText = comboBoxProductID.Text.Split(stringSeparators, StringSplitOptions.None);
            string[] employeeText = comboBoxEmployeeID.Text.Split(stringSeparators, StringSplitOptions.None);
            string[] clientText = comboBoxClientID.Text.Split(stringSeparators, StringSplitOptions.None);

            Product product = dbEntity.Products.Find(Convert.ToInt32(productText[0]));
            Employee employee = dbEntity.Employees.Find(Convert.ToInt32(employeeText[0]));
            Client client = dbEntity.Clients.Find(Convert.ToInt32(clientText[0]));

            if (client != null || employee != null)
            {
                var order = (from ord in dbEntity.Orders
                             where ord.EmployeeID == employee.EmployeeID || ord.ClientID == client.ClientID || ord.OrderDate == Convert.ToDateTime(dateTimePickerOrderDate.Text)
                             select ord).Single<Order>();
                if (order != null)
                {
                    var ol = (from ordLin in dbEntity.OrderLines
                              where ordLin.OrderID == order.OrderID || ordLin.ProductISBN == product.ProductISBN
                              select ordLin).Single<OrderLine>();

                    if (ol != null)
                    {
                        ol.Quantity = Convert.ToInt32(quantityTextBox.Text);
                        ol.Price = product.UnitPrice * ol.Quantity;

                        order.DeliverDate = Convert.ToDateTime(dateTimePickerDeliver.Text);
                        order.ShippingDate = order.DeliverDate.Value.AddDays(-1);

                        dbEntity.SaveChanges();

                        MessageBox.Show("Deliver date and quantity successfully updated ");
                    }
                    else
                    {
                        MessageBox.Show("Oder Not found, order not updated ");
                    }
                }
                else
                {
                    MessageBox.Show("Oder Not found, order not updated ");
                }
            }
        }

        private void searchOrderButton_Click(object sender, EventArgs e)
        {
            string[] stringSeparators = new string[] { " " };
            string[] productText = comboBoxProductID.Text.Split(stringSeparators, StringSplitOptions.None);
            string[] employeeText = comboBoxEmployeeID.Text.Split(stringSeparators, StringSplitOptions.None);
            string[] clientText = comboBoxClientID.Text.Split(stringSeparators, StringSplitOptions.None);

            Product product = dbEntity.Products.Find(Convert.ToInt32(productText[0]));
            Employee employee = dbEntity.Employees.Find(Convert.ToInt32(employeeText[0]));
            Client client = dbEntity.Clients.Find(Convert.ToInt32(clientText[0]));

            if (client != null || employee != null)
            {
                var order = (from ord in dbEntity.Orders
                             where ord.EmployeeID == employee.EmployeeID || ord.ClientID == client.ClientID || ord.OrderDate == Convert.ToDateTime(dateTimePickerOrderDate.Text)
                             select ord).Single<Order>();
                if (order != null)
                {
                    var ol = (from ordLin in dbEntity.OrderLines
                              where ordLin.OrderID == order.OrderID || ordLin.ProductISBN == product.ProductISBN
                              select ordLin).Single<OrderLine>();

                    if (ol != null)
                    {
                        quantityTextBox.Text = Convert.ToString(ol.Quantity);
                        dateTimePickerDeliver.Text = Convert.ToString(order.DeliverDate);

                    }
                    else
                    {
                        MessageBox.Show("Oder Not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Oder Not found.");
                }
            }
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            string[] stringSeparators = new string[] { " " };
            string[] productText = comboBoxProductID.Text.Split(stringSeparators, StringSplitOptions.None);
            string[] employeeText = comboBoxEmployeeID.Text.Split(stringSeparators, StringSplitOptions.None);
            string[] clientText = comboBoxClientID.Text.Split(stringSeparators, StringSplitOptions.None);

            Product product = dbEntity.Products.Find(Convert.ToInt32(productText[0]));
            Employee employee = dbEntity.Employees.Find(Convert.ToInt32(employeeText[0]));
            Client client = dbEntity.Clients.Find(Convert.ToInt32(clientText[0]));

            if (client != null || employee != null)
            {
                var order = (from ord in dbEntity.Orders
                             where ord.EmployeeID == employee.EmployeeID || ord.ClientID == client.ClientID || ord.OrderDate == Convert.ToDateTime(dateTimePickerOrderDate.Text)
                             select ord).Single<Order>();
                if (order != null)
                {
                    var ol = (from ordLin in dbEntity.OrderLines
                              where ordLin.OrderID == order.OrderID || ordLin.ProductISBN == product.ProductISBN
                              select ordLin).Single<OrderLine>();

                    if (ol != null)
                    {
                        
                        dbEntity.OrderLines.Remove(ol);
                        dbEntity.Orders.Remove(order);

                        dbEntity.SaveChanges();

                        MessageBox.Show("Oder successfully deleted ");
                    }
                    else
                    {
                        MessageBox.Show("Oder Not found, order not deleted ");
                    }
                }
                else
                {
                    MessageBox.Show("Oder Not found, order not deleted ");
                }
            }
        }

        private void ListOrderButton_Click(object sender, EventArgs e)
        {
            listViewOrders.Items.Clear();

            foreach (var ol in dbEntity.OrderLines)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(ol.OrderID));

                Product product = dbEntity.Products.Find(ol.ProductISBN);
                Order order = dbEntity.Orders.Find(ol.OrderID);
                Employee employee = dbEntity.Employees.Find(order.EmployeeID);
                Client client = dbEntity.Clients.Find(order.ClientID);


                item.SubItems.Add(client.ClientID + " " + client.ClientName);
                item.SubItems.Add(employee.EmployeeID + " " + employee.FirstName + " " + employee.LastName);
                item.SubItems.Add(order.OrderDate.ToString());
                item.SubItems.Add(order.DeliverDate.ToString());
                item.SubItems.Add(order.ShippingDate.ToString());
                item.SubItems.Add(product.ProductISBN + " " + product.Title);
                item.SubItems.Add(ol.Quantity.ToString());
                item.SubItems.Add(ol.Price.ToString());

                listViewOrders.Items.Add(item);

            }
        }

        private void listViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearOrderButton_Click(object sender, EventArgs e)
        {
            comboBoxProductID.Text = "";
            comboBoxEmployeeID.Text = "";
            comboBoxClientID.Text = "";
            quantityTextBox.Clear();
            dateTimePickerDeliver.Text = "";
            dateTimePickerOrderDate.Text = "";
            listViewOrders.Items.Clear();
        }

        private void exitOrderButton_Click(object sender, EventArgs e)
        {
            this.Close();
            UserLogin login = new UserLogin();
            login.Show();
        }
    }
}
