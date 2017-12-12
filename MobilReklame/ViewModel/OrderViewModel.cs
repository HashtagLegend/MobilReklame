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
using Windows.UI.Popups;
using MobilReklame.Annotations;
using MobilReklame.PersistencyServices;
using MobilReklame.Singleton;
using MobilReklame;

namespace MobilReklame
{
   public class OrderViewModel : INotifyPropertyChanged
    {
        private double _totalPrice;

        #region BackingField

        

        #endregion

        #region Properties

        public Order SelectedOrder { get; set; }

        public static Order SavedOrder { get; set; }
        



        #region OrderProperties

        public string ViewOrderName { get; set; }
        //public string ViewOrderID { get; set; }
        public string ViewCommentary { get; set; }
        public string ViewDeadline { get; set; }
        public string ViewDelivery { get; set; }
        public string ViewOrderStatus { get { return SavedOrder.Status; }}
        public string ViewOrderFase { get { return SavedOrder.Fase; } }

        #endregion

        #region OfferProperties

        public string OfferName { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public double ProductPrice { get; set; }
        public string ProductLength { get; set; }
        public string ProductWidth { get; set; }

        public double TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; OnPropertyChanged();}
        }

        public Product SelectedProduct { get; set; }


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



        public ObservableCollection<Order> OrderList { get; set; }

        #endregion



        public OrderViewModel()
        {
            //Tilføjer et object til OrderCatalog listen og initialisere den som OrderList, så vi kan referere til den herfra.
            OrderList = OrderCatalogSingleton.Instance.OrderCatalog;
        }

        #region Methods

        public void SaveSelectedWhenNavigate()
        {
            SavedOrder = SelectedOrder;
        }

        public void CreateOrder()
        {
            OrderCatalogSingleton.Instance.AddOrder(ViewOrderName, ViewDeadline, ViewDelivery, ViewCommentary);
            foreach (Order order in OrderCatalogSingleton.Instance.OrderCatalog)
            {
                if (order.OrderName == ViewOrderName)
                {
                    order.CustomerToOrder = new Customer(ViewCompanyName, ViewPhoneNumber, ViewAdress, ViewEmail, ViewATT, ViewCVR);
                }
            }
            OnPropertyChanged();
        }

        public void CreateOffer()
        {
            if (SavedOrder.OfferToOrder == null)
            {
                SavedOrder.CreateOffer();
            }
            else
            {
                MessageDialogHelper.Show("Der er allerede oprettet et tilbud og du henvises herved til pågældende tilbud.", "Opmærksom");
            }
                   
        }
        
        public void CreateProductsToOffer()
        {
            SavedOrder.OfferToOrder.ProductList.Add(new Product(ProductName,ProductQuantity,ProductPrice, ProductLength, ProductWidth));
            UpdatetPrice();
            OnPropertyChanged();
            SaveOrderCatalog();
        }

        public void UpdatetPrice()
        {
            double localTotalPrice = 0;
            foreach (Product product in SavedOrder.OfferToOrder.ProductList)
            {
                localTotalPrice = (product.Price * product.Quantity)+localTotalPrice;
            }
            TotalPrice = localTotalPrice;
        }

        public void TotalPriceWithVat()
        {
            double localTotalPriceWithVat = 0;
            foreach (Product product in SavedOrder.OfferToOrder.ProductList)
            {
                localTotalPriceWithVat = (product.Price * product.Quantity) + localTotalPriceWithVat;
            }
            TotalPrice = localTotalPriceWithVat * SavedOrder.OfferToOrder._vat;

        }


        public void DeleteProductFromList()
        {
            SavedOrder.OfferToOrder.ProductList.Remove(SelectedProduct);
            UpdatetPrice();
            SaveOrderCatalog();

        }
        
        public void CreateInvoice()
        {
            if (SavedOrder.InvoiceToOrder == null)
            {
                SavedOrder.CreateInvoice();
            }
            else
            {
                MessageDialogHelper.Show("Der er allerede oprettet en faktura og du henvises herved til den pågældende faktura.", "Opmærksom");
            }
            SaveOrderCatalog();
        }

        public void CreateCustomer()
        {
            CustomerArchiveSingleton.Instance.AddCustomer(ViewCompanyName, ViewPhoneNumber, ViewAdress, ViewEmail, ViewATT, ViewCVR);
            OnPropertyChanged();
        }

        public void MoveOrderToOrderArchive()
        {
            OrderArchiveSingleton.Instance.AddOrderToArchive(SavedOrder);
            OrderCatalogSingleton.Instance.RemoveOrder(SavedOrder);
            OnPropertyChanged();
            MessageDialogHelper.Show("Ordren er flyttet til ordrearkivet!", "Oplysning");
        }

        public void DeleteOrder()
        {
            OrderCatalogSingleton.Instance.RemoveOrder(SavedOrder);
            OnPropertyChanged();
            MessageDialogHelper.Show("Ordren er slettet!", "Oplysning");
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

        public void SaveOrderCatalog()
        {
            PersistencyServiceOrderCatalog.SaveOrderListAsJsonAsync(OrderCatalogSingleton.Instance.OrderCatalog);
        }
        
        #region PropertyChangeSupport

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Status
        public void StatusTilbud()
        {
            SavedOrder.Status = "Tilbud";
            OnPropertyChanged();
            SaveOrderCatalog();

        }
        public void StatusProduktion()
        {
            SavedOrder.Status = "Produktion";
            OnPropertyChanged();
            SaveOrderCatalog();
        }
        public void StatusLevering()
        {
            SavedOrder.Status = "Levering";
            OnPropertyChanged();
            SaveOrderCatalog();
        }
        public void StatusMontering()
        {
            SavedOrder.Status = "Montering";
            OnPropertyChanged();
            SaveOrderCatalog();
        }

        public void StatusAfslutning()
        {
            SavedOrder.Status = "Afslutning";
            OnPropertyChanged();
            SaveOrderCatalog();
        }
        public void StatusRed()
        {
            SavedOrder.Color = "Red";
            SavedOrder.Fase = "Ikke Startet";
            OnPropertyChanged();
            SaveOrderCatalog();
        }
        public void StatusYellow()
        {
            SavedOrder.Color = "Yellow";
            SavedOrder.Fase = "Igang";
            OnPropertyChanged();
            SaveOrderCatalog();
        }
        public void StatusGreen()
        {
            SavedOrder.Color = "Green";
            SavedOrder.Fase = "Færdig";
            OnPropertyChanged();
            SaveOrderCatalog();
        }
        #endregion
    }
}
