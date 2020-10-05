using System;
using CustomerPreferenceCentre.Core;
using CustomerPreferenceCentre.Core.Models;
using NUnit.Framework;

namespace CustomerPreferenceCentre.Tests
{
    [TestFixture]
    public class MarketingDayTests
    {
        [Test()]
        public void CanPrint()
        {
            // Arrange
            var marketingDay = new MarketingDay(new DateTime(2020, 01, 01));

            marketingDay.AddCustomer(new Customer("Joel", new EveryDayMarketingPreference()));
            marketingDay.AddCustomer(new Customer("Peter", new EveryDayMarketingPreference()));

            // Act
            var printResult = marketingDay.Print();

            // Assert
            Assert.AreEqual("01/01/2020 Joel, Peter", printResult);
        }
    }
}