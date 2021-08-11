using System;
using System.Collections.Generic;
using System.Linq;
using Observer.Subscriber;

namespace Observer
{
    public class Customer : ISubscriber<Product>
    {
        public void Update(IReadOnlyCollection<Product> products)
        {
            if (products.Count(arg => arg.Name.Equals("Ajfon")) > 1)
            {
                Console.WriteLine("Yeeey!! Ajfon is on the store!!\n");
            }
            if (products.Count(arg => arg.Name.Equals("Ajfon")) < 1)
            {
                Console.WriteLine("Oh noo!! No more Ajfons are available on the store!!\n");
            }
        }
    }
}