using System;
using System.Collections.Generic;

namespace ProxyPattern
{
    internal class ChiefProxy : IChief
    {
        private Chief _chief;
        private IDictionary<int, string> _statuses;

        public ChiefProxy(Chief chief)
        {
            _chief = chief;
        }

        public IEnumerable<Order> GetOrders()
        {
            Console.WriteLine($"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] GetOrders()\n");
            return _chief.GetOrders();
        }

        public IDictionary<int, string> GetStatuses()
        {
            Console.WriteLine($"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] GetStatuses()\n");

            if (_statuses is null)
            {
                _statuses = _chief.GetStatuses();
            }
            return _statuses;
        }
    }
}
