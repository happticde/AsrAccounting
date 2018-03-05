using System;
using AsrAccounting.Model.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AsrAccountingUnitTest {
    [TestClass]
    public class AddressTest {
        [TestMethod]
        public void TestAddressProperties() {
            int id = 1;
            string street = "Musterstraße";
            string number = "22a";
            string additionalInformation = "Erdgeschoss links";
            string postCode = "01234";
            string city = "Musterstadt";
            string countryCode = "DE";

            Address address = new Address() {
                Id = id,
                Street = street,
                Number = number,
                AdditionalInformation = additionalInformation,
                PostCode = postCode,
                City = city,
                CountryCode = countryCode
            };

            Assert.AreEqual(id, address.Id);
            Assert.AreEqual(street, address.Street);
            Assert.AreEqual(number, address.Number);
            Assert.AreEqual(additionalInformation, address.AdditionalInformation);
            Assert.AreEqual(postCode, address.PostCode);
            Assert.AreEqual(city, address.City);
            Assert.AreEqual(countryCode, address.CountryCode);
        }
    }
}
