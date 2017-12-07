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
        public Product(string name, int quantity, double price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }
        
        #endregion

        #region Properties
        public string Name { get; set; }

        public int Quantity { get; set; }
        
        public double Price { get; set; }

       
        #endregion

        public override string ToString()
        {
            return $"{Name}: {Quantity}, {Price}";
        }
    }


}
