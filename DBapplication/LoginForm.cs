using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBapplication
{
    public partial class LoginForm : Form
    {
        Welcome welcomeForm;
        Color backgroundColor = ColorTranslator.FromHtml("#f0e8db");
        public LoginForm(Welcome welcomeForm)
        {
            InitializeComponent();
            // Save previous Form
            this.welcomeForm = welcomeForm;
            // Top Right Picture
            Image TopRight = Image.FromFile(@"..\..\Resources\Images\Ramen2.png");
            TopRightPic.Image = TopRight;
            TopRightPic.SizeMode = PictureBoxSizeMode.Zoom;
            // Top Left picture
            Image TopLeft = Image.FromFile(@"..\..\Resources\Images\Chicken_Curry.png");
            TopLeftPic.Image = TopLeft;
            TopLeftPic.SizeMode = PictureBoxSizeMode.Zoom;
            // Bottom Left picture
            Image BottomLeft = Image.FromFile(@"..\..\Resources\Images\Breakfast.png");
            BottomLeftPic.Image = BottomLeft;
            BottomLeftPic.SizeMode = PictureBoxSizeMode.Zoom;
            // Bottom Right Picture
            Image BottomRight = Image.FromFile(@"..\..\Resources\Images\Ramen.png");
            BottomRightPic.Image = BottomRight;
            BottomRightPic.SizeMode = PictureBoxSizeMode.Zoom;


            // Form BG color
            this.BackColor = backgroundColor;

            // Text BG
            AreYouLabel.BackColor = backgroundColor;
        }

        private bool ShowPassword(bool check)
        {
            return PasswordTB.UseSystemPasswordChar = check;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {
            ShowPassword(ShowPasswordCB.Checked);
        }

        private void EmailTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTB_Enter(object sender, EventArgs e)
        {

            if (PasswordTB.Text == "Enter your Password") PasswordTB.Text = "";
            
        }

        private void PasswordTB_Leave(object sender, EventArgs e)
        {
            if (PasswordTB.Text == "")
                PasswordTB.Text = "Enter your Password";
            if (PasswordTB.Text == "Enter your Password") PasswordTB.UseSystemPasswordChar = false;
        }

        private void ShowPasswordCB_CheckedChanged(object sender, EventArgs e)
        {   if (PasswordTB.Text != "Enter your Password")
            ShowPassword(ShowPasswordCB.Checked);
        }

        private void EmailTB_Enter(object sender, EventArgs e)
        {
            if (EmailTB.Text == "Enter your email") 
                EmailTB.Text = "";
        }

        private void EmailTB_Leave(object sender, EventArgs e)
        {
            if (EmailTB.Text == "")
                EmailTB.Text = "Enter your email";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HelloChefForm chef1 = new HelloChefForm(this);
            chef1.Show();
            this.Hide();
        }
    }
}
