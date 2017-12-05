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
       
        #region Properties
        public ObservableCollection<Customer> CustomerArchive { get; set; }
        public ObservableCollection<Order> OrderArchive { get; set; }
        public Customer SelectedCustomer { get; set; }
        public Order SelectedOrder { get; set; }
        #endregion

        #region Constructor
        public ArchiveViewModel()
        {
           CustomerArchive = CustomerArchiveSingleton.Instance.CustomerArchive;
           OrderArchive = OrderArchiveSingleton.Instance.OrderArchive;

            //OrderArchive.Add(new Order("ArkivOrdre","004", DateTime.Now, "Nej", "Kommentar"));
            //OrderArchive.Add(new Order("ArkivOrdre2", "005", DateTime.Now, "Nej", "Kommentar"));
        }
        #endregion

        #region Methods

        public void RemoveCustomer()
        {
            CustomerArchiveSingleton.Instance.RemoveCustomer(SelectedCustomer);
            OnPropertyChanged();
        }

        public void RemoveOrder()
        {
            OrderArchiveSingleton.Instance.RemoveOrderFromArchive(SelectedOrder);
            OnPropertyChanged();
        }

        #endregion

        #region PropertyChangedSupport
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
