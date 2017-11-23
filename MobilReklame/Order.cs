using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    class Order
    {
        #region Properties

        public string OrderName { get; set; }
        public string OrderId { get; set; }
        public string OrderSpecs { get; set; }

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
            
        }

        public void CreateInvoice()
        {
            
        }

        public void CreateCustomer()
        {
            
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
