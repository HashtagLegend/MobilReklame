using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    class OrderRegistry
    {
        private static OrderRegistry _instance = null;

        public static OrderRegistry Instance
        {
            get {
                if (_instance==null)
                {
                    _instance=new OrderRegistry();
                }
                return _instance;
            }
        }



        private OrderRegistry()
        {
            
        }


    }
}
