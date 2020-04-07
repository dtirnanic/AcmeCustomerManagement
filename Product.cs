using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCustomerManagement
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Desctiption { get; set; }
        public double CurrentPrice { get; set; }

        public Customer Retrieve(int productId)
        {
            return new Customer();
        }
        public List<Product> Retrieve()
        {
            return new List<Product>();
        }
        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Desctiption)) isValid = false; 

            return isValid;

        }
    }
}
