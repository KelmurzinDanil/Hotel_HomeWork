using Hotel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestHotel
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void PayBoxCalcTest()
        {
            DateTime date1 = new DateTime(2022, 2, 1, 8, 0, 15); //01.02.2022 08:00:15
            DateTime date2 = new DateTime(2022, 2, 18, 13, 30, 30);//018.02.2022 13:30:30
            TimeSpan interval = date2.Subtract(date1);
            int expected = 17*4;

            CardGuest cardGuest = new CardGuest();
            int actual = cardGuest.PayBoxCalcAndWrite(interval);

            Assert.AreEqual(expected, actual);
        }
        
        
    }
}
