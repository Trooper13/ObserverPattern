using System;
using System.Collections.Generic;
using Observer.Subscriber;

namespace Observer
{
    public class AnotherCustomer : ISubscriber
    {
        public void Update(List<Product> products)
        {
            if (products.Exists(product => product.Name.Equals("Słicz")))
            {
                Console.WriteLine("Nice, Słicz is available in store. \n");
            }
        }
    }
}