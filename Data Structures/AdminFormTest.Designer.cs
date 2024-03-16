namespace Data_Structures
{
    partial class AdminFormTest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.successLabel = new System.Windows.Forms.Label();
            this.descriptionError = new System.Windows.Forms.Label();
            this.saveButton = new FontAwesome.Sharp.IconButton();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.imageError = new System.Windows.Forms.Label();
            this.newImage = new System.Windows.Forms.PictureBox();
            this.imageIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkError = new System.Windows.Forms.Label();
            this.linkTextBox = new System.Windows.Forms.TextBox();
            this.linkIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.priceError = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nameError = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameIcon = new FontAwesome.Sharp.IconPictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.foodIcon = new FontAwesome.Sharp.IconPictureBox();
            this.drinksIcon = new FontAwesome.Sharp.IconPictureBox();
            this.dessertsIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageIcon)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linkIcon)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceIcon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameIcon)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertsIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(30, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 440);
            this.panel1.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.successLabel);
            this.panel9.Controls.Add(this.descriptionError);
            this.panel9.Controls.Add(this.saveButton);
            this.panel9.Controls.Add(this.descriptionTextBox);
            this.panel9.Controls.Add(this.addButton);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 283);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(277, 157);
            this.panel9.TabIndex = 8;
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(232)))), ((int)(((byte)(58)))));
            this.successLabel.Location = new System.Drawing.Point(105, 125);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(47, 15);
            this.successLabel.TabIndex = 1;
            this.successLabel.Text = "Added";
            this.successLabel.Visible = false;
            // 
            // descriptionError
            // 
            this.descriptionError.AutoSize = true;
            this.descriptionError.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionError.ForeColor = System.Drawing.Color.Red;
            this.descriptionError.Location = new System.Drawing.Point(245, 4);
            this.descriptionError.Name = "descriptionError";
            this.descriptionError.Size = new System.Drawing.Size(25, 31);
            this.descriptionError.TabIndex = 6;
            this.descriptionError.Text = "*";
            this.descriptionError.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.saveButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.saveButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.saveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.saveButton.IconSize = 39;
            this.saveButton.Location = new System.Drawing.Point(138, 73);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(49, 49);
            this.saveButton.TabIndex = 5;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.saveButton.MouseEnter += new System.EventHandler(this.ButtonEnterStyle);
            this.saveButton.MouseLeave += new System.EventHandler(this.ButtonLeaveStyle);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.White;
            this.descriptionTextBox.Location = new System.Drawing.Point(17, 16);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(226, 51);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.addButton.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.addButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.addButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addButton.IconSize = 39;
            this.addButton.Location = new System.Drawing.Point(67, 73);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(49, 49);
            this.addButton.TabIndex = 3;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            this.addButton.MouseEnter += new System.EventHandler(this.ButtonEnterStyle);
            this.addButton.MouseLeave += new System.EventHandler(this.ButtonLeaveStyle);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.imageError);
            this.panel5.Controls.Add(this.newImage);
            this.panel5.Controls.Add(this.imageIcon);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 227);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(277, 56);
            this.panel5.TabIndex = 7;
            // 
            // imageError
            // 
            this.imageError.AutoSize = true;
            this.imageError.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageError.ForeColor = System.Drawing.Color.Red;
            this.imageError.Location = new System.Drawing.Point(182, 7);
            this.imageError.Name = "imageError";
            this.imageError.Size = new System.Drawing.Size(25, 31);
            this.imageError.TabIndex = 4;
            this.imageError.Text = "*";
            this.imageError.Visible = false;
            // 
            // newImage
            // 
            this.newImage.BackColor = System.Drawing.Color.White;
            this.newImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.newImage.Location = new System.Drawing.Point(108, 6);
            this.newImage.Name = "newImage";
            this.newImage.Size = new System.Drawing.Size(70, 44);
            this.newImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newImage.TabIndex = 3;
            this.newImage.TabStop = false;
            this.newImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imageIcon
            // 
            this.imageIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.imageIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.imageIcon.IconChar = FontAwesome.Sharp.IconChar.Images;
            this.imageIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.imageIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imageIcon.Location = new System.Drawing.Point(25, 11);
            this.imageIcon.Name = "imageIcon";
            this.imageIcon.Size = new System.Drawing.Size(32, 32);
            this.imageIcon.TabIndex = 0;
            this.imageIcon.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.linkError);
            this.panel4.Controls.Add(this.linkTextBox);
            this.panel4.Controls.Add(this.linkIcon);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 171);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(277, 56);
            this.panel4.TabIndex = 6;
            // 
            // linkError
            // 
            this.linkError.AutoSize = true;
            this.linkError.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkError.ForeColor = System.Drawing.Color.Red;
            this.linkError.Location = new System.Drawing.Point(245, 7);
            this.linkError.Name = "linkError";
            this.linkError.Size = new System.Drawing.Size(25, 31);
            this.linkError.TabIndex = 3;
            this.linkError.Text = "*";
            this.linkError.Visible = false;
            // 
            // linkTextBox
            // 
            this.linkTextBox.Location = new System.Drawing.Point(80, 16);
            this.linkTextBox.Name = "linkTextBox";
            this.linkTextBox.Size = new System.Drawing.Size(163, 20);
            this.linkTextBox.TabIndex = 1;
            // 
            // linkIcon
            // 
            this.linkIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.linkIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.linkIcon.IconChar = FontAwesome.Sharp.IconChar.Link;
            this.linkIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.linkIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.linkIcon.Location = new System.Drawing.Point(25, 11);
            this.linkIcon.Name = "linkIcon";
            this.linkIcon.Size = new System.Drawing.Size(32, 32);
            this.linkIcon.TabIndex = 0;
            this.linkIcon.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.priceError);
            this.panel3.Controls.Add(this.priceTextBox);
            this.panel3.Controls.Add(this.priceIcon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 56);
            this.panel3.TabIndex = 5;
            // 
            // priceError
            // 
            this.priceError.AutoSize = true;
            this.priceError.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceError.ForeColor = System.Drawing.Color.Red;
            this.priceError.Location = new System.Drawing.Point(245, 7);
            this.priceError.Name = "priceError";
            this.priceError.Size = new System.Drawing.Size(25, 31);
            this.priceError.TabIndex = 3;
            this.priceError.Text = "*";
            this.priceError.Visible = false;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(80, 16);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(163, 20);
            this.priceTextBox.TabIndex = 1;
            // 
            // priceIcon
            // 
            this.priceIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.priceIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.priceIcon.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.priceIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.priceIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.priceIcon.Location = new System.Drawing.Point(25, 11);
            this.priceIcon.Name = "priceIcon";
            this.priceIcon.Size = new System.Drawing.Size(32, 32);
            this.priceIcon.TabIndex = 0;
            this.priceIcon.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nameError);
            this.panel2.Controls.Add(this.nameTextBox);
            this.panel2.Controls.Add(this.nameIcon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 56);
            this.panel2.TabIndex = 4;
            // 
            // nameError
            // 
            this.nameError.AutoSize = true;
            this.nameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameError.ForeColor = System.Drawing.Color.Red;
            this.nameError.Location = new System.Drawing.Point(245, 7);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(25, 31);
            this.nameError.TabIndex = 2;
            this.nameError.Text = "*";
            this.nameError.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(80, 16);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(163, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameIcon
            // 
            this.nameIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.nameIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.nameIcon.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.nameIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.nameIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.nameIcon.Location = new System.Drawing.Point(25, 11);
            this.nameIcon.Name = "nameIcon";
            this.nameIcon.Size = new System.Drawing.Size(32, 32);
            this.nameIcon.TabIndex = 0;
            this.nameIcon.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.foodIcon);
            this.flowLayoutPanel1.Controls.Add(this.drinksIcon);
            this.flowLayoutPanel1.Controls.Add(this.dessertsIcon);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(60, 5, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(277, 59);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // foodIcon
            // 
            this.foodIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.foodIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.foodIcon.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.foodIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.foodIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.foodIcon.Location = new System.Drawing.Point(70, 15);
            this.foodIcon.Margin = new System.Windows.Forms.Padding(10);
            this.foodIcon.Name = "foodIcon";
            this.foodIcon.Size = new System.Drawing.Size(32, 32);
            this.foodIcon.TabIndex = 1;
            this.foodIcon.TabStop = false;
            this.foodIcon.Click += new System.EventHandler(this.foodIcon_Click);
            // 
            // drinksIcon
            // 
            this.drinksIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.drinksIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.drinksIcon.IconChar = FontAwesome.Sharp.IconChar.Coffee;
            this.drinksIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.drinksIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.drinksIcon.Location = new System.Drawing.Point(122, 15);
            this.drinksIcon.Margin = new System.Windows.Forms.Padding(10);
            this.drinksIcon.Name = "drinksIcon";
            this.drinksIcon.Size = new System.Drawing.Size(32, 32);
            this.drinksIcon.TabIndex = 2;
            this.drinksIcon.TabStop = false;
            this.drinksIcon.Click += new System.EventHandler(this.drinksIcon_Click);
            // 
            // dessertsIcon
            // 
            this.dessertsIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dessertsIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.dessertsIcon.IconChar = FontAwesome.Sharp.IconChar.CookieBite;
            this.dessertsIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.dessertsIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dessertsIcon.Location = new System.Drawing.Point(174, 15);
            this.dessertsIcon.Margin = new System.Windows.Forms.Padding(10);
            this.dessertsIcon.Name = "dessertsIcon";
            this.dessertsIcon.Size = new System.Drawing.Size(32, 32);
            this.dessertsIcon.TabIndex = 3;
            this.dessertsIcon.TabStop = false;
            this.dessertsIcon.Click += new System.EventHandler(this.dessertsIcon_Click);
            // 
            // AdminFormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(336, 494);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(352, 533);
            this.MinimumSize = new System.Drawing.Size(352, 533);
            this.Name = "AdminFormTest";
            this.Text = "AdminFormTest";
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageIcon)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linkIcon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameIcon)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foodIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertsIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconPictureBox imageIcon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox linkTextBox;
        private FontAwesome.Sharp.IconPictureBox linkIcon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox priceTextBox;
        private FontAwesome.Sharp.IconPictureBox priceIcon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox nameTextBox;
        private FontAwesome.Sharp.IconPictureBox nameIcon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconPictureBox foodIcon;
        private FontAwesome.Sharp.IconPictureBox drinksIcon;
        private FontAwesome.Sharp.IconPictureBox dessertsIcon;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private FontAwesome.Sharp.IconButton addButton;
        private System.Windows.Forms.PictureBox newImage;
        private FontAwesome.Sharp.IconButton saveButton;
        private System.Windows.Forms.Label descriptionError;
        private System.Windows.Forms.Label imageError;
        private System.Windows.Forms.Label linkError;
        private System.Windows.Forms.Label priceError;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.Label successLabel;
    }
}