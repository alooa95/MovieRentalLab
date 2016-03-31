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
    public partial class frmMovieInventory : Form
    {
        frmCustomerList customerList = new frmCustomerList();
        Movie newMovie;

        public frmMovieInventory()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            lblIntructions.Text = "Instructions:\n" + "   To add: Please provide inputs to all fields.\n" +
                "   To delete: Please provide the title and year inputs.\n" +
                "   To search: Please provide either title, actor(s)/actress(es),\n" +
                "            genre(s), or year.";
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerList.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmMain.movieRental.saveMoviesFile();

            // if frmMain was previously opened, show the form and hide this form
            foreach (Form form in Application.OpenForms)
            {
                if (form is frmMain)
                    form.Visible = true;
            }
            this.Hide();

        }

        

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            newMovie = new Movie(txtTitle.Text, int.Parse(txtReleaseYear.Text), txtActor.Text, txtGenre.Text);
            
           MessageBox.Show(frmMain.movieRental.addMovieToSystem(newMovie));

            txtTitle.Text = "";
            txtReleaseYear.Text = "";
            txtActor.Text = "";
            txtGenre.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
