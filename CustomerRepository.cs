using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCustomerManagement
{
    public class CustomerRepository
    {
        
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            //temporary hard coded data to return a popuilated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";

            }
            return customer;
        }
        
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
