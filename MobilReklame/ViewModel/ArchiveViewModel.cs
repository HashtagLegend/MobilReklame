using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MobilReklame.Annotations;

namespace MobilReklame
{
    class ArchiveViewModel : INotifyPropertyChanged
    {
        #region PropertyChangedSupport
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Properties
        public ObservableCollection<Customer> CustomerArchive { get; set; }
        public ObservableCollection<Order> OrderArchive { get; set; }
        #endregion

        #region Constructor
        public ArchiveViewModel()
        {
           CustomerArchive = CustomerArchiveSingleton.Instance.CustomerArchive;
           OrderArchive = OrderArchiveSingleton.Instance.OrderArchive;
           CustomerArchive.Add(new Customer("ffddfd","sdsds","dsdsd","sdsds","dsdsd","dsds"));
        }
        #endregion

        #region Methods
        //public async void SaveCustomerArchive()
        //{
        //    PersistencyServiceCustomerArchive.SaveCustomerArchiveAsJsonAsync(CustomerArchiveSingleton.Instance.CustomerArchive);
        //}

        //public async void LoadCustomerArchive()
        //{
        //    var CustomerArchive = await PersistencyServiceCustomerArchive.LoadCustomerArchiveFromJsonAsync();
        //    CustomerArchiveSingleton.Instance.CustomerArchive.Clear();
        //    foreach (var customer in CustomerArchive)
        //    {
        //        CustomerArchiveSingleton.Instance.CustomerArchive.Add(customer);
        //    }
        //}

        //public async void SaveOrderArchive()
        //{
        //    PersistencyServiceOrderArchive.SaveOrderArchiveAsJsonAsync(OrderArchive);
        //}

        //public async void LoadOrderArchive()
        //{
        //    var orderarchive = await PersistencyServiceOrderArchive.LoadOrderArchiveFromJsonAsync();
        //    OrderArchive.Clear();
        //    foreach (var order in orderarchive)
        //    {
        //        OrderArchive.Add(order);
        //    }
        //}
        #endregion
    }
}
