using System.Collections.Generic;

namespace ProxyPattern
{
    public interface IChief
    {
        IDictionary<int, string> GetStatuses();
        IEnumerable<Order> GetOrders();

    }
}
