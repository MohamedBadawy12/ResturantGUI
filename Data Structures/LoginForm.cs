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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void Login() {
            if (usernameTextBox.Text == "admin")
            {
                userNameError.Visible = false;

                if (passwordTextBox.Text == "admin")
                {
                    passwordError.Visible = false;

                    AdminFormTest admin = new AdminFormTest();
                    admin.Show();
                    this.Close();
                }

                else
                    passwordError.Visible = true;

            }
            else
                userNameError.Visible = true;

        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            userIcon.IconColor = Color.Black;
            ChangeBackColor();



        }
        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            userIcon.IconColor = Color.FromArgb(163, 120, 8);


        }



        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            passwordIcon.IconColor = Color.Black;
            passwordIcon.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            ChangeBackColor();

        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            passwordIcon.IconColor = Color.FromArgb(163, 120, 8);
            passwordIcon.IconChar = FontAwesome.Sharp.IconChar.Lock;


        }
        private void ChangeBackColor() {
            this.BackColor = Color.FromArgb(46, 45, 45);
            loginPanel.BackColor = Color.FromArgb(230, 173, 30);
            loginButton.BackColor = Color.FromArgb(54, 53, 50);
            loginButton.ForeColor = Color.White;
        }



        private void Login_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
