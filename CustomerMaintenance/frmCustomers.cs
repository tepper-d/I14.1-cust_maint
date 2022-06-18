using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* ***********************************************
 * CIS123: Intro to Object-oriented Programming
 * Chapter 14: How to work with inheritance
 * Exercise 14-1 Create a Customer Maintenance 
 *      application that uses inheritance
 * Dominique Tepper, 17JUN2022
 * 
 * 6. 1. Modify event handlers for btnAdd_Click.
 *      a. Wholesale
 *      b. Retail
 *    2. Create new instance of add customer form
 *       as GetNewCustomer()
 *    3. Object saved to appropriate variable type
 *     != null
 *    use HandleChange() event handler
 *    
 * Exercise 14.2
 * 3. Modify the FillCustomerListBox() method of
 *    the CustomerMaintenance form so it fills the\
 *    list box using a foreach statement.
 * **********************************************/

namespace CustomerMaintenance
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private CustomerList customers = new CustomerList();

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            customers.Changed += new CustomerList.ChangeHandler(HandleChange);
            customers.Fill();
            FillCustomerListBox();
        }


        //14.2.3 use foreach isntead of for
        private void FillCustomerListBox()
        {
            lstCustomers.Items.Clear();
            foreach (Customer c in customers)
            {
                lstCustomers.Items.Add(c.GetDisplayText());
            }
        }


        //6A.
        //Tepper, 17JUN2022
        private void btnAddWholesale_Click(object sender, EventArgs e)
        {
            Customer customer;
            frmAddWholesale addWholesaleForm = new frmAddWholesale();
            customer = addWholesaleForm.GetNewCustomer();
            if (customer != null)
            {
                customers.Add(customer);
            }
        }

        //6B.
        private void btnAddRetail_Click(object sender, EventArgs e)
        {
            Customer customer;
            frmAddRetail addRetailForm = new frmAddRetail();
            customer = addRetailForm.GetNewCustomer();
            if (customer != null)
            {
                customers.Add(customer);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstCustomers.SelectedIndex;
            if (i != -1)
            {
                Customer customer = customers[i];
                string message = "Are you sure you want to delete "
                    + customer.FirstName + " " + customer.LastName + "?";
                DialogResult button = MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    customers -= customer;
                }
            }
        }

        private void HandleChange(CustomerList list)
        {
            customers.Save();
            FillCustomerListBox();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
