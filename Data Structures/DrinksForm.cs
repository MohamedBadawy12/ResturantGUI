using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structures
{
    public partial class DrinksForm : Form
    {

        public static DynamicArray<Drinks> drinksList = new DynamicArray<Drinks>();
        private int shown = 0;
        public DrinksForm()
        {
            InitializeComponent();
        }


        private void ShowDrinks()
        {
            for (int i = shown; i < drinksList.Count; i++)
            {
                Drinks drink = drinksList[i];

                Panel panel = new Panel();
                panel.Margin = new System.Windows.Forms.Padding(10, 10, 20, 20);
                panel.Size = new System.Drawing.Size(240, 205);


                Label drinkName = new Label();
                drinkName.Size = new Size(240, 29);
                drinkName.Dock = DockStyle.Bottom;
                drinkName.ForeColor = Color.FromArgb(214, 155, 15);
                drinkName.Text = drink.drinksName;
                drinkName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                drinkName.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                drinkName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                drinkName.Click += new System.EventHandler(DrinkLink_Click);

                PictureBox picture = new PictureBox();
                picture.Dock = DockStyle.Fill;
                picture.BackColor = Color.White;
                picture.LoadAsync(drink.drinksPic);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Click += new System.EventHandler(drinks_Click);

                panel.Controls.Add(drinkName);
                panel.Controls.Add(picture);


                flowLayoutPanel1.Controls.Add(panel);
                shown = i + 1;
            }
        }

        private void DrinkLink_Click(object sender, EventArgs e)
        {
            var label = sender as Label;
            int index = label.Parent.TabIndex;

            string link = drinksList[index].link;
            System.Diagnostics.Process.Start(link);
        }

        private void drinks_Click(object sender, EventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            int index = picture.Parent.TabIndex;
            string name = drinksList[index].drinksName;
            string type = drinksList[index].drinksType;
            int price = drinksList[index].drinksPrice;
            string pictureURL = drinksList[index].drinksPic;
            string link = drinksList[index].link;
            BuyForm buyForm = new BuyForm(name, type, price, pictureURL, link);
            buyForm.Show();
        }

        public static void SaveDrinksMenu()
        {
            using (var MenuWriter = new StreamWriter("Drinks_Menu.txt", false))
            {
                foreach (Drinks drinks in drinksList)
                {
                    MenuWriter.WriteLine(drinks.drinksName);
                    MenuWriter.WriteLine(drinks.drinksType);
                    MenuWriter.WriteLine(drinks.drinksPrice);
                    MenuWriter.WriteLine(drinks.drinksPic);
                    MenuWriter.WriteLine(drinks.link);
                }
            }
        }
        public static void LoadDrinksMenu()
        {
            try
            {
                using (var MenuReader = new StreamReader("Drinks_Menu.txt"))
                {
                    string drinksName;
                    string drinksType;
                    int price;
                    string drinksPic;
                    string link;
                    drinksName = MenuReader.ReadLine();
                    while (drinksName != null)
                    {
                        drinksType = MenuReader.ReadLine();
                        price = int.Parse(MenuReader.ReadLine());
                        drinksPic = MenuReader.ReadLine();
                        link = MenuReader.ReadLine();

                        drinksList.Add(new Drinks(drinksName, drinksType, price, drinksPic, link));

                        drinksName = MenuReader.ReadLine();

                    }
                }
            }
            catch (FileNotFoundException)
            {

                using (var MenuWriter = new StreamWriter("Drinks_Menu.txt", false)) { }
            }
        }

        public static void AddDrinks(string name, string type, int price ,string drinksPic , string link)
        {
            drinksList.Add(new Drinks(name, type, price, drinksPic,link));


        }

        private void drinksForm_Load(object sender, EventArgs e)
        {
            ShowDrinks();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DrinksForm_VisibleChanged(object sender, EventArgs e)
        {
            ShowDrinks();
        }
    }
    public class Drinks
    {
        public string drinksName { get; set; }
        public string drinksType { get; set; }
        public int drinksPrice { get; set; }
        public string drinksPic;
        public string link;

        public Drinks(string drinksName, string drinksType, int drinksPrice , string drinksPic, string link)
        {
            this.drinksName = drinksName;
            this.drinksType = drinksType;
            this.drinksPrice = drinksPrice;
            this.drinksPic = drinksPic;
            this.link = link;

        }
    }
}
