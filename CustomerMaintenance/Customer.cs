using System;

/* ***********************************************
 * CIS123: Intro to Object-oriented Programming
 * Chapter 14: How to work with inheritance
 * Exercise 14-1 Create a Customer Maintenance 
 *      application that uses inheritance
 * Dominique Tepper, 17JUN2022
 * **********************************************/

namespace CustomerMaintenance
{
    public class Customer
	{
		private string firstName;
		private string lastName;
		private string email;

		public Customer()
		{
		}

		public Customer(string firstName, string lastName, string email)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Email = email;
		}

		public string FirstName
		{
			get
			{
                return firstName;
			}
			set
			{
                if (value.Length > 50)
                {
                    throw new ArgumentException(
                        "Maximum length of first name is 50 characters.");
                }
                firstName = value;
			}
		}

		public string LastName
		{
			get
			{
                return lastName;
			}
			set
			{
                if (value.Length > 50)
                {
                    throw new ArgumentException(
                        "Maximum length of last name is 50 characters.");
                }
                lastName = value;
			}
		}

		public string Email
		{
			get
			{
				return email;
			}
			set
			{
                if (value.Length > 50)
                {
                    throw new ArgumentException(
                        "Maximum length of email address is 50 characters.");
                }
                email = value;
			}
		}

		public string GetDisplayText() => firstName + " " + lastName + ", " + email;
		}
	}
}
