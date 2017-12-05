using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Audio;

namespace MobilReklame
{
   public class Offer
   {

        private double _vat = 1.25;
        public int OfferID { get; set; }
        public string Name { get; set; }
        public double TotalPrice { get; set; }
        public ObservableCollection<Product> ProductList{ get; set; }
        private int _offerCounter = 0;


        public Offer()
        {
            OfferID = _offerCounter;
            _offerCounter++;
            ProductList = new ObservableCollection<Product>();
        }

       public void CreateProduct(string name, int quantity, double price)
       {
           ProductList.Add(new Product(name,quantity, price));
       }

        public void CalculateTotalPrice()
        {
            foreach (Product product in ProductList)
            {
                //TotalPrice = (product.Price * product.Quantity) + TotalPrice;
            }
            TotalPrice = TotalPrice * _vat;
        }



    }
}
