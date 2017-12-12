using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MobilReklame.Annotations;
using Windows.UI.Popups;

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
           //OrderArchive.Clear();
           //OrderArchive.Add(new Order("Vikingeborg", "32322", DateTime.Now, "Imorgen", "Intet"));

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
        
        public void DeleteCustomer()
        {
            CustomerArchiveSingleton.Instance.RemoveCustomer(SelectedCustomer);
            OnPropertyChanged();
            MessageDialogHelper.Show("Kunden er fjernet fra arkivet!", "Oplysning");
        }

        public void DeleteOrderFromArchive()
        {
            OrderArchiveSingleton.Instance.RemoveOrderFromArchive(SelectedOrder);
            OnPropertyChanged();
            MessageDialogHelper.Show("Ordren er fjernet fra arkivet", "Oplysning");
        }
        #endregion

        #region MessageDialogHelper

        private class MessageDialogHelper
        {
            public static async void Show(string content, string title)
            {
                MessageDialog messageDialog = new MessageDialog(content, title);
                await messageDialog.ShowAsync();
            }
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
