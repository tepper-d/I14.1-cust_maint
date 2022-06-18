using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

/* ***********************************************
 * CIS123: Intro to Object-oriented Programming
 * Chapter 14: How to work with inheritance
 * Exercise 14-1 Create a Customer Maintenance 
 *      application that uses inheritance
 * Dominique Tepper, 17JUN2022
 * 
 * 5A. Modify btnSave_Click event handler to
 *     create a new customer from valid input.
 * **********************************************/

namespace CustomerMaintenance
{
    public partial class frmAddWholesale : Form
    {
        public frmAddWholesale()
        {
            InitializeComponent();
        }

        private Customer customer = null;

        public Customer GetNewCustomer()
        {
            this.ShowDialog();
            return customer;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (IsValidData())
            {
                customer = new WholesaleCustomer(txtFirstName.Text, txtLastName.Text,
                    txtEmail.Text, txtCompany.Text);
                this.Close();
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsPresent(txtFirstName.Text, txtFirstName.Tag.ToString());
            errorMessage += Validator.IsPresent(txtLastName.Text, txtLastName.Tag.ToString());
            errorMessage += Validator.IsValidEmail(txtEmail.Text, txtEmail.Tag.ToString());
            errorMessage += Validator.IsPresent(txtCompany.Text, txtCompany.Tag.ToString());

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
