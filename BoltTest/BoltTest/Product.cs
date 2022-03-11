using System;

namespace BoltTest
{
    public class Product
    {
        public int Id { get; }
        public int Price { get; }

        public Product(int id, int price)
        {
            Id = id;
            Price = price;
        }
    }
}
