using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCustomerManagement
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName 
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }
        public static int InstanceCount { get; set; } //static field attached ptoperty to the class itself not as a reference
        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;

        }

    }
}
