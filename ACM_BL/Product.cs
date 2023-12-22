using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BL
{
    public class Product : EntityBase, ILoggable //ürün
    {
        public Product()
        {



        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public decimal? currentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }

        private string _ProductName;
        public string ProductName
        {
            get
            {

                return _ProductName.InsertSpaces();
            }
            set
            {
                _ProductName = value;
            }
        }

        public string Log() =>
          $"{ProductId}:{ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";

        public override string ToString() => ProductName;

        public override bool Validate()
        {
            var isvalid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isvalid = false;
            if (currentPrice == null) isvalid = false;
            return isvalid;
        }

        
    }
}
