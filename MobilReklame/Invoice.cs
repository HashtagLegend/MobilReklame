﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    class Invoice
    {
        #region Backing Fields
        private int _invoidid;
        private DateTime _madeDateTime;
        private string _commentary;
        #endregion

        #region Propeties
        public int invoidid
        {
            get { return _invoidid; }
            set { _invoidid = value; }
        }

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
        #endregion

        #region Methods
        public string getOffer
        {
            
        }

        public string Customer
        {
            
        }
        #endregion
    }
}
