using System;
using System.Collections.Generic;
using System.Linq;
using CustomerPreferenceCentre.Core;
using CustomerPreferenceCentre.Core.Models;
using NUnit.Framework;

namespace CustomerPreferenceCentre.Tests
{
    [TestFixture]
    public class MarketingReportTests
    {
        private MarketingReportCreator _reportCreator;

        private readonly Customer _adam = new Customer("Adam", new EveryDayMarketingPreference());
        private readonly Customer _ben = new Customer("Ben", new NeverMarketingPreference());
        private readonly Customer _chris = new Customer("Chris", new DayOfTheMonthMarketingPreference(15));
        private readonly Customer _eric = new Customer("Eric", new DayOfTheWeekMarketingPreference(new List<DayOfWeek>
        {
            DayOfWeek.Monday,
            DayOfWeek.Friday
        }));

        [SetUp]
        public void SetUp()
        {
            var startDate = new DateTime(2020, 01, 01);

            var customers = new List<Customer>
            {
                _adam, _ben, _chris, _eric
            };

            _reportCreator = new MarketingReportCreator(startDate, customers);
        }

        [Test]
        public void CanProduceMarketingReport()
        {
            // Act
            var report = _reportCreator.GenerateReport();

            // Assert
            Assert.True(report.MarketingDays.All(x => x.Customers.Contains(_adam)));
            Assert.True(report.MarketingDays.All(x => !x.Customers.Contains(_ben)));

            Assert.True(report.MarketingDays.Where(x => x.Date.Day == 15).All(x => x.Customers.Contains(_chris)));
            Assert.True(report.MarketingDays.Where(x => x.Date.Day != 15).All(x => !x.Customers.Contains(_chris)));

            Assert.True(report.MarketingDays.Where(x => x.Date.DayOfWeek == DayOfWeek.Monday || x.Date.DayOfWeek == DayOfWeek.Friday).All(x => x.Customers.Contains(_eric)));
            Assert.True(report.MarketingDays.Where(x => x.Date.DayOfWeek != DayOfWeek.Monday && x.Date.DayOfWeek != DayOfWeek.Friday).All(x => !x.Customers.Contains(_eric)));
        }

        [Test]
        public void CanPrint()
        {
            // Arrange
            var report = _reportCreator.GenerateReport();

            // Act
            var stringResult = report.Print();

            // Assert
            Assert.NotNull(stringResult);
        }
    }
}
