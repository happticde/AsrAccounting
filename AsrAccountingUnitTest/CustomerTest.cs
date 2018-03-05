using System;
using AsrAccounting.Model.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AsrAccountingUnitTest {
    [TestClass]
    public class CustomerTest {
        [TestMethod]
        public void TestCustomerProperties() {
            int testId = 1;
            string testFirstName = "Max";
            string testLastName = "Mustermann";
            string testCompany = "Muster AG";

            Customer customer = new Customer() {
                Id = testId,
                FirstName = testFirstName,
                LastName = testLastName,
                Company = testCompany
            };

            Assert.AreEqual(testId, customer.Id);
            Assert.AreEqual(testFirstName, customer.FirstName);
            Assert.AreEqual(testLastName, customer.LastName);
            Assert.AreEqual(testCompany, customer.Company);
            Assert.IsNull(customer.Address);
        }
    }
}
