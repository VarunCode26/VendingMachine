using VendingMachine;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VendingMachine.Tests
{
    [TestClass()]
    public class UnitTest1
    {


        [TestMethod()]
        public void GetProductsTest()
        {
            Products.GetProducts();
            bool isExist = Products.isProductExist("cola");
            Assert.AreEqual(true, isExist);
        }

        [TestMethod()]
        public void CalculatePaymentTest()
        {
            
            bool isValidPayment = Transaction.CalculatePayment(1, 0.5, false);
            Assert.AreEqual(true, isValidPayment);
            
        }
    }
}
