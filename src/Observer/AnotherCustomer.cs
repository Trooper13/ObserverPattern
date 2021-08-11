using System;
using System.Collections.Generic;
using System.Linq;
using Observer.Subscriber;

namespace Observer
{
    public class AnotherCustomer : ISubscriber<Product>
    {
        public void Update(IReadOnlyCollection<Product> products)
        {
            if (products.Any(arg => arg.Name.Equals("Słicz")))
            {
                Console.WriteLine("Nice, Słicz is available in store. \n");
            }
        }
    }
}