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
        #region Properties
        private int _statusNumber = 1;

        public string OrderName { get; set; }
        public int OrderId { get; set; }
        public string Commentary { get; set; }
        public DateTime Deadline { get; set; }
        public string Delivery { get; set; }
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
        public int StatusNumber{ get { return _statusNumber; } set { _statusNumber = value; }}
        public string Status { get; set; }

        private static int _counter = (10001);
        
        
        #endregion

        #region Constructor

        public Order(string orderName, DateTime deadline, string delivery, string commentary)
        {
            OrderName = orderName;
            OrderId = _counter++;
            Deadline = deadline;
            Delivery = delivery;
            Commentary = commentary;
            OrderStatus();
        }

        #endregion

        #region Methods

        public void CreateOffer()
        {
            OfferToOrder = new Offer();
        }

        public void CreateInvoice(int invoiceid, DateTime date, string commentary)
        {
            InvoiceToOrder = new Invoice(invoiceid,DateTime.Now, commentary);
            double totalprice = OfferToOrder.TotalPrice;

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
            return $"{nameof(OrderName)}: {OrderName}, {nameof(OrderId)}: {OrderId}, {nameof(Commentary)}: {Commentary}, {nameof(Deadline)}: {Deadline}, {nameof(Delivery)}: {Delivery}";
        }
        #endregion

        /// <summary>
        /// Tilbud Rød
        /// Produktion
        /// Levering
        /// Montering
        /// Afslutning
        /// </summary>

        #region StatusColor
        public void StatusPlusOne()
        {
            StatusNumber++;
        }
        public void OrderStatus()
        {
            switch (StatusNumber)
            {
                case 1:
                    Color = "Red";
                    Status = "Tilbud";
                    break;

                case 2:
                    Color = "Red";
                    Status = "Produktion";
                    break;

                case 3:
                    Color = "Yellow";
                    Status = "Produktion";
                    break;

                case 4:
                    Color = "Green";
                    Status = "Produktion";
                    break;

                case 5:
                    Color = "Red";
                    Status = "Levering";
                    break;

                case 6:
                    Color = "Yellow";
                    Status = "Levering";
                    break;

                case 7:
                    Color = "Green";
                    Status = "Levering";
                    break;

                case 8:
                    Color = "Red";
                    Status = "Montering";
                    break;

                case 9:
                    Color = "Yellow";
                    Status = "Montering";
                    break;

                case 10:
                    Color = "Green";
                    Status = "Montering";
                    break;

                case 11:
                    Color = "Red";
                    Status = "Afslutning";
                    break;

                case 12:
                    Color = "Yellow";
                    Status = "Afslutning";
                    break;

                case 13:
                    Color = "Green";
                    Status = "Afslutning";
                    break;
            }
        }

        #endregion
    }
}
