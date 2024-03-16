using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Data_Structures
{
    public partial class FoodForm : Form
    {
        public static DynamicArray<Food> foodList = new DynamicArray<Food>();
        private bool IsShown = false;
        private int shown = 0;
        public FoodForm()
        {
            InitializeComponent();

        }
        private void ShowFood()
        {
            for (int i = shown; i < foodList.Count; i++)
            {
                Food food = foodList[i];

                Panel panel = new Panel();
                panel.Margin = new System.Windows.Forms.Padding(10, 10, 20, 20);
                panel.Size = new System.Drawing.Size(240, 205);

                Label foodName = new Label();
                foodName.Size = new Size(240, 29);
                foodName.Dock = DockStyle.Bottom;
                foodName.ForeColor = Color.FromArgb(214, 155, 15);
                foodName.Text = food.foodName;
                foodName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                foodName.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                foodName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                foodName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                foodName.Click += new System.EventHandler(this.FoodLink_Click);

                PictureBox picture = new PictureBox();
                picture.Dock = DockStyle.Fill;
                picture.BackColor = Color.White;
                picture.LoadAsync(food.foodPic);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Click += new System.EventHandler(Food_Click);

                panel.Controls.Add(foodName);
                panel.Controls.Add(picture);


                flowLayoutPanel1.Controls.Add(panel);
                shown = i + 1;
            }
        }

        private void FoodLink_Click(object sender, EventArgs e)
        {
            var label = sender as Label;
            int index = label.Parent.TabIndex;

            string link = foodList[index].link;
            try
            {
                System.Diagnostics.Process.Start(link);

            }
            catch (System.ComponentModel.Win32Exception)
            {

                MessageBox.Show("Error: Cannot open this URL.");
            }

        }

        public static void SaveFoodMenu()
        {
            using (var MenuWriter = new StreamWriter("Food_Menu.txt", false))
            {
                foreach (Food food in foodList)
                {
                    MenuWriter.WriteLine(food.foodName);
                    MenuWriter.WriteLine(food.foodType);
                    MenuWriter.WriteLine(food.foodPrice);
                    MenuWriter.WriteLine(food.foodPic);
                    MenuWriter.WriteLine(food.link);
                    
                }
            }
        }
        public static void LoadFoodMenu()
        {

            try
            {
                using (var MenuReader = new StreamReader("Food_Menu.txt"))
                {
                    string foodName;
                    string foodType;
                    int price;
                    string foodPic;
                    string link;

                    foodName = MenuReader.ReadLine();
                    while (foodName != null)
                    {
                        foodType = MenuReader.ReadLine();
                        price = int.Parse(MenuReader.ReadLine());
                        foodPic = MenuReader.ReadLine();
                        link = MenuReader.ReadLine();

                        foodList.Add(new Food(foodName, foodType, price, foodPic , link));

                        foodName = MenuReader.ReadLine();

                    }

                }
            }
            catch (FileNotFoundException)
            {

                using (var MenuWriter = new StreamWriter("Food_Menu.txt", false))
                { }
            }


        }

        public static void AddFood(string name , string type , int price , string foodPic , string link) {
            foodList.Add(new Food(name, type, price, foodPic, link));

        }


        private void FoodForm_Load(object sender, EventArgs e)
        {
            if (IsShown == false)
            {
                ShowFood();
                IsShown = true;
            }

        }

        private void Food_Click(object sender, EventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            int index = picture.Parent.TabIndex;
            string name = foodList[index].foodName;
            string type = foodList[index].foodType;
            int price = foodList[index].foodPrice;
            string pictureURL = foodList[index].foodPic;
            string link = foodList[index].link;
            BuyForm buyForm = new BuyForm(name,type,price , pictureURL, link);
            buyForm.Show();
        }

        private void FoodForm_VisibleChanged(object sender, EventArgs e)
        {
            ShowFood();
        }
    }
    public class Food
    {
        public string foodName { get; set; }
        public string foodType { get; set; }
        public int foodPrice { get; set; }
        public string foodPic;
        public string link;
        public Food(string foodName, string foodType, int foodPrice, string foodPic, string link)
        {
            this.foodName = foodName;
            this.foodType = foodType;
            this.foodPrice = foodPrice;
            this.foodPic = foodPic;
            this.link = link;
        }
    }
}

