﻿using System;
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
        public int OfferID { get; set; }
        public string Name { get; set; }
        public double TotalPrice { get; set; }
        public List<Product> ProductList{ get; set; }
        public string ViewName { get; set; }
        public string ViewType { get; set; }
        public int ViewQuantity { get; set; }
        public double ViewPrice { get; set; }
       private int _offerCounter = 0;


        public Offer(string name)
        {
            OfferID = _offerCounter;
            _offerCounter++;
            Name = name;
            ProductList = new List<Product>();
        }

       public void CreateProduct()
       {
           ProductList.Add(new Product(ViewName, ViewType, ViewQuantity, ViewPrice));
       }

       public void CalculateTotalPrice()
       {
           foreach (Product product in ProductList)
           {
               TotalPrice = (product.Price*product.Quantity) + TotalPrice;
           }
           TotalPrice = TotalPrice * _vat;
       }

     
    }
}
