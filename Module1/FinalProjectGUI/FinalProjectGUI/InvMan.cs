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
    public partial class InvMan : Form
    {
        HiTechDBEntities1 dbEntity = new HiTechDBEntities1();

        public InvMan()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void SalesManagement_Load(object sender, EventArgs e)
        {

            foreach (var item in dbEntity.Categories)
            {

                productCategoryComboBox.Items.Add(item.CategoryID +" "+item.CategoryDescription);
            }

            foreach (var item in dbEntity.Authors)
            {
                productAuthorComboBox.Items.Add( item.AuthorID +" " + item.FirstName + " " + item.LastName);
            }

            foreach (var item in dbEntity.Publishers)
            {
                productSupplierComboBox.Items.Add(item.PublisherID +" " + item.PublisherName);

            }
        }

        private void saveClientButton_Click(object sender, EventArgs e)
        {
            if (Validation.ISValidText(productTitleTextBox.Text))
            {
                string[] stringSeparators = new string[] { " " };
                string[] authorText = productAuthorComboBox.Text.Split(stringSeparators, StringSplitOptions.None);
                string[] categoryText = productCategoryComboBox.Text.Split(stringSeparators, StringSplitOptions.None);
                string[] supplierText = productSupplierComboBox.Text.Split(stringSeparators, StringSplitOptions.None);

                Author autor = dbEntity.Authors.Find(Convert.ToInt32(authorText[0]));
                Category cate = dbEntity.Categories.Find(Convert.ToInt32(categoryText[0]));
                Publisher pub = dbEntity.Publishers.Find(Convert.ToInt32(supplierText[0]));

                Product prod = new Product();

                prod.AuthorID = autor.AuthorID;
                prod.Category = cate.CategoryID;
                prod.PublisherID = pub.PublisherID;
                prod.QuantityOnHand = Convert.ToInt32(productQOHTextBox.Text);
                prod.Title = productTitleTextBox.Text;
                prod.Type = productTypeComboBox.Text;
                prod.UnitPrice = Convert.ToInt32(productPriceTextBox.Text);
                prod.YearPublished = Convert.ToInt32(productYearPublishedTextBox.Text);

                dbEntity.Products.Add(prod);
                dbEntity.SaveChanges();
                MessageBox.Show("Product successfully saved. ");
            }
            else { MessageBox.Show("Product not saved, please enter valid information. "); }
        }

        private void productCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListClientButton_Click(object sender, EventArgs e)
        {
            listViewProducts.Items.Clear();

            foreach (var pro in dbEntity.Products)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(pro.ProductISBN));
                Author autor = dbEntity.Authors.Find(pro.AuthorID);
                Category cate = dbEntity.Categories.Find(pro.Category);
                Publisher pub = dbEntity.Publishers.Find(pro.PublisherID);

                
                item.SubItems.Add(pro.Title);
                item.SubItems.Add(pro.Type);
                item.SubItems.Add(Convert.ToString(pro.UnitPrice));
                item.SubItems.Add(Convert.ToString(pro.YearPublished));
                item.SubItems.Add(Convert.ToString(pro.QuantityOnHand));
                item.SubItems.Add(cate.CategoryDescription);
                item.SubItems.Add(autor.FirstName + " " + autor.LastName);
                item.SubItems.Add(pub.PublisherName);

                listViewProducts.Items.Add(item);

            }
        }

        private void updateClientButton_Click(object sender, EventArgs e)
        {
            if (Validation.ISValidText(productTitleTextBox.Text))
            {
                int serachKey = Convert.ToInt32(productISBNTextBox.Text);

                Product prod = dbEntity.Products.Find(serachKey);

                if (prod != null)
                {
                    string[] stringSeparators = new string[] { " " };
                    string[] authorText = productAuthorComboBox.Text.Split(stringSeparators, StringSplitOptions.None);
                    string[] categoryText = productCategoryComboBox.Text.Split(stringSeparators, StringSplitOptions.None);
                    string[] supplierText = productSupplierComboBox.Text.Split(stringSeparators, StringSplitOptions.None);

                    Author autor = dbEntity.Authors.Find(Convert.ToInt32(authorText[0]));
                    Category cate = dbEntity.Categories.Find(Convert.ToInt32(categoryText[0]));
                    Publisher pub = dbEntity.Publishers.Find(Convert.ToInt32(supplierText[0]));

                    prod.AuthorID = autor.AuthorID;
                    prod.Category = cate.CategoryID;
                    prod.PublisherID = pub.PublisherID;
                    prod.QuantityOnHand = Convert.ToInt32(productQOHTextBox.Text);
                    prod.Title = productTitleTextBox.Text;
                    prod.Type = productTypeComboBox.Text;
                    prod.UnitPrice = Convert.ToInt32(productPriceTextBox.Text);
                    prod.YearPublished = Convert.ToInt32(productYearPublishedTextBox.Text);

                    dbEntity.SaveChanges();

                    MessageBox.Show("Product successfully updated ");
                }
                else
                {
                    MessageBox.Show("Product Not found, product not updated ");
                }
            }
            else { MessageBox.Show("Product not updated, please enter valid information. "); }
            
        }

        private void deleteClientButton_Click(object sender, EventArgs e)
        {
            int serachKey = Convert.ToInt32(productISBNTextBox.Text);

            Product prod = dbEntity.Products.Find(serachKey);

            if (prod != null)
            {

                dbEntity.Products.Remove(prod);
                dbEntity.SaveChanges();

                MessageBox.Show("Product successfully deleted ");
            }
            else
            {
                MessageBox.Show("Product Not found, product not deleted ");
            }
        }

        private void searchClientButton_Click(object sender, EventArgs e)
        {
            int serachKey = Convert.ToInt32(productISBNTextBox.Text);

            Product prod = dbEntity.Products.Find(serachKey);

            if (prod != null)
            {
                Author autor = dbEntity.Authors.Find(prod.AuthorID);
                Category cate = dbEntity.Categories.Find(prod.Category);
                Publisher pub = dbEntity.Publishers.Find(prod.PublisherID);

                productCategoryComboBox.Items.Add(cate.CategoryID + " " + cate.CategoryDescription);
                productAuthorComboBox.Items.Add(autor.AuthorID + " " + autor.FirstName + " " + autor.LastName);
                productSupplierComboBox.Items.Add(pub.PublisherID + " " + pub.PublisherName);

                productQOHTextBox.Text = Convert.ToString(prod.QuantityOnHand);
                productTitleTextBox.Text = prod.Title  ;
                productTypeComboBox.Text = prod.Type;
                productPriceTextBox.Text = Convert.ToString(prod.UnitPrice);
                productYearPublishedTextBox.Text  = Convert.ToString(prod.YearPublished);


            }
            else
            {
                MessageBox.Show("Product Not found.");
            }

        }

        private void clearEmplButton_Click(object sender, EventArgs e)
        {

            productCategoryComboBox.Text = "";
            productAuthorComboBox.Text = "";
            productSupplierComboBox.Text = "";
            productISBNTextBox.Clear();
            productQOHTextBox.Clear();
            productTitleTextBox.Clear();
            productTypeComboBox.Text= "";
            productPriceTextBox.Clear();
            productYearPublishedTextBox.Clear();
            listViewProducts.Items.Clear();

            foreach (var item in dbEntity.Categories)
            {

                productCategoryComboBox.Items.Add(item.CategoryID + " " + item.CategoryDescription);
            }

            foreach (var item in dbEntity.Authors)
            {
                productAuthorComboBox.Items.Add(item.AuthorID + " " + item.FirstName + " " + item.LastName);
            }

            foreach (var item in dbEntity.Publishers)
            {
                productSupplierComboBox.Items.Add(item.PublisherID + " " + item.PublisherName);

            }

            textBoxAuthorFirstName.Text = "";
            textBoxAuthorLastName.Text = "";
            maskedTextBoxAuthorID.Text = "";
            listViewAuthors.Items.Clear();

            maskedTextBoxPublisherID.Text = "";
            textBoxPublisherDescription.Text = "";
            textBoxPublisherName.Text = "";
            listViewPublishers.Items.Clear();

            maskedTextBoxCategoryID.Text = "";
            textBoxCategoryDescription.Text = "";
            listViewCategory.Items.Clear();
        }

        private void exitEmplButton_Click(object sender, EventArgs e)
        {
            this.Close();
            UserLogin login = new UserLogin();
            login.Show();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int serachKey = Convert.ToInt16(maskedTextBoxPublisherID.Text);

            Publisher pub = dbEntity.Publishers.Find(serachKey);

            if (pub != null)
                
            {

                dbEntity.Publishers.Remove(pub);
                dbEntity.SaveChanges();

                MessageBox.Show("Publisher successfully deleted ");
            }
            else
            {
                MessageBox.Show("Publisher Not found, Publisher not deleted ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int serachKey = Convert.ToInt16(maskedTextBoxPublisherID.Text);

            Publisher pub = dbEntity.Publishers.Find(serachKey);

            if (pub != null)

            {
                textBoxPublisherDescription.Text = pub.PublisherDescription;
                textBoxPublisherName.Text = pub.PublisherName;
            }
            else
            {
                MessageBox.Show("Publisher Not found, Publisher not deleted ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Validation.ISValidText(textBoxPublisherName.Text) && Validation.ISValidText(textBoxPublisherDescription.Text))
            {
                Publisher pub = new Publisher();

                pub.PublisherName = textBoxPublisherName.Text;
                pub.PublisherDescription = textBoxPublisherDescription.Text;

                dbEntity.Publishers.Add(pub);
                dbEntity.SaveChanges();
                MessageBox.Show("Publisher successfully saved. ");
            }
            else
            {
                MessageBox.Show("Publisher not updated, please enter valid information. ");
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Validation.ISValidText(textBoxPublisherName.Text) && Validation.ISValidText(textBoxPublisherDescription.Text))
            {
                int serachKey = Convert.ToInt16(maskedTextBoxPublisherID.Text);

                Publisher pub = dbEntity.Publishers.Find(serachKey);

                if (pub != null)
                {

                    pub.PublisherName = textBoxPublisherName.Text;
                    pub.PublisherDescription = textBoxPublisherDescription.Text;

                    dbEntity.SaveChanges();

                    MessageBox.Show("Publisher successfully updated ");
                }
                else
                {
                    MessageBox.Show("Publisher Not found, Publisher not updated ");
                }

            }
            else
            {
                MessageBox.Show("Publisher not updated, please enter valid information. ");
            }
        }   

        private void button5_Click(object sender, EventArgs e)
        {
            listViewPublishers.Items.Clear();

            foreach (var pub in dbEntity.Publishers)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(pub.PublisherID));

                item.SubItems.Add(pub.PublisherName);
                item.SubItems.Add(pub.PublisherDescription);
                listViewProducts.Items.Add(item);

            }
        }

        private void buttonSaveAuthor_Click(object sender, EventArgs e)
        {
            if (Validation.ISValidText(textBoxAuthorFirstName.Text) && Validation.ISValidText(textBoxAuthorLastName.Text))
            {
                Author aut = new Author();
                aut.FirstName = textBoxAuthorFirstName.Text;
                aut.LastName = textBoxAuthorLastName.Text;

                dbEntity.Authors.Add(aut);
                dbEntity.SaveChanges();
                MessageBox.Show("Author successfully saved. ");

            }
            else
            {
                MessageBox.Show("Author not updated, please enter valid information. ");
            }
            
        }

        private void buttonUpdateAuthor_Click(object sender, EventArgs e)
        {
            if (Validation.ISValidText(textBoxAuthorFirstName.Text) && Validation.ISValidText(textBoxAuthorLastName.Text))
            {
                int serachKey = Convert.ToInt16(maskedTextBoxAuthorID.Text);

                Author aut = dbEntity.Authors.Find(serachKey);

                if (aut != null)
                {
                    aut.FirstName = textBoxAuthorFirstName.Text;
                    aut.LastName = textBoxAuthorLastName.Text;

                    dbEntity.SaveChanges();

                    MessageBox.Show("Author successfully updated ");
                }
                else
                {
                    MessageBox.Show("Author Not found, Author not updated ");
                }

            }
            else
            {
                MessageBox.Show("Author not updated, please enter valid information. ");
            }
           
        }

        private void buttonDeleteAuthor_Click(object sender, EventArgs e)
        {
            int serachKey = Convert.ToInt16(maskedTextBoxAuthorID.Text);

            Author aut = dbEntity.Authors.Find(serachKey);

            if (aut != null)
            {

                dbEntity.Authors.Remove(aut);
                dbEntity.SaveChanges();

                MessageBox.Show("Author successfully deleted ");
            }
            else
            {
                MessageBox.Show("Author Not found, Author not deleted ");
            }
        }

        private void buttonListAuthor_Click(object sender, EventArgs e)
        {
            listViewAuthors.Items.Clear();

            foreach (var aut in dbEntity.Authors)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(aut.AuthorID));
                
                item.SubItems.Add(aut.FirstName);
                item.SubItems.Add(aut.LastName);
                listViewProducts.Items.Add(item);

            }
        }

        private void buttonSearchAuthor_Click(object sender, EventArgs e)
        {

            int serachKey = Convert.ToInt16(maskedTextBoxAuthorID.Text);

            Author aut = dbEntity.Authors.Find(serachKey);

            if (aut != null)
            {
                 textBoxAuthorFirstName.Text = aut.FirstName;
                 textBoxAuthorLastName.Text = aut.LastName;
                
            }
            else
            {
                MessageBox.Show("Author Not found");
            }
        }

        private void buttonSaveCategory_Click(object sender, EventArgs e)
        {
            if (Validation.ISValidText(textBoxCategoryDescription.Text) )
            {
                Category cat = new Category();
                cat.CategoryDescription = textBoxCategoryDescription.Text;


                dbEntity.Categories.Add(cat);
                dbEntity.SaveChanges();
                MessageBox.Show("Category successfully saved. ");
            }
            else
            {
                MessageBox.Show("Category not updated, please enter valid information. ");
            }
            

        }

        private void buttonUpdateCategory_Click(object sender, EventArgs e)
        {
            if (Validation.ISValidText(textBoxCategoryDescription.Text))
            {
                int serachKey = Convert.ToInt16(maskedTextBoxCategoryID.Text);

                Category cat = dbEntity.Categories.Find(serachKey);

                if (cat != null)
                {
                    cat.CategoryDescription = textBoxCategoryDescription.Text;

                    dbEntity.SaveChanges();

                    MessageBox.Show("Category successfully updated ");
                }
                else
                {
                    MessageBox.Show("Category Not found, Category not updated ");
                }
            }
            else
            {
                MessageBox.Show("Category not updated, please enter valid information. ");
            }
           
        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            int serachKey = Convert.ToInt16(maskedTextBoxCategoryID.Text);

            Category cat = dbEntity.Categories.Find(serachKey);

            if (cat != null)
            {

                dbEntity.Categories.Remove(cat);
                dbEntity.SaveChanges();

                MessageBox.Show("Category successfully deleted ");
            }
            else
            {
                MessageBox.Show("Category Not found, Category not deleted ");
            }
        }

        private void buttonListCategory_Click(object sender, EventArgs e)
        {
            listViewCategory.Items.Clear();

            foreach (var aut in dbEntity.Categories)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(aut.CategoryID));

                item.SubItems.Add(aut.CategoryDescription);
            

                listViewProducts.Items.Add(item);

            }
        }

        private void buttonSearchCategory_Click(object sender, EventArgs e)
        {

            int serachKey = Convert.ToInt16(maskedTextBoxCategoryID.Text);

            Category cat = dbEntity.Categories.Find(serachKey);

            if (cat != null)
            {
                textBoxCategoryDescription.Text = cat.CategoryDescription;


            }
            else
            {
                MessageBox.Show("Category Not found");
            }
        }
    }
}
