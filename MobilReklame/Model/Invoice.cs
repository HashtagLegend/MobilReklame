using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public class Invoice
    {
        

        #region Properties

        public int InvoiceId { get; set; }

        private static int _invoiceCounter = 10001;

        #endregion

        #region Constructor

        public Invoice()
        {
            InvoiceId = _invoiceCounter;
            _invoiceCounter++;
        }

        #endregion

        #region Methods

        public void getOffer()
        {

        }

        public void Customer()
        {
            
            
        }
        #endregion
    }
}

