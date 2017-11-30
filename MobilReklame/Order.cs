using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Automation.Peers;
using MobilReklame.Annotations;

namespace MobilReklame
{
    public class Order
    {
        private int _colorCode = 1;

        #region Properties

        public string OrderName { get; set; }
        public string OrderId { get; set; }
        public string OrderSpecs { get; set; }
        public Offer OfferToOrder { get; set; }
        public Invoice InvoiceToOrder { get; set; }
        public Customer CustomerToOrder { get; set; }
        public string ViewCompanyName { get; set; }
        public string ViewPhoneNumber { get; set; }
        public string ViewAdress { get; set; }
        public string ViewEmail { get; set; }
        public string ViewATT { get; set; }
        public string ViewCVR { get; set; }

        public string Color { get; set; }

        public int ColorCode
        {
            get { return _colorCode; }
            set { _colorCode = value; }
        }

        #endregion

        #region Constructor

        public Order(string orderName, string orderId, string orderSpecs)
        {
            OrderName = orderName;
            OrderId = orderId;
            OrderSpecs = orderSpecs;
            ColorChange();
        }

        #endregion

        #region Methods

        public void CreateOffer(string name)
        {
            OfferToOrder = new Offer(name);
            this.OfferToOrder.CalculateTotalPrice();
        }

        public void CreateInvoice(int invoiceid, DateTime date, string commentary)
        {
            InvoiceToOrder = new Invoice(invoiceid, DateTime.Now, commentary);
            double totalprice = this.OfferToOrder.TotalPrice;

        }

        public void CreateCustomer()
        {
            CustomerToOrder = new Customer(ViewCompanyName, ViewPhoneNumber, ViewAdress, ViewEmail, ViewATT, ViewCVR);
        }

        public void AddOrderToOverViewList()
        {

        }

        public void ShowOffer()
        {

        }

        public void ShowInvoice()
        {

        }

        public void EndOrder()
        {

        }


        #endregion

        #region Order ToString
        public override string ToString()
        {
            return $"{nameof(OrderName)}: {OrderName}, {nameof(OrderId)}: {OrderId}, {nameof(OrderSpecs)}: {OrderSpecs}";
        }
        #endregion

        #region StatusColor

        public void ColorChange()
        {
            if (ColorCode == 1)
            {
                Color = "Red";
            }
            if (ColorCode == 2)
            {
                Color = "Yellow";
            }
            if (ColorCode == 3)
            {
                Color = "Green";
            }
            if (ColorCode > 3)
            {
                ColorCode = 1;
            }
        }

        #endregion
    }
}
