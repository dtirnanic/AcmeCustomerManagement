using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCustomerManagement
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Desctiption { get; set; }
        public double? CurrentPrice { get; set; }
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

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
            if (CurrentPrice == null) isValid = false; 

            return isValid;

        }
    }
}
