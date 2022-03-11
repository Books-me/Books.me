using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Books.me.Resources.Controller
{
    public partial class SingleBookForm : Form
    {
        public SingleBookForm()
        {
            InitializeComponent();
        }

        private void SingleBookForm_Load(object sender, EventArgs e)
        {
           
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePageForm homePageForm = new HomePageForm();
            homePageForm.Closed += (s, args) => this.Close();
            homePageForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pageCountIcon_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToLibrary_Click(object sender, EventArgs e)
        {

        }
    }
}
