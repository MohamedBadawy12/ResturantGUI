using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Data_Structures
{
    public partial class AdminFormTest : Form
    {
        string img;
        string Type;
        public AdminFormTest()
        {
            InitializeComponent();
        }

        private void foodIcon_Click(object sender, EventArgs e)
        {
            Type = "Food";
            foodIcon.IconColor = Color.Black;
            drinksIcon.IconColor = Color.FromArgb(232, 173, 63);
            dessertsIcon.IconColor = Color.FromArgb(232, 173, 63);

        }

        private void drinksIcon_Click(object sender, EventArgs e)
        {
            Type = "Drinks";
            drinksIcon.IconColor = Color.Black;
            foodIcon.IconColor = Color.FromArgb(232, 173, 63);
            dessertsIcon.IconColor = Color.FromArgb(232, 173, 63);

        }

        private void dessertsIcon_Click(object sender, EventArgs e)
        {
            Type = "Desserts";
            dessertsIcon.IconColor = Color.Black;
            foodIcon.IconColor = Color.FromArgb(232, 173, 63);
            drinksIcon.IconColor = Color.FromArgb(232, 173, 63);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || priceTextBox.Text == "" || descriptionTextBox.Text == "" || linkTextBox.Text == "" || img == null || Type == null)
            {
                successLabel.Visible = false;


                if (nameTextBox.Text == "")
                    nameError.Visible = true;
                else
                    nameError.Visible = false;

                if (priceTextBox.Text == "")
                    priceError.Visible = true;
                else
                    priceError.Visible = false;

                if (descriptionTextBox.Text == "" )
                    descriptionError.Visible = true;
                else
                    descriptionError.Visible = false;

                if (linkTextBox.Text == "")
                    linkError.Visible = true;
                else
                    linkError.Visible = false;


                if (img == null)
                    imageError.Visible = true;
                else
                    imageError.Visible = false;

                if (Type == null)
                {
                    MessageBox.Show("Choose a type");
                }

            }
            else
            {
                nameError.Visible = false;
                priceError.Visible = false;
                descriptionError.Visible = false;
                linkError.Visible = false;
                imageError.Visible = false;

                try
                {
                    if (Type == "Food")
                    {
                        FoodForm.AddFood(nameTextBox.Text, descriptionTextBox.Text, (int.Parse(priceTextBox.Text)), img, linkTextBox.Text);
                        MessageBox.Show("Added!");
                    }
                    else if (Type == "Drinks")
                    {
                        DrinksForm.AddDrinks(nameTextBox.Text, descriptionTextBox.Text, (int.Parse(priceTextBox.Text)), img, linkTextBox.Text);
                        MessageBox.Show("Added!");
                    }

                    else if (Type == "Desserts")
                    {
                        DessertForm.AddDessert(nameTextBox.Text, descriptionTextBox.Text, (int.Parse(priceTextBox.Text)), img, linkTextBox.Text);
                        MessageBox.Show("Added!");
                    }
                    successLabel.Text = "Added";
                    successLabel.Visible = true;






                }
                catch (System.FormatException)
                {

                    MessageBox.Show("Error : Invalid inputs");
                }


            }


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            FoodForm.SaveFoodMenu();
            DrinksForm.SaveDrinksMenu();
            DessertForm.SaveDessertMenu();

            successLabel.Text = "Saved";
            successLabel.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                img = ofd.FileName;
                newImage.LoadAsync(img);
            }
        }

        private void ButtonEnterStyle(object sender, EventArgs e)
        {
            var iconBtn = sender as FontAwesome.Sharp.IconButton;
            iconBtn.IconColor = Color.FromArgb(46, 45, 45);
            iconBtn.BackColor = Color.FromArgb(232, 173, 63);
        }

        private void ButtonLeaveStyle(object sender, EventArgs e)
        {
            var iconBtn = sender as FontAwesome.Sharp.IconButton;
            iconBtn.BackColor = Color.FromArgb(46, 45, 45);
            iconBtn.IconColor = Color.FromArgb(232, 173, 63);
        }

        private void descriptionTextBox_Click(object sender, EventArgs e)
        {
            descriptionTextBox.Text = "";
        }
    }
}
