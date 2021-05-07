using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Customer
    {
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private string customerid;

        public Customer() { }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string CustomerID
        {
            get { return customerid; }
            set { customerid = value; }
        }
    }
}
