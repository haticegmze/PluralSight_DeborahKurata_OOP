using ACM_BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM_BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            var productRepository = new ProductRepository();
            var excepted = new Product(2)
            {
                currentPrice = 15.96M,
                ProductDescription = "assorted size set of 4 bright yellow mini sunflowers",
                ProductName = "sunflowers"
            };
            var actual = productRepository.Retrieve(2);
            Assert.AreEqual(excepted.currentPrice, actual.currentPrice);
            Assert.AreEqual(excepted.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(excepted.ProductName, actual.ProductName);
        }
        [TestMethod()]
        public void SaveTestValid()
        {
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                currentPrice = 18M,
                ProductDescription = "assorted size set of 4 bright yellow mini sunflowera",
                ProductName = "sunflowers",
                HasChange = true
            };

            var actual = productRepository.Save(updateProduct);

            Assert.AreEqual(true, actual);
        }
        [TestMethod()]
        public void SaveTestMissingPrice()
        {
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                currentPrice = null,
                ProductDescription = "assorted size set of 4 bright yellow mini sunflowers",
                ProductName = "sunflowers",
                HasChange = true
            };
            var actual= productRepository.Save(updateProduct);

            Assert.AreEqual(false,actual); 

        }



    }
}
