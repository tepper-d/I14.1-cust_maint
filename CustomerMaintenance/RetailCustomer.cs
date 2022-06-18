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
 * 4. Add a RetailCustomer class that inherits
 *    from the Customer class.
 *    
 *      a. HomePhone         string property
 *      b. default constructor
 *      c. constructor that accepts 4 parameters
 *         and call base class constructor:
 *          1. first name
 *          2. last name
 *          3. email
 *          4. home phone
 *      d. override GetDisplayText() to add
 *         Company name in parenthesis
 * **********************************************/

namespace CustomerMaintenance
{
    public class RetailCustomer : Customer
    {
        //4a. HomePhone string
        private string homePhone;

        //4b. default constructor
        public RetailCustomer()
        {
        }

        //4c. custom constructor, 4 params
        public RetailCustomer(string lastName, string firstName,
            string email, string homePhone) : base(lastName, firstName, email)
        {
            this.homePhone = homePhone;
        }

        //4a. HomePhone getter & setter
        public string HomePhone
        {
            get
            {
                return this.homePhone;
            }
            set
            {
                this.homePhone = value;
            }
        }

        //4d. GDT() override
        public override string GetDisplayText() => base.GetDisplayText() + " ph: " + this.homePhone;
    }
}
