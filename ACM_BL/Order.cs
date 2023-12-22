using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BL
{
    public class Order : EntityBase, ILoggable
    {
        public Order() : this(0)
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }
        public int CustomerId { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> orderItems { get; set; }
        public int ShippingAddress { get; set; }

        public string Log()
        {
            throw new NotImplementedException();
        }
        public string log()
        {
            return $"{OrderId}: Date:{this.OrderDate.Date} Status:{this.EntityState.ToString()}";
        }

        public override string ToString() =>
            $"{OrderDate.Date} ({OrderId})";


        public override bool Validate()
        {
            var isvalid = true;
            if (OrderDate == null) isvalid = false;
            return isvalid;
        }





    }
}
