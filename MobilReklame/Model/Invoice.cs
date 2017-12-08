using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public class Invoice
    {
        #region Backing Fields

        private int _invoidid;
        private DateTime _madeDateTime;
        private string _commentary;

        #endregion

        #region Propeties


        public DateTime MadeDateTime
        {
            get { return _madeDateTime; }
            set { _madeDateTime = value; }
        }

        public string commentary
        {
            get { return _commentary; }
            set { _commentary = value; }
        }

        private static int _invoiceCounter = (10001);
        #endregion

        #region Constructor

        public Invoice(DateTime madeDateTime, string commentary)
        {
            _madeDateTime = madeDateTime;
            _commentary = commentary;
        }

        #endregion

        #region TooString 
        public override string ToString()
        {
            return $"{nameof(_invoidid)}: {_invoidid}, {nameof(_commentary)}: {_commentary},{nameof(MadeDateTime)}: {MadeDateTime}, {nameof(commentary)}: {commentary}";
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

