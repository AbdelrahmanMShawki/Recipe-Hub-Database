using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{ 
    public partial class HelloChefForm : Form
    {
        LoginForm login; 
        Color backgroundColor = ColorTranslator.FromHtml("#f0e8db");
        public HelloChefForm(LoginForm login)
        {
            InitializeComponent();
            this.login = login;
            //Image image = Image.FromFile(@"..\..\Resources\Images\ai-generated-chef-hat-clipart-design-illustration-free-png.webp");
            //mainpicture.Image = image;
            string imagePath = @"C:\Users\Abdelrahman\OneDrive\Desktop\Fall 2024\Database\Project\Code Real\DBapplication\Resources\Images\chefHat.jpg"; // Use PNG format for better compatibility
            Image image = Image.FromFile(imagePath);
            mainpicture.Image = image;
            mainpicture.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HelloChef_Load(object sender, EventArgs e)
        {

        }

        private void HelloChefForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
        }

        private void AddRecipe_Click(object sender, EventArgs e)
        {
            Form addrecipe = new AddRecipeForm(this);
            addrecipe.Show();
            this.Hide();
        }
    }
}
