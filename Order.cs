﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCustomerManagement
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }

        public Order()
        {
                
        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public Order Retrieve(int orderId)
        {
            return new Order();
        }
        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;
            
            return isValid;

        }

    }
}
