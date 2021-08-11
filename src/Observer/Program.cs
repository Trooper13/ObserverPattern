
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();

            var customer = new Customer();
            shop.AddSubscriber(customer);

            var anotherCustomer = new AnotherCustomer();
            shop.AddSubscriber(anotherCustomer);

            shop.AddProduct("Ajfon");
            shop.AddProduct("Ajfon");
            shop.AddProduct("Słicz");
            shop.AddProduct("Iron");

            shop.RemoveSubscriber(anotherCustomer);
            
            shop.RemoveProduct("Ajfon");
            shop.RemoveProduct("Ajfon");
            shop.RemoveProduct("Słicz");
            
            Console.ReadKey();

        }
    }
}
