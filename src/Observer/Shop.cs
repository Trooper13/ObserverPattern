using System;
using System.Collections.Generic;
using System.Linq;
using Observer.Publisher;
using Observer.Subscriber;

namespace Observer
{
    public class Shop : IPublisher<T>
    {
        public List<T> Products { get; set; }
        private List<ISubscriber<T>> _subscribers;

        public Shop()
        {
            Products = new List<T>();
            _subscribers = new List<ISubscriber<T>>();
        }

        public void AddProduct(string name)
        {
            Console.WriteLine($"Shop: New {name} has been added to the store.");
            Products.Add(new T(name));
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

        public void AddSubscriber(ISubscriber<T> subscriber)
        {
            _subscribers.Add(subscriber);
            Console.WriteLine("Shop: Subscriber has been added.");
        }

        public void RemoveSubscriber(ISubscriber<T> subscriber)
        {
            _subscribers.Remove(subscriber);
            Console.WriteLine("Shop: Subscriber has been removed.");
        }

        public void Notify(IReadOnlyCollection<T> products)
        {
            foreach (var subscriber in _subscribers)
            {
                Console.WriteLine("Subscriber has been notified...");
                subscriber.Update(products);
            }
        }
    }
}