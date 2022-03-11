using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoltTest
{
    class MyUnitTest
    {
        static private Shop _testShop;

        static public void Main(string[] args)
        {
            ValidProduct_Store_SuccesfullyStored();
        }
        static private void SetUp()
        {
            _testShop = new Shop();
        }

        static public void ValidProduct_Store_SuccesfullyStored()
        {
            // Arrange
            SetUp();
            var product = new Product(1, 5);

            // Act
            bool success = _testShop.Store(product);

            // Assert
            if (success)
            {
                Console.WriteLine("Első teszt: OK");
            }
            else
            {
                Console.WriteLine("Első teszt: NOK");
            }
        }

    }
}
