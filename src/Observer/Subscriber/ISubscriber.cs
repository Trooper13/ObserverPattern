using System.Collections.Generic;

namespace Observer.Subscriber
{
    public interface ISubscriber<T>
    {
        void Update(IReadOnlyCollection<T> product);
    }
}