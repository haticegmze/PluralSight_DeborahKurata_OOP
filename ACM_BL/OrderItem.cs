using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }
        public int OrderItemId { get; set; }
        public int productId { get; set; }
        public decimal PurchasePrice { get; set; }
        public int Quantity { get; set; }


        public OrderItem retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        public bool Save()
        {
            return true;
        }

        public bool Valid()
        {
            var isvalid = true;
            if (Quantity <= 0) isvalid = false;
            if (productId <= 0) isvalid = false;
            if (PurchasePrice == null) isvalid = false;
            return isvalid;
        }
    }
}
