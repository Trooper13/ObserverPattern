using System;
using System.Collections.Generic;
using System.Linq;
using Observer.Publisher;
using Observer.Subscriber;

namespace Observer
{
    public class Shop : IPublisher
    {
        public List<Product> Products { get; set; }
        private List<ISubscriber> _subscribers;

        public Shop()
        {
            Products = new List<Product>();
            _subscribers = new List<ISubscriber>();
        }

        public void AddProduct(string name)
        {
            Console.WriteLine($"Shop: New {name} has been added to the store.");
            Products.Add(new Product(name));
            Notify(Products);
        }

        public void RemoveProduct(string name)
        {
            Console.WriteLine($"Shop: {name} has been sold.");
            Products.Remove(Products.FirstOrDefault(product => product.Name.Equals(name)));
            if (!Products.Exists(product => product.Name == name))
            {
                Notify(Products);
            }
        }

        public void AddSubscriber(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
            Console.WriteLine("Shop: Subscriber has been added.");
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
            Console.WriteLine("Shop: Subscriber has been removed.");
        }

        public void Notify(List<Product> products)
        {
            foreach (var subscriber in _subscribers)
            {
                Console.WriteLine("Subscriber has been notified...");
                subscriber.Update(products);
            }
        }
    }
}