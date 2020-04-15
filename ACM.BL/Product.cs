using Acme.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product() { }
        public Product(int productId) { ProductId = productId; }

        private string _productName;
        public string ProductName 
        {
            get
            {
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            } 
        }

        public string ProductDesctiption { get; set; }
        public decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }

        public string Log() => $"{ProductId}: {ProductName} Detail: {ProductDesctiption} Status: {EntityState.ToString()}";
        public override string ToString() => ProductName;

        /// <summary>
        /// Validates the product data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
