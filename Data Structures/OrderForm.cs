using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structures
{
    public partial class OrderForm : Form
    {
        public static DynamicArray<Order> orderList = new DynamicArray<Order>();
        private int shown = 0;
        private int deliveryTime = 10;
        public OrderForm()
        {
            InitializeComponent();
        }
        public OrderForm(string name,int price,string type,string picture , string link)
        {
            InitializeComponent();
            Order newOrder = new Order(name, price, type, picture, link);
            orderList.Add(newOrder);

        }

        private void ShowOrder()
        {
            for(int i = shown; i < orderList.Count; i++)
            {
                Order order = orderList[i];
                
                Panel panel = new Panel();
                panel.Margin = new System.Windows.Forms.Padding(10, 10, 20, 20);
                panel.Size = new System.Drawing.Size(240, 205);


                Label orderName = new Label();
                orderName.Size = new Size(240, 29);
                orderName.Dock = DockStyle.Bottom;
                orderName.ForeColor = Color.FromArgb(214, 155, 15);
                orderName.Text = order.orderName;
                orderName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                orderName.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                orderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                orderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                orderName.Click += new System.EventHandler(OrderLink_Click);

                PictureBox picture = new PictureBox();
                picture.Dock = DockStyle.Fill;
                picture.BackColor = Color.White;
                picture.LoadAsync(order.orderPictureURL);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                //picture.Click += new System.EventHandler(Food_Click);

                panel.Controls.Add(orderName);
                panel.Controls.Add(picture);


                flowLayoutPanel1.Controls.Add(panel);
                shown = i + 1;
            }
        }

        private void OrderLink_Click(object sender, EventArgs e)
        {
            var label = sender as Label;
            int index = label.Parent.TabIndex;

            string link = orderList[index].link;
            System.Diagnostics.Process.Start(link);
        }

        private void orderForm_Load(object sender, EventArgs e)
        {
            ShowOrder();
            deliveringTimer.Interval = deliveryTime;
            deliveringTimer.Start();

        }

        public class Order
        {
            public string orderName { get; set; }
            public string orderType { get; set; }
            public int orderPrice { get; set; }
            public string orderPictureURL;
            public string link;

            public static int totalPrice = 0;

            public Order(string orderName,int orderprice, string orderType, string orderPictureURL , string link)
            {
                this.orderName = orderName;
                this.orderPrice = orderprice;
                this.orderType = orderType;
                this.orderPictureURL = orderPictureURL;
                this.link = link;
                totalPrice += orderprice;
            }

        }



        private void OrderForm_VisibleChanged(object sender, EventArgs e)
        {
            ShowOrder();
            label1.Text = Order.totalPrice.ToString();


        }

        private void deliveringTimer_Tick(object sender, EventArgs e)
        {
            int deliveryIcon_X = deliveryIcon.Location.X;
            if (deliveryIcon_X >= delieveryPanel.Width)
            {
                deliveryIcon_X = 0;
            }
            deliveryIcon.Location = new Point(++deliveryIcon_X, deliveryIcon.Location.Y);

        }
    }
}
