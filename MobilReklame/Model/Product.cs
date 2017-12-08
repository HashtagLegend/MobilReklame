using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public class Product
    {
      

        #region Constructor

        public Product(string name, int quantity, double price, string length, string width)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            Length = length;
            Width = width;
        }
        
        #endregion

        #region Properties
        public string Name { get; set; }

        public int Quantity { get; set; }
        
        public double Price { get; set; }

        public string Length { get; set; }

        public string Width { get; set; }

        

        #endregion

        public override string ToString()
        {
            return $"{Name}: {Quantity}, {Price}";
        }
        
    }


}
