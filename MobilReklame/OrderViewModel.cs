using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
   public class OrderViewModel
    {

        public Order SelectedOrder { get; set; }
        public ObservableCollection<Order> OverViewList { get; set; }
        public string ViewOrderName { get; set; }
        public string ViewOrderID { get; set; }
        public string ViewOrderSpecs { get; set; }
        public string OfferName { get; set; }
        public int InvoiceID { get; set; }
        public string InvoiceCommentary { get; set; }



        public OrderViewModel()
        {
            OverViewList = new ObservableCollection<Order>();
        }

        public void CreateOrder()
        {
            OverViewList.Add(new Order(ViewOrderName,ViewOrderID,ViewOrderSpecs));
        }

        public void CreateOffer(Order order)
        {
            order.CreateOffer(OfferName);
        }

        public void CreateInvoice(Order order)
        {
            order.CreateInvoice(InvoiceID, DateTime.Now, InvoiceCommentary);
        }


    }
}
