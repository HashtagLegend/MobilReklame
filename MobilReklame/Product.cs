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
        private string _type;
        private int _quantity;
        private double _price;
        //Oprettelse af instance fields ud fra klasse diagram, så vi har varenavn, varetype,
        //hvor mange styks og til sidst prisen på varer
        #endregion

        #region Constructor
        public Product(string name, string type, int quantity, double price)
        {
            _name = name;
            _type = type;
            _quantity = quantity;
            _price = price;
        }
        //En ctorf, altså en constructor ud fra instance field
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        //4 styks prop af name, type, quantity og price
        #endregion
    }
}
