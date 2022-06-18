using System;
using System.Collections.Generic;
using System.Text;

/* ***********************************************
 * CIS123: Intro to Object-oriented Programming
 * Chapter 14: How to work with inheritance
 * Exercise 14-1 Create a Customer Maintenance 
 *      application that uses inheritance
 * Dominique Tepper, 17JUN2022
 * 
 * 3. Add a WholesaleCustomer class that inherits
 *    from the Customer class.
 *    
 *      a. Company         string property
 *      b. default constructor
 *      c. constructor that accepts 4 parameters
 *         and call base class constructor:
 *          1. first name
 *          2. last name
 *          3. email
 *          4. company
 *      d. override GetDisplayText() to add
 *         Company name in parenthesis
 * **********************************************/

namespace CustomerMaintenance
{
    public class WholesaleCustomer : Customer
    {

        private string company;

        //3b. default constructor
        public WholesaleCustomer()
        {
        }

        //3c.
        public WholesaleCustomer(string lastName, string firstName,
            string email, string company) : base(lastName, firstName, email)
        {
            this.company = company;
        }

        //3a. string Company
        //Dominique Tepper, 17JUN2022
        public string Company
        {
            get
            {
                return this.company;
            }
            set
            {
                this.company = value;
            }
        }

        //3d. GDT() override
        public override string GetDisplayText() => base.GetDisplayText() + " (" + this.company + ")";

    }
}
