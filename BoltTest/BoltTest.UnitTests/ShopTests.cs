using NUnit.Framework;
using System;

namespace BoltTest.UnitTests
{
    [TestFixture]
    public class ShopTests
    {
        private Shop shop;

        [SetUp]
        public void SetUp()
        {
            shop = new Shop();
        }

        [Test]
        [Category("Store")]
        //[Ignore("Mert megtehetem hogy leszarom!")]
        public void ValidProduct_Store_SuccesfullyStored()
        {
            // Arrange
            //var shop = new Shop();
            var product = new Product(1, 5);

            // Act
            bool success = shop.Store(product);

            // Assert
            Assert.That(success, Is.True);
        }

        [Test]
        [Category("Store")]
        //[Ignore("Mert megtehetem hogy leszarom!")]
        public void DuplicateProduct_Store_ReturnsFalse()
        {
            // Arrange
            //var shop = new Shop();
            var testProduct = new Product(1, 5);

            // Act
            shop.Store(testProduct);
            bool success = shop.Store(testProduct);

            // Assert
            Assert.That(success, Is.False);
        }

        [Test]
        [Category("StoreMultiple")]
        public void DistincProduct_StoreMultiple_SuccesfullyStored()
        {
            // Arrange
            //var shop = new Shop();
            var products = new[]
            {
                new Product(1,3),
                new Product(2,2),
                new Product(3,9),
            };

            // Act
            bool succes = shop.StoreMultiple(products);

            // Assert
            Assert.That(succes, Is.True);
        }

        [Test]
        [Category("StoreMultiple")]
        public void DistincProduct_StoreMultiple_UnsuccesfullyStored()
        {
            // Arrange
            //var shop = new Shop();
            var products = new[]
            {
                new Product(1,3),
                new Product(2,2),
                new Product(3,9),
            };
            var duplicateProduct = products[0];
            shop.Store(duplicateProduct);

            // Act
            bool succes = shop.StoreMultiple(products);            

            // Assert
            Assert.That(succes, Is.False);
        }

        [TestCase(new[] { 2, 4 }, 3)]
        [TestCase(new[] { 2, 3, 5 }, 3.333)]
        [TestCase(new[] { 5, 3, 5, 109 }, 30.5)]
        public void DistinctProducts_GetAvaragePrice_AvarageCalculated(
            int[] prices, 
            double expectedAvaragePrice)
        {
            // Arrange
            //var shop = new Shop();
            for (int i = 0; i < prices.Length; i++)
            {
                shop.Store(new Product(i, prices[i]));
            }

            // Act
            double avarage = shop.GetAvaragePrice();

            // Assert
            Assert.That(avarage, Is.EqualTo(expectedAvaragePrice).Within(0.001));
        }
    }
}
