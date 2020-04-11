using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve one order.
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            //Create the instance of the Order class
            //pass in the requested Id
            Order order = new Order(orderId);

            //code that retrieves the defines order

            //temporary hard-coded values to return a populated order
            if (orderId == 10)
            {
                //use current year in hard-coded data
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                    new TimeSpan(7, 0, 0));
            }
                return order;
            
        }

        /// <summary>
        /// Saves the current order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public bool Save(Order order)
        {
            //Code that saves the passed in order

            return true;
        }
    }
}
