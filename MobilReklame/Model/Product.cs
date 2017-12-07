using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public class Product
    {
        #region Instance Field
        private string _name;
        private int _quantity;
        private double _price;
        //Oprettelse af instance fields ud fra klasse diagram, så vi har varenavn, varetype,
        //hvor mange styks og til sidst prisen på varer
        #endregion

        #region Constructor
        public Product(string name, int quantity, double price)
        {
            _name = name;
            _quantity = quantity;
            _price = price;
        }
        //En ctorf, altså en constructor ud fra instance field
        #endregion

        #region Properties
        public string Name { get; set; }

        public int Quantity { get; set; }

        

        public double Price { get; set; }

        //4 styks prop af name, type, quantity og price
        #endregion
    }
}
