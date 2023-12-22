using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BL
{
    public class ProductRepository
    {

        public Product Retrieve(int productId)
        {
            //ürün sınıfının örneğini oluşturan, istenilen kimliği yazın.
            Product product = new Product(productId);

            //tanımlamna ürünü alan kod
            // doldurulmuş bir ürünü döndürmemk için geçici sabit kod değerleri..


            if (productId == 2)
            {
                product.ProductName = "sunflowers";
                product.ProductDescription = "assorted size set of 4 bright yellow mini sunflowers";
                product.currentPrice = 15.96M;
            }
            return product;

            Object myObject = new Object();
            Console.WriteLine($"object: {myObject.ToString()}");
            Console.WriteLine($"product:{product.ToString()}");
            return product;
        }
        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChange)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {

                    }
                    else
                    {

                    }

                }
                else
                {
                    success = false;
                }
            }
            return success;

        }
    }
}
