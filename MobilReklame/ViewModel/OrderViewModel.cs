using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using MobilReklame.Annotations;
using MobilReklame.PersistencyServices;
using MobilReklame.Singleton;

namespace MobilReklame
{
   public class OrderViewModel : INotifyPropertyChanged
    {
        #region BackingField

        

        #endregion

        #region Properties

        public Order SelectedOrder { get; set; }

        public static Order SavedOrder { get; set; }



        #region OrderProperties

        public string ViewOrderName { get; set; }
        public string ViewOrderID { get; set; }
        public string ViewCommentary { get; set; }
        public DateTime ViewDeadline { get; set; }
        public string ViewDelivery { get; set; }

        #endregion

        #region OfferProperties

        public string OfferName { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public double ProductPrice { get; set; }
        public double TotalPrice { get; set; }

        #endregion

        #region InvoiceProperties

        public int InvoiceID { get; set; }
        public string InvoiceCommentary { get; set; }

        #endregion

        #region CustomerProperties

        public string ViewCompanyName { get; set; }
        public string ViewPhoneNumber { get; set; }
        public string ViewAdress { get; set; }
        public string ViewEmail { get; set; }
        public string ViewATT { get; set; }
        public string ViewCVR { get; set; }

        #endregion


        public ObservableCollection<Customer> CustomerList { get; set; }
        public ObservableCollection<Order> OrderList { get; set; }
        
        #endregion

       

        public OrderViewModel()
        {
            //Tilføjer et object til OrderCatalog listen og initialisere den som OrderList, så vi kan referere til den herfra.
            OrderList = OrderCatalogSingleton.Instance.OrderCatalog;
            
            CustomerList = new ObservableCollection<Customer>();
            CustomerList.Add(new Customer("Google", "123456", "Googledrive 23", "gogle@google.dk", "Mr. Google", "3333555"));
            
        }

        #region Methods

        public void SaveSelectedWhenNavigate()
        {
            SavedOrder = SelectedOrder;
        }

        public void CreateOrder()
        {
            OrderCatalogSingleton.Instance.AddOrder(ViewOrderName, ViewOrderID, ViewDeadline, ViewDelivery, ViewCommentary);
            OnPropertyChanged();
        }

        public void CreateOffer()
        {
           
        }
        

        public void CreateProductsToOffer()
        {
     
        }

        public void CreateInvoice(Order order)
        {
            order.CreateInvoice(InvoiceID, DateTime.Now, InvoiceCommentary);
        }

        public void CreateCustomer()
        {
           CustomerArchiveSingleton.Instance.AddCustomer(ViewCompanyName, ViewPhoneNumber, ViewAdress, ViewEmail, ViewATT, ViewCVR);
           OnPropertyChanged();
        }

        public void MoveOrderToOrderArchive()
        {
            OrderArchiveSingleton.Instance.AddOrderToArchive(SelectedOrder);
            OrderCatalogSingleton.Instance.RemoveOrder(SelectedOrder);
            OnPropertyChanged();
        }

        #endregion
       
        #region PropertyChangeSupport

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
