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
        public Product(string name, string type, int quantity, double price)
        {
            Name = name;
            Type = type;
            Quantity = quantity;
            Price = price;
        }
        //En ctorf, altså en constructor ud fra instance field
        #endregion

        #region Properties
        public string Name { get; set; }

        public string Type { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        //4 styks prop af name, type, quantity og price
        #endregion
    }
}
