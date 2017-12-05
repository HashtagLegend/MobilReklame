using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Automation;

namespace MobilReklame
{
    class CustomerArchiveSingleton
    {
        #region Instance Field
        private static CustomerArchiveSingleton _instance;
        #endregion

        #region Properties
        public ObservableCollection<Customer> Customerarchive { get;}

        public static CustomerArchiveSingleton Instance
        {
            get
            {
                if(_instance == null)
                {
                   _instance = new CustomerArchiveSingleton();
                }
                return _instance;
            }
        }
        #endregion

        #region Constuctor
        public CustomerArchiveSingleton()
        {
            Customerarchive = new ObservableCollection<Customer>();
        }
        #endregion

        #region Methods
        public void AddCustomer(string companyName, string phoneNumber, string adress, string email, string att, string cvr)
        {
            Customerarchive.Add(new Customer(companyName, phoneNumber, adress, email, att, cvr));
        }

        public void AddCustomer(Customer customer)
        {
            Customerarchive.Add(customer);
        }
        #endregion
    }
}
