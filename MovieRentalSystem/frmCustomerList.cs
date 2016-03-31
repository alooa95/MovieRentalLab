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
    public partial class frmCustomerList : Form
    {

        public frmCustomerList()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        Customer customer;

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is frmCustomerList)
                    form.Visible = true;
            }
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmMain.customerAdd.saveCustomerFile();
            foreach (Form form in Application.OpenForms)
            {
                if (form is frmMain)
                    form.Visible = true;
            }
            this.Hide();
        }

        private void btnMovieInventory_Click(object sender, EventArgs e)
        {

            foreach (Form form in Application.OpenForms)
            {
                if (form is frmMovieInventory)
                    form.Visible = true;
            }
            this.Hide();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            customer = new Customer(txtName.Text, txtAddress.Text, txtCityState.Text, int.Parse(txtZipcode.Text), DateTime.Parse(txtDOB.Text));
            MessageBox.Show(frmMain.customerAdd.addCustomerToSystem(customer));

        }


    }
}
