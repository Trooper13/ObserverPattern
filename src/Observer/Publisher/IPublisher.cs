using System.Collections.Generic;
using Observer.Subscriber;

namespace Observer.Publisher
{
    public interface IPublisher
    {
        void AddSubscriber(ISubscriber subscriber);
        void RemoveSubscriber(ISubscriber subscriber);
        void Notify(List<Product> products);
    }
}