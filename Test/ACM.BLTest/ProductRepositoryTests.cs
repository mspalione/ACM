using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BLTests
{
    [TestClass()]
    public class ProductRepositoryTests
    {
        [TestMethod()]
        public void RetrieveTest()
        {
            var productRepository = new ProductRepository();
            var expected = new Product(2);
            {
                //CurrentPrice = 15.96M,
                //ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                //ProductName = "Sunflowers"
            };
            expected.CurrentPrice = 15.96M;
            expected.ProductDesctiption = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
            expected.ProductName = "Sunflowers";

            var actual = productRepository.Retrieve(2);

            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDesctiption, actual.ProductDesctiption);

        }
    }
}