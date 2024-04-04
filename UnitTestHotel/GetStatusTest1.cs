using Hotel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestHotel
{
    [TestClass]
    public class GetStatusTest1
    {
        [TestMethod]
        public void GetStatusTestMethod1()
        {
            int statusNum = 2;

            MainForm mainForm = new MainForm();
            string statusStr = mainForm.GetStatus(statusNum);
            Assert.AreEqual(statusStr, "Свободные");
        }
    }
}
