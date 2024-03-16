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
    public partial class DessertForm : Form
    {


        public static DynamicArray<Dessert> dessertList = new DynamicArray<Dessert>();
        private bool IsShown = false;
        int shown = 0;
        public DessertForm()
        {
            InitializeComponent();
        }
        private void ShowDessert()
        {
            for (int i = shown; i < dessertList.Count; i++)
            {
                Dessert dessert = dessertList[i];

                Panel panel = new Panel();
                panel.Margin = new System.Windows.Forms.Padding(10, 10, 20, 20);
                panel.Size = new System.Drawing.Size(240, 205);


                Label dessertName = new Label();
                dessertName.Size = new Size(240, 29);
                dessertName.Dock = DockStyle.Bottom;
                dessertName.ForeColor = Color.FromArgb(214, 155, 15);
                dessertName.Text = dessert.dessertName;
                dessertName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                dessertName.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dessertName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                dessertName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                dessertName.Click += new System.EventHandler(DessertLink_Click);


                PictureBox picture = new PictureBox();
                picture.Dock = DockStyle.Fill;
                picture.BackColor = Color.White;
                picture.LoadAsync(dessert.dessertPic);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Click += new System.EventHandler(Dessert_Click);

                panel.Controls.Add(dessertName);
                panel.Controls.Add(picture);


                flowLayoutPanel1.Controls.Add(panel);
                shown = i + 1;
            }
        }

        private void DessertLink_Click(object sender, EventArgs e)
        {
            var label = sender as Label;
            int index = label.Parent.TabIndex;

            string link = dessertList[index].link;
            System.Diagnostics.Process.Start(link);
        }

        public static void SaveDessertMenu()
        {
            using (var MenuWriter = new StreamWriter("Dessert_Menu.txt", false))
            {
                foreach (Dessert dessert in dessertList)
                {
                    MenuWriter.WriteLine(dessert.dessertName);
                    MenuWriter.WriteLine(dessert.dessertType);
                    MenuWriter.WriteLine(dessert.dessertPrice);
                    MenuWriter.WriteLine(dessert.dessertPic);
                    MenuWriter.WriteLine(dessert.link);

                }
            }
        }
        public static void LoadDessertMenu()
        {

            try
            {
                using (var MenuReader = new StreamReader("Dessert_Menu.txt"))
                {
                    string dessertName;
                    string dessertType;
                    int price;
                    string dessertPic;
                    string link;
                    dessertName = MenuReader.ReadLine();
                    while (dessertName != null)
                    {
                        dessertType = MenuReader.ReadLine();
                        price = int.Parse(MenuReader.ReadLine());
                        dessertPic = MenuReader.ReadLine();
                        link = MenuReader.ReadLine();

                        dessertList.Add(new Dessert(dessertName, dessertType, price, dessertPic,link));

                        dessertName = MenuReader.ReadLine();

                    }

                }
            }
            catch (FileNotFoundException)
            {

                using (var MenuWriter = new StreamWriter("Dessert_Menu.txt", false)) { }
                
            }

        }

        public static void AddDessert(string name, string type, int price, string dessertPic, string link)
        {
            dessertList.Add(new Dessert(name, type, price, dessertPic, link));


        }

        private void DessertForm_Load(object sender, EventArgs e)
        {
            if (IsShown == false)
            {
                ShowDessert();
                IsShown = true;
            }
        }

        private void Dessert_Click(object sender, EventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            int index = picture.Parent.TabIndex;
            string name = dessertList[index].dessertName;
            string type = dessertList[index].dessertType;
            int price = dessertList[index].dessertPrice;
            string pictureURL = dessertList[index].dessertPic;
            string link = dessertList[index].link;

            BuyForm buyForm = new BuyForm(name, type, price, pictureURL, link);
            buyForm.Show();
        }

        private void DessertForm_VisibleChanged(object sender, EventArgs e)
        {
            ShowDessert();
        }
    }
    public class Dessert
    {
        public string dessertName { get; set; }
        public string dessertType { get; set; }
        public int dessertPrice { get; set; }
        public string dessertPic;
        public string link;
        public Dessert(string dessertName, string dessertType, int dessertPrice, string dessertPic, string link)
        {
            this.dessertName = dessertName;
            this.dessertType = dessertType;
            this.dessertPrice = dessertPrice;
            this.dessertPic = dessertPic;
            this.link = link;
        }
    }
}

