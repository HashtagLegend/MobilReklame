﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklame.PersistencyServices;

namespace MobilReklame.Singleton
{
    class OrderCatalogSingleton
    {
        //private static OrderCatalogSingleton _instance;

        //public static OrderCatalogSingleton Instance
        //{
        //    get { return _instance ?? (_instance = new OrderCatalogSingleton()); }
        //}

        //public ObservableCollection<Order> OrderCatalog { get; }

        //private OrderCatalogSingleton()
        //{
        //    OrderCatalog = new ObservableCollection<Order>();
        //    OrderCatalog.Clear();
        //    LoadOrderCatalogAsync();
        //}

        //public void AddOrder(string orderName, string orderId, string orderSpecs)
        //{
        //    OrderCatalog.Add(new Order(orderName, orderId, orderSpecs));
        //    PersistencyServiceOrderCatalog.SaveOrderListAsJsonAsync(OrderCatalog);
        //}

        //public void AddOrder(Order order)
        //{
        //    OrderCatalog.Add(order);
        //    PersistencyServiceOrderCatalog.SaveOrderListAsJsonAsync(OrderCatalog);
        //}

        //public async void LoadOrderCatalogAsync()
        //{
        //    var orders = await PersistencyServiceOrderCatalog.LoadOrderListFromJsonAsync();
        //    OrderCatalog.Clear();
            
        //    if(OrderCatalog != null)
        //        foreach (var orderObjects in OrderCatalog)
        //        {
        //            OrderCatalog.Add(orderObjects);
        //        }
        //    else
        //        {
        //            OrderCatalog.Add(new Order("Vikingeborg", "001", "Specs001"));
        //        }
        //}
        
    }
}
