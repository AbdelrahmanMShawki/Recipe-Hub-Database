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
    public partial class AddRecipeForm : Form
    {
        chefController controller;
        HelloChefForm hello;
        public AddRecipeForm(HelloChefForm hello)
        {
            this.hello = hello; 
            InitializeComponent();
            controller = new chefController();
           

        }

        private void AddRecipeForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            DataTable dt = controller.veiwrecipes();
            listBox1.DataSource = dt;
            listBox1.Refresh();
        }

    

        private void share_Click(object sender, EventArgs e)
        {
            int result = controller.ShareRecipe(titlebox.Text, genrebox.Text, Int16.Parse(authorbox.Text));
            if (result == 0)
            {
                MessageBox.Show("Insertion Failed");
            }
            else
            {
                MessageBox.Show("Insertion Completed Successfully");
            }
        }
    }
}
