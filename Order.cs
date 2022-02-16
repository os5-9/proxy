using System;

namespace ProxyPattern
{
    public class Order
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int StatusId { get; set; }
    }
}
