using Hotel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestHotel
{
    [TestClass]
    public class GetStatusTest2
    {
        [TestMethod]
        public void GetStatusTestMethod2()
        {
            int statusNum = 6;

            MainForm mainForm = new MainForm();
            string statusStr = mainForm.GetStatus(statusNum);
            Assert.AreEqual(statusStr, "Неизвестный статус");


        }
    }
}
