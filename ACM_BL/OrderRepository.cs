﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BL
{
    public class OrderRepository //sipariş deposu
    {
        public Order Retrieve(int orderId)
        {

            Order order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                    new TimeSpan(7, 0, 0));
            }

            return order;

        }
        public bool save(Order order)
        {
            return true;
        }
    }
}
