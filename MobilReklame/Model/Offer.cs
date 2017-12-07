﻿using System;
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
   public class Offer : INotifyPropertyChanged
   {

        private double _vat = 1.25;
       private double _totalPrice;
       public int OfferID { get; set; }
        public string Name { get; set; }

       public double TotalPrice
       {
           get { return _totalPrice; }
           set
           {
               _totalPrice = value;
               OnPropertyChanged();
           }
       }

        public ObservableCollection<Product> ProductList{ get; set; }
        private static int _offerCounter = 10001;


        public Offer()
        {
            OfferID = _offerCounter;
            _offerCounter++;
          
        }

       public void CreateProduct(string name, int quantity, double price)
       {
           ProductList.Add(new Product(name,quantity, price));
            OnPropertyChanged();
       }

        public void CalculateTotalPrice()
        {
            foreach (Product product in ProductList)
            {
                TotalPrice = (product.Price*product.Quantity) + TotalPrice;
            }
            TotalPrice = TotalPrice * _vat;
            OnPropertyChanged();
        }


       public event PropertyChangedEventHandler PropertyChanged;

       [NotifyPropertyChangedInvocator]
       protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
       {
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
       }
   }
}
