using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoltTest
{
    public class Shop
    {
        private List<Product> _products = new List<Product>();

        public bool Store(Product product)
        {
            int i = 0;
            while (i < _products.Count && _products[i].Id != product.Id)
            {
                i++;
            }
            if (i < _products.Count)
            {
                return false;
            }
            _products.Add(product);
            return true;
        }

        public bool StoreMultiple(Product[] products)
        {
            bool succes = true;
            foreach (var product in products)
            {
                succes &= TryAdd(product);
            }
            return succes;
        }

        public bool TryAdd(Product product)
        {
            int i = 0;
            while (i < _products.Count && _products[i].Id != product.Id)
            {
                i++;
            }
            if (i < _products.Count)
            {
                return false;
            }
            _products.Add(product);
            return true;
        }

        public double GetAvaragePrice()
        {
            double tempPrices = 0;
            for (int i = 0; i < _products.Count; i++)
            {
                tempPrices += _products[i].Price;
            }

            //foreach (var product in _products)
            //{
            //    tempPrices += product.Price;
            //}

            return tempPrices/_products.Count;
            //return _products.Average(product => product.Price);
        }
    }
}
