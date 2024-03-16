namespace Data_Structures
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginPanel = new System.Windows.Forms.Panel();
            this.passwordError = new System.Windows.Forms.Label();
            this.userNameError = new System.Windows.Forms.Label();
            this.passwordIcon = new FontAwesome.Sharp.IconPictureBox();
            this.userIcon = new FontAwesome.Sharp.IconPictureBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPanel.Controls.Add(this.passwordError);
            this.loginPanel.Controls.Add(this.userNameError);
            this.loginPanel.Controls.Add(this.passwordIcon);
            this.loginPanel.Controls.Add(this.userIcon);
            this.loginPanel.Controls.Add(this.passwordTextBox);
            this.loginPanel.Controls.Add(this.usernameTextBox);
            this.loginPanel.Controls.Add(this.panel2);
            this.loginPanel.Location = new System.Drawing.Point(45, 49);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(10);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(257, 334);
            this.loginPanel.TabIndex = 0;
            // 
            // passwordError
            // 
            this.passwordError.AutoSize = true;
            this.passwordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordError.ForeColor = System.Drawing.Color.Red;
            this.passwordError.Location = new System.Drawing.Point(221, 142);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(25, 31);
            this.passwordError.TabIndex = 8;
            this.passwordError.Text = "*";
            this.passwordError.Visible = false;
            // 
            // userNameError
            // 
            this.userNameError.AutoSize = true;
            this.userNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameError.ForeColor = System.Drawing.Color.Red;
            this.userNameError.Location = new System.Drawing.Point(221, 84);
            this.userNameError.Name = "userNameError";
            this.userNameError.Size = new System.Drawing.Size(25, 31);
            this.userNameError.TabIndex = 7;
            this.userNameError.Text = "*";
            this.userNameError.Visible = false;
            // 
            // passwordIcon
            // 
            this.passwordIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.passwordIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(120)))), ((int)(((byte)(8)))));
            this.passwordIcon.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.passwordIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(120)))), ((int)(((byte)(8)))));
            this.passwordIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.passwordIcon.IconSize = 27;
            this.passwordIcon.Location = new System.Drawing.Point(17, 143);
            this.passwordIcon.Name = "passwordIcon";
            this.passwordIcon.Size = new System.Drawing.Size(27, 30);
            this.passwordIcon.TabIndex = 6;
            this.passwordIcon.TabStop = false;
            // 
            // userIcon
            // 
            this.userIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.userIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(120)))), ((int)(((byte)(8)))));
            this.userIcon.IconChar = FontAwesome.Sharp.IconChar.User;
            this.userIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(120)))), ((int)(((byte)(8)))));
            this.userIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userIcon.IconSize = 27;
            this.userIcon.Location = new System.Drawing.Point(17, 85);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(27, 30);
            this.userIcon.TabIndex = 5;
            this.userIcon.TabStop = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(74, 153);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(141, 20);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_Enter);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(74, 95);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(141, 20);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.Enter += new System.EventHandler(this.usernameTextBox_Enter);
            this.usernameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_Enter);
            this.usernameTextBox.Leave += new System.EventHandler(this.usernameTextBox_Leave);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.loginButton);
            this.panel2.Location = new System.Drawing.Point(94, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 25);
            this.panel2.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.loginButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.ForeColor = System.Drawing.Color.Black;
            this.loginButton.Location = new System.Drawing.Point(0, 0);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(97, 25);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(353, 424);
            this.Controls.Add(this.loginPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(369, 463);
            this.MinimumSize = new System.Drawing.Size(369, 463);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button loginButton;
        private FontAwesome.Sharp.IconPictureBox passwordIcon;
        private FontAwesome.Sharp.IconPictureBox userIcon;
        private System.Windows.Forms.Label passwordError;
        private System.Windows.Forms.Label userNameError;
    }
}