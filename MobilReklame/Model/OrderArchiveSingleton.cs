using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    class OrderArchiveSingleton
    {
        #region Instance Field
        private static OrderArchiveSingleton _instance;
        #endregion

        #region Properties
        public ObservableCollection<Order> OrderArchive { get; }

        public static OrderArchiveSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new OrderArchiveSingleton();
                }
                return _instance;
            }
        }
        #endregion

        #region Constructor
        public OrderArchiveSingleton()
        {
            OrderArchive = new ObservableCollection<Order>();
        }
        #endregion
    }
}
