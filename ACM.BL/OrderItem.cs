using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem() { }
        public OrderItem(int orderItemId) { OrderItemId = orderItemId; }
        public int ProductId { get; set; }
        public int OrderItemId { get; private set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }


        /// <summary>
        /// Retrieve one order/
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            //code that retrieves the defined order

            return new Order();
        }

        /// <summary>
        /// Saves the current order.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //code that saves the defined order

            return true;
        }

        /// <summary>
        /// Validates the other data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}

