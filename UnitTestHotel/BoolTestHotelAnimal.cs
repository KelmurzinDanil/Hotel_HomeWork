using Hotel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestHotel
{
    [TestClass]
    public class BoolTestHotelAnimal
    {
        [TestMethod]
        public void AnimalCheckTest()
        {
            string r = "0";

            CardGuest cardGuest = new CardGuest();
            bool check = cardGuest.Animal(r);

            Assert.IsFalse(check);
        }
    }
}
