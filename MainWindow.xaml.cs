using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace ProxyPattern
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class ViewOrder
        {
            public string Name { get; set; }
            public string Status { get; set; }
        }
        public MainWindow()
        {
            InitializeComponent();
            IChief chief = new ChiefProxy(new Chief());
            IEnumerable<Order> orders = chief.GetOrders();
            List<ViewOrder> f = new List<ViewOrder>();
           
            foreach (var order in orders)
            {
                string sts = chief.GetStatuses().First(c => c.Key == order.StatusId).Value;
                f.Add(new ViewOrder() { Name = order.Name, Status = sts });
            }
            dg.ItemsSource = f.ToList();
        }
    }
}
