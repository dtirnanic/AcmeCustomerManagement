using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCustomerManagement
{
    class Order
    {
        public DateTime OrderDate { get; set; }

        public Order Retrieve(int productId)
        {
            return new Order();
        }
        public List<Order> Retrieve()
        {
            return new List<Order>();
        }
        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {
            var isValid = true;

           // if (DateTime.ReferenceEquals() isValid = false;
            

            return isValid;

        }

    }
}
