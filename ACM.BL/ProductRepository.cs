using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieve one product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            //create the instance of the product class and passin requested Id
            Product product = new Product(productId);

            //code that retrieves the defined product

            //temporary hard coded values to return a populated product
            if (productId == 2)
            {
                product.ProductName = "Sunflorwers";
                product.ProductDesctiption = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96M;
            }

            return product;
        }

        /// <summary>
        /// saves the current product.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool Save(Product product)
        {
            //code that saves the passed in product

            return true;
        }
    }
}
