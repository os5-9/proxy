using System;
using System.Collections.Generic;
using System.Threading;

namespace ProxyPattern
{
    internal class Chief : IChief
    {
        public IDictionary<int,string> GetStatuses()
        {
            Dictionary<int, string> statuses = new Dictionary<int, string>();
            statuses.Add(1, "Готово");
            statuses.Add(2, "Не готово");
            statuses.Add(3, "Готовится");
            Thread.Sleep(2000);
            return statuses;
        }
        public IEnumerable<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            orders.Add(new Order() { Name = "Бургер", StatusId = new Random().Next(1, 4) });
            orders.Add(new Order() { Name = "Паста Карбонара", StatusId = 2});
            orders.Add(new Order() { Name = "Омлет", StatusId = new Random().Next(1, 4) });
            return orders;
        }
    }
}
