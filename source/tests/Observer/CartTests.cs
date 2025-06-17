using DesignPatterns.Observer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Tests
{
    [TestClass]
    public class CartTests
    {
        [TestMethod]
        public void AddItem_Should_Notify_Observers()
        {
            // Arrange
            var cart = new Cart();
            var observer = new TestObserver();
            cart.RegisterObserver(observer);

            // Act
            cart.AddItem("Maus");

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(observer.WasNotified);
        }

        [TestMethod]
        public void RemoveItem_Should_Notify_Observers()
        {
            // Arrange
            var cart = new Cart();
            var observer = new TestObserver();
            cart.AddItem("Tastatur");
            cart.RegisterObserver(observer);

            // Act
            cart.RemoveItem("Tastatur");

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(observer.WasNotified);
        }

        [TestMethod]
        public void Observer_Should_Be_Removable()
        {
            // Arrange
            var cart = new Cart();
            var observer = new TestObserver();
            cart.RegisterObserver(observer);
            cart.RemoveObserver(observer);

            // Act
            cart.AddItem("Monitor");

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(observer.WasNotified);
        }

        [TestMethod]
        public void Cart_Should_Store_Added_Items()
        {
            // Arrange
            var cart = new Cart();

            // Act
            cart.AddItem("Webcam");
            cart.AddItem("Headset");

            // Assert
            var items = cart.GetItems();
            CollectionAssert.AreEqual(new List<string> { "Webcam", "Headset" }, items);
        }
    }
}
