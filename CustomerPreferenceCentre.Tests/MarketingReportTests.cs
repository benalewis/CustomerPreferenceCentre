using System;
using System.Collections.Generic;
using System.Text;
using CustomerPreferenceCentre.Core;
using CustomerPreferenceCentre.Core.Models;
using NUnit.Framework;

namespace CustomerPreferenceCentre.Tests
{
    [TestFixture]
    public class MarketingReportTests
    {
        [Test]
        public void CanProduceMarketingReport()
        {
            // Arrange
            var customer = new Customer("Adam", new EveryDayMarketingPreference());
            var customer = new Customer("Ben", new NeverMarketingPreference());
            var customer = new Customer("Chris", new DayOfTheMonthMarketingPreference(15));
            var customer = new Customer("Eric", new DayOfTheWeekMarketingPreference(new List<DayOfTheWeekSelector>()));

            // Act

            // Assert
        }
    }
}
