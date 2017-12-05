using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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
        public ObservableCollection<Customer> CustomerArchive { get;}
        
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
            CustomerArchive = new ObservableCollection<Customer>();
            CustomerArchive.Clear();
            LoadCustomerArchive();
        }
        #endregion

        #region Methods
        public void AddCustomer(string companyName, string phoneNumber, string adress, string email, string att, string cvr)
        {
            CustomerArchive.Add(new Customer(companyName, phoneNumber, adress, email, att, cvr));
            PersistencyServiceCustomerArchive.SaveCustomerArchiveAsJsonAsync(CustomerArchive);
        }

        public void AddCustomer(Customer customer)
        {
            CustomerArchive.Add(customer);
            PersistencyServiceCustomerArchive.SaveCustomerArchiveAsJsonAsync(CustomerArchive);
        }

        public void RemoveCustomer(Customer customerToBeRemoved)
        {
            CustomerArchive.Remove(customerToBeRemoved);
            PersistencyServiceCustomerArchive.SaveCustomerArchiveAsJsonAsync(CustomerArchive);
        }
        
        public async void LoadCustomerArchive()
        {
            var customerArchive = await PersistencyServiceCustomerArchive.LoadCustomerArchiveFromJsonAsync();
            CustomerArchive.Clear();
            if (customerArchive != null)
            {
                foreach (var customer in customerArchive)
                {
                    CustomerArchive.Add(customer);
                }
            }
            else
            {
                CustomerArchive.Add(new Customer("Google", "12345678", "Nygade 12", "Test@Test.Test", "Søren","583567347648"));
            }
        }
        #endregion
    }
}
