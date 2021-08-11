using System.Collections.Generic;
using Observer.Subscriber;

namespace Observer.Publisher
{
    public interface IPublisher<T>
    {
        void AddSubscriber(ISubscriber<T> subscriber);
        void RemoveSubscriber(ISubscriber<T> subscriber);
    }
}