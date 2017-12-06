using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using MobilReklame.PersistencyServices;

namespace MobilReklame.Singleton
{
    class OrderCatalogSingleton
    {
        private static OrderCatalogSingleton _instance;

        public static OrderCatalogSingleton Instance
        {
            get { return _instance ?? (_instance = new OrderCatalogSingleton()); }
        }

        public ObservableCollection<Order> OrderCatalog { get; }

        private OrderCatalogSingleton()
        {
            OrderCatalog = new ObservableCollection<Order>();
            //OrderCatalog.Clear();
            //LoadOrderCatalogAsync();
        }

        public void AddOrder(string orderName, DateTime deadline, string delivery, string commentary)
        {
            OrderCatalog.Add(new Order(orderName, deadline, delivery, commentary));
            //PersistencyServiceOrderCatalog.SaveOrderListAsJsonAsync(OrderCatalog);
        }

        public void AddOrder(Order order)
        {
            OrderCatalog.Add(order);
            //PersistencyServiceOrderCatalog.SaveOrderListAsJsonAsync(OrderCatalog);
        }

        public void RemoveOrder(Order orderToBeRemoved)
        {
            OrderCatalog.Remove(orderToBeRemoved);
            //PersistencyServiceOrderCatalog.SaveOrderListAsJsonAsync(OrderCatalog);
        }

        //public async void LoadOrderCatalogAsync()
        //{
        //    var orderCatalog = await PersistencyServiceOrderCatalog.LoadOrderListFromJsonAsync();
        //    OrderCatalog.Clear();
            
        //    if(orderCatalog != null)
        //        foreach (var orderObjects in orderCatalog)
        //        {
        //            OrderCatalog.Add(orderObjects);
        //        }
        //    else
        //        {
        //            OrderCatalog.Add(new Order("Vikingeborg", "001", DateTime.Now, "Ingen levering, kunde henter selv", "Åbningstider 9 - 16"));
        //        }
        //}
        
    }
}

