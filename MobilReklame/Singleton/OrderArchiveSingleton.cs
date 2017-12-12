using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Store.Preview.InstallControl;

namespace MobilReklame
{
    class OrderArchiveSingleton
    {
        #region Instance Field
        private static OrderArchiveSingleton _instance;
        #endregion

        #region Properties
        public ObservableCollection<Order> OrderArchive { get; }

        public static OrderArchiveSingleton Instance
        {
            get { return _instance ?? (_instance = new OrderArchiveSingleton()); }
        }



        #endregion

        #region Constructor
        public OrderArchiveSingleton()
        {
            OrderArchive = new ObservableCollection<Order>();
            OrderArchive.Clear();
            LoadOrderArchiveAsync();
        }
        #endregion

        #region Methods

        public void AddOrderToArchive(string orderName, string deadline, string delivery, string commentary)
        {
            OrderArchive.Add(new Order(orderName, deadline, delivery, commentary));
            PersistencyServiceOrderArchive.SaveOrderArchiveAsJsonAsync(OrderArchive);
        }

        public void AddOrderToArchive(Order ordersToArchive)
        {
            OrderArchive.Add(ordersToArchive);
            PersistencyServiceOrderArchive.SaveOrderArchiveAsJsonAsync(OrderArchive);
        }

        public void RemoveOrderFromArchive(Order orderToBeRemoved)
        {
            OrderArchive.Remove(orderToBeRemoved);
            PersistencyServiceOrderArchive.SaveOrderArchiveAsJsonAsync(OrderArchive);
        }

        public async void LoadOrderArchiveAsync()
        {
            var orderArchive = await PersistencyServiceOrderArchive.LoadOrderArchiveFromJsonAsync();
            OrderArchive.Clear();

            if (orderArchive != null)
                foreach (var orders in orderArchive)
                {
                    OrderArchive.Add(orders);
                }
            else
            {
                OrderArchive.Add(new Order("Gammel Ordre", "12/10-2018", "Nej", "Den her lavede vi sidste år"));
            }
        }
        #endregion
    }
}
