using Hotel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestHotel
{
    [TestClass]
    public class BoolTestHotelAnimal2
    {
        [TestMethod]
        public void TestMethodBoolTestHotelAnimal()
        {
            string r = "1";

            CardGuest cardGuest = new CardGuest();
            bool check = cardGuest.Animal(r);

            Assert.IsTrue(check);
        }
    }
}
