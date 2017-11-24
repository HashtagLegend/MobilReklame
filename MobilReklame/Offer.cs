using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Audio;

namespace MobilReklame
{
   public class Offer
   {

        private double _vat = 1.25;

        public string OfferID { get; set; }
        public string Name { get; set; }
        public double TotalPrice { get; set; }
        public List<Product> ProductList{ get; set; }



        public Offer(string offerId, string name)
        {
            OfferID = offerId;
            Name = name;
            ProductList = new List<Product>();
        }

       public void CreateProduct()
       {
           ProductList.Add(new Product());
       }

       public void CalculateTotalPrice()
       {
           foreach (Product product in ProductList)
           {
               TotalPrice = product.Price + TotalPrice;
           }
           TotalPrice = TotalPrice * _vat;
       }

     
    }
}
