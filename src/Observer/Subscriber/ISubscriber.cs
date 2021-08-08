using System.Collections.Generic;

namespace Observer.Subscriber
{
    public interface ISubscriber
    {
        void Update(List<Product> product);
    }
}