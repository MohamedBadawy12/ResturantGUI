using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Data_Structures
{

    public partial class MainForm : Form
    {   
        private bool FoodMenuIsClosed = true;
        private bool DrinksMenuIsClosed = true;
        private bool DessertMenuIsClosed = true;
        private bool OrderFormIsClosed = true;

        private FoodForm foodForm;
        private DrinksForm drinksForm;
        private DessertForm dessertForm;
        private OrderForm orderForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FoodForm.LoadFoodMenu();
            DrinksForm.LoadDrinksMenu();
            DessertForm.LoadDessertMenu();
            

            MakeFoodForm();
            MakeDrinksForm();
            MakeDessertForm();
            MakeOrderForm();

        }

        private void MakeOrderForm()
        {
            orderForm = new OrderForm();
            orderForm.TopLevel = false;
            panel2.Controls.Add(orderForm);
            orderForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            orderForm.Dock = DockStyle.Fill;


        }
        private void HideOrderForm()
        {

            orderForm.Hide();
            OrderFormIsClosed = true;


        }

        private void MakeFoodForm()
        {
                foodForm = new FoodForm();
                foodForm.TopLevel = false;
                panel2.Controls.Add(foodForm);
                foodForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                foodForm.Dock = DockStyle.Fill;


        }
        private void HideFoodForm() {

                foodForm.Hide();
            FoodMenuIsClosed = true;


        }


        private void MakeDrinksForm()
        {
                drinksForm = new DrinksForm();
                drinksForm.TopLevel = false;
                panel2.Controls.Add(drinksForm);
                drinksForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                drinksForm.Dock = DockStyle.Fill;
        }

        private void HideDrinksForm()
        {

                drinksForm.Hide();
            DrinksMenuIsClosed = true;


        }

        private void MakeDessertForm()
        {
                dessertForm = new DessertForm();
                dessertForm.TopLevel = false;
                panel2.Controls.Add(dessertForm);
                dessertForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                dessertForm.Dock = DockStyle.Fill;


        }
        private void HideDessertForm()
        {

                dessertForm.Hide();
            DessertMenuIsClosed = true;


        }

        private void UnStyleIcon(IconButton iconButton) {

                iconButton.IconColor = Color.WhiteSmoke;
                iconButton.ForeColor = Color.FromArgb(184, 123, 2);
                iconButton.TextImageRelation = TextImageRelation.ImageBeforeText;

        }
        private void StyleIcon(IconButton iconButton) {
            if (iconButton.IconColor == Color.WhiteSmoke)
            {
                iconButton.IconColor = Color.FromArgb(184, 123, 2);
                iconButton.ForeColor = Color.WhiteSmoke;
                iconButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            }
            else
            {
                iconButton.IconColor = Color.WhiteSmoke;
                iconButton.ForeColor = Color.FromArgb(184, 123, 2);
                iconButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            }

        }
        private void iconButton_Click(object sender, EventArgs e)
        {
            var iconButton = sender as IconButton;

            if (iconButton.Text == "Food")
            {

                if (FoodMenuIsClosed)
                {
                    foodForm.Show();
                    HideDrinksForm();
                    HideDessertForm();
                    HideOrderForm();

                    FoodMenuIsClosed = false;

                }

                else
                {
                    HideFoodForm();

                }
                StyleIcon(FoodMenu);
                    UnStyleIcon(drinksFormButton);
                    UnStyleIcon(dessertMenu);
                    UnStyleIcon(ordersButton);


            }
            else if (iconButton.Text == "Drinks") {

                if (DrinksMenuIsClosed)
                {
                    drinksForm.Show();
                    HideFoodForm();
                    HideDessertForm();
                    HideOrderForm();

                    DrinksMenuIsClosed = false;


                }

                else
                {
                    HideDrinksForm();

                }

                StyleIcon(drinksFormButton);
                UnStyleIcon(FoodMenu);
                UnStyleIcon(dessertMenu);
                UnStyleIcon(ordersButton);

            }

            else if (iconButton.Text == "Desserts"){
                if (DessertMenuIsClosed)
                {
                    dessertForm.Show();
                    HideDrinksForm();
                    HideFoodForm();
                    HideOrderForm();

                    DessertMenuIsClosed = false;

                }

                else
                {
                    HideDessertForm();
                }
                StyleIcon(dessertMenu);
                UnStyleIcon(drinksFormButton);
                UnStyleIcon(FoodMenu);                UnStyleIcon(ordersButton);


            }
            else if (iconButton.Text == "My Orders")
            {
                if (OrderFormIsClosed)
                {
                    orderForm.Show();
                    HideDrinksForm();
                    HideFoodForm();
                    HideDessertForm();
                    OrderFormIsClosed = false;

                }

                else
                {
                    HideOrderForm();
                }
                StyleIcon(ordersButton);
                UnStyleIcon(drinksFormButton);
                UnStyleIcon(FoodMenu);
                UnStyleIcon(dessertMenu);

            }
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

        }



    }
}
