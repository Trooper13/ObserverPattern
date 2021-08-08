using System;
using System.Collections.Generic;
using Observer.Subscriber;

namespace Observer
{
    public class Customer : ISubscriber
    {
        public void Update(List<Product> products)
        {
            if (products.FindAll(product => product.Name.Equals("Ajfon")).Count > 1)
            {
                Console.WriteLine("Yeeey!! Ajfon is on the store!!\n");
            }
            if (products.FindAll(product => product.Name.Equals("Ajfon")).Count < 1)
            {
                Console.WriteLine("Oh noo!! No more Ajfons are available on the store!!\n");
            }
        }
    }
}