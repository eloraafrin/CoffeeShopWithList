using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopWithList
{
    public partial class CoffeeShopUi : Form
    {
        public CoffeeShopUi()
        {
            InitializeComponent();
        }

        List<string> customerNames = new List<string>();
        List<int> contacts = new List<int>();
        List<string> addresses = new List<string>();
        List<string> orders = new List<string>();
        List<int> quantities = new List<int>();
        List<double> prices = new List<double>();
        List<string> allData = new List<string>();

        int price;
        int i = 1;
        private void addDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                 customerNames.Add(customerNameTextBox.Text);
                    contacts.Add(Convert.ToInt32 (contactNoTextBox.Text));
                    addresses.Add(addressTextBox.Text);
                    orders.Add(orderComboBox.Text);
                    quantities.Add(Convert.ToInt32(quantityTextBox.Text));

                      if (orders.Last().Contains("Black"))
                        {
                           price = quantities[i] * 120;
                           prices.Add(price);
                        }
                      else if (orders.Last().Contains("Cold"))
                        {
                            price = quantities[i] * 120;
                            prices.Add(price);
                        }

                      else if (orders.Last().Contains("Hot"))
                        {
                            price = quantities[i] * 120;
                            prices.Add(price);
                        }

                      else if (orders.Last().Contains("Regular"))
                        {
                            price = quantities[i] * 120;
                            prices.Add(price);
                        }

                    showRichTextBox.Text="\nPayment Status\n"+(i+1)+ "\nCustomer Name: "+customerNames[i]+"\nContact No: "
                        +contacts[i]+"\nAddress: "+addresses[i]+"\nOrder: "+orders[i]+"\nQuantity: "+quantities[i]+"\nTotal: "+prices[i];


                    allData.Add(showRichTextBox.Text);
                    i++;
                    //Clear();

                }

                

                  

                 /*   if (orders.Last().Equals("Black"))
                    {
                        price = quantities.Last() * 120;
                        prices.Add(price);
                    }

                    else if (orders.Last().Equals("Cold"))
                    {
                        price = quantities.Last() * 100;
                        prices.Add(price);
                    }

                    else if (orders.Last().Equals("Hot"))
                    {
                        price = quantities.Last() * 90;
                        prices.Add(price);
                    }

                    else if (orders.Last().Equals("Regular"))
                    {
                        price = quantities.Last() * 80;
                        prices.Add(price);
                    }

                    showRichTextBox.Text = "\nPayment Status\n" + i + "\nCustomer Name: " + customerNames.Last() + "\nContact No: "
                        + contacts.Last() + "\nAddress: " + addresses.Last() + "\nOrder: " + orders.Last() + "\nQuantity: " + quantities.Last() + "\nTotal: " + prices.Last();
                    i++;
                    Clear();
                    */
                
            
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Clear()
        {
            customerNameTextBox.Text = "";
            contactNoTextBox.Text = "";
            addressTextBox.Text = "";
            orderComboBox.Text = "";
            quantityTextBox.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            showRichTextBox.Text = "        Payment Status";
            foreach (var Data in allData)
            {
                showRichTextBox.Text += Data;

            }
        }
    }
}
