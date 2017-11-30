using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MobilReklame.Annotations;

namespace MobilReklame
{
   public class OrderViewModel : INotifyPropertyChanged
    {

        public Order SelectedOrder { get; set; }
        public ObservableCollection<Order> OverViewList { get; set; }
        public ObservableCollection<Customer> CustomerList { get; set; }
        public string ViewOrderName { get; set; }
        public string ViewOrderID { get; set; }
        public string ViewOrderSpecs { get; set; }
        public string OfferName { get; set; }
        public int InvoiceID { get; set; }
        public string InvoiceCommentary { get; set; }
        public string ViewCompanyName { get; set; }
        public string ViewPhoneNumber { get; set; }
        public string ViewAdress { get; set; }
        public string ViewEmail { get; set; }
        public string ViewATT { get; set; }
        public string ViewCVR { get; set; }



        public OrderViewModel()
        {
            OverViewList = new ObservableCollection<Order>();
            OverViewList.Add(new Order("TestOrder", "001", "Specs"));
            OverViewList.Add(new Order("TestOrder2", "002", "Specs2"));

            CustomerList = new ObservableCollection<Customer>();
            CustomerList.Add(new Customer("Google", "123456", "Googledrive 23", "gogle@google.dk", "Mr. Google", "3333555"));
        }

        public void CreateOrder()
        {
            OverViewList.Add(new Order(ViewOrderName,ViewOrderID,ViewOrderSpecs));
            OnPropertyChanged();
        }

        public void CreateOffer(Order order)
        {
            order.CreateOffer(OfferName);
        }

        public void CreateInvoice(Order order)
        {
            order.CreateInvoice(InvoiceID, DateTime.Now, InvoiceCommentary);
        }

       public void CreateCustomer()
        {
            CustomerList.Add(new Customer(ViewCompanyName, ViewPhoneNumber, ViewAdress, ViewEmail, ViewATT, ViewCVR));
            OnPropertyChanged();
        }

    

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
