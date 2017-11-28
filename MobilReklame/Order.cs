using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Automation.Peers;

namespace MobilReklame
{
    public class Order
    {
        #region Properties

        public string OrderName { get; set; }
        public string OrderId { get; set; }
        public string OrderSpecs { get; set; }
        public Offer OfferToOrder { get; set; }
        public Invoice InvoiceToOrder { get; set; }
        public Customer CustomerToOrder { get; set; }
        public string ViewID { get; set; }
        public string ViewProductName { get; set; }
        public string ViewCompanyName { get; set; }
        public string ViewPhoneNumber { get; set; }
        public string ViewAdress { get; set; }
        public string ViewEmail { get; set; }
        public string ViewATT { get; set; }
        public string ViewCVR { get; set; }


        #endregion

        #region Constructor

        public Order(string orderName, string orderId, string orderSpecs)
        {
            OrderName = orderName;
            OrderId = orderId;
            OrderSpecs = orderSpecs;
        }

        #endregion

        #region Methods

        public void CreateOffer()
        {
            OfferToOrder = new Offer(ViewID,ViewProductName);
        }

        public void CreateInvoice()
        {
            InvoiceToOrder = new Invoice();
        }

        public void CreateCustomer()
        {
            CustomerToOrder = new Customer(ViewCompanyName, ViewPhoneNumber, ViewAdress, ViewEmail, ViewATT, ViewCVR);
        }

        public void AddOrderToOverViewList()
        {
            
        }

        public ShowOffer()
        {
            return;
        }

        public ShowInvoice()
        {
            return;
        }

        public void EndOrder()
        {
            
        }


        #endregion
    }
}
