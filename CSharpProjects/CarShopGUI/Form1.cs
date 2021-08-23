using CarClassLibrary2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        Store store = new Store();
        BindingSource carInventoryBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Price_Click(object sender, EventArgs e)
        {

        }

        private void btn_create_car_Click(object sender, EventArgs e)
        {
            try
            {
                Car c = new Car(txt_make.Text, txt_model.Text, decimal.Parse(txt_price.Text), bool.Parse(txt_isNew.Text), txt_color.Text);


                store.CarList.Add(c);
                carInventoryBindingSource.ResetBindings(false);

                MessageBox.Show("Created");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
            
        }

        private void btn_AddToCart_Click(object sender, EventArgs e)
        {
            //get the selected item from inventory
            //add that item to the cart
            var selected = (Car)lst_inventory.SelectedItem;
            store.ShoppingList.Add(selected);
            //update the list box control
            cartBindingSource.ResetBindings(false);
            
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
           decimal total =store.Chechout();
            lbl_total.Text = "$" +total.ToString();
            cartBindingSource.ResetBindings(false);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carInventoryBindingSource.DataSource = store.CarList;
            cartBindingSource.DataSource = store.ShoppingList;

            lst_inventory.DataSource = carInventoryBindingSource;
            lst_inventory.DisplayMember = ToString();

           
            lst_shoppingCart.DataSource = cartBindingSource;
            lst_shoppingCart.DisplayMember = ToString();
        }
    }
}
