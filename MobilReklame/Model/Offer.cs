using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Audio;
using MobilReklame.Annotations;

namespace MobilReklame
{
   public class Offer
   {

       private double _vat = 1.25;
       public int OfferID { get; set; }
       public string Name { get; set; }
       
        public ObservableCollection<Product> ProductList{ get; set; }
        private static int _offerCounter = 10001;


        public Offer()
        {
            OfferID = _offerCounter;
            _offerCounter++;
            ProductList = new ObservableCollection<Product>();         
        }

       public void CreateProduct(string name, int quantity, double price, string length, string width)
       {
           ProductList.Add(new Product(name,quantity, price, length, width));
           
       }
   }
}
