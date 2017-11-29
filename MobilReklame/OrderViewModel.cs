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
   public class OrderViewModel : INotifyPropertyChanged
    {

        public Order SelectedOrder { get; set; }
        public Order SaveSelected { get; set; }
        public ObservableCollection<Order> OverViewList { get; set; }
        public string ViewOrderName { get; set; }
        public string ViewOrderID { get; set; }
        public string ViewOrderSpecs { get; set; }
        public string OfferName { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public double ProductPrice { get; set; }
        public double TotalPrice { get; set; }
        public int InvoiceID { get; set; }
        public string InvoiceCommentary { get; set; }

  



        public OrderViewModel()
        {
            OverViewList = new ObservableCollection<Order>();
            OverViewList.Add(new Order("TestOrder", "001", "Specs"));
            OverViewList.Add(new Order("TestOrder2", "002", "Specs2"));
        }

        public void SaveSelectedWhenNavigate()
        {
            SaveSelected = SelectedOrder;
        }

        public void CreateOrder()
        {
            OverViewList.Add(new Order(ViewOrderName,ViewOrderID,ViewOrderSpecs));
            OnPropertyChanged();
        }

        public void CreateOffer()
        {
            SaveSelected.CreateOffer();
        }

        public void SetNameForOffer()
        {
            SaveSelected.OfferToOrder.Name = OfferName;
        }

        public void CreateProductsToOffer()
        {
            SaveSelected.OfferToOrder.CreateProduct(ProductName,ProductQuantity,ProductPrice);
            SaveSelected.OfferToOrder.CalculateTotalPrice();
            TotalPrice = SaveSelected.OfferToOrder.TotalPrice;
            OnPropertyChanged();
        }

        public void CreateInvoice(Order order)
        {
            order.CreateInvoice(InvoiceID, DateTime.Now, InvoiceCommentary);
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
