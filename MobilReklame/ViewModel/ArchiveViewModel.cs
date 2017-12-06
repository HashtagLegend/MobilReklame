using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MobilReklame.Annotations;

namespace MobilReklame
{
    class ArchiveViewModel : INotifyPropertyChanged
    {
        #region PropertyChangedSupport
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Properties
        public ObservableCollection<Customer> CustomerArchive { get; set; }
        public ObservableCollection<Order> OrderArchive { get; set; }
        #endregion

        #region Constructor
        public ArchiveViewModel()
        {
           CustomerArchive = CustomerArchiveSingleton.Instance.CustomerArchive;
           OrderArchive = OrderArchiveSingleton.Instance.OrderArchive;
           CustomerArchive.Add(new Customer("Google","57385433","Nysøgård 15","Test@Test.dk","Bent Poulsen","14356464"));
           OrderArchive.Add(new Order("VikingeBorg","2353","Test")); 
        }
        #endregion
    }
}
