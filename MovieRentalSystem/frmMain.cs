using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRentalSystem
{
    public partial class frmMain : Form
    {
        // Public MovieRentalSystem object to be shared among forms
        public static MovieRentalSystem movieRental;
        public static MovieRentalSystem customerAdd;

        frmMovieInventory movieInventory = new frmMovieInventory();

        public frmMain()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";

            movieRental = new MovieRentalSystem();
            customerAdd = new MovieRentalSystem();


            this.Hide();
            movieInventory.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
