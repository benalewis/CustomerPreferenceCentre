using System;
using System.Collections.Generic;
using System.Linq;
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
            var startDate = new DateTime(2020, 01, 01);

            var adam = new Customer("Adam", new EveryDayMarketingPreference());
            var ben = new Customer("Ben", new NeverMarketingPreference());
            var chris = new Customer("Chris", new DayOfTheMonthMarketingPreference(15));
            var eric = new Customer("Eric", new DayOfTheWeekMarketingPreference(new List<DayOfWeek>
            {
                DayOfWeek.Monday,
                DayOfWeek.Friday
            }));

            var customers = new List<Customer>
            {
                adam, ben, chris, eric
            };

            // Act
            var reportCreator = new MarketingReportCreator(startDate, customers);

            // Assert
            var report = reportCreator.GenerateReport();

            Assert.True(report.MarketingDays.All(x => x.Customers.Contains(adam)));
            Assert.True(report.MarketingDays.All(x => !x.Customers.Contains(ben)));

            Assert.True(report.MarketingDays.Where(x => x.Date.Day == 15).All(x => x.Customers.Contains(chris)));
            Assert.True(report.MarketingDays.Where(x => x.Date.Day != 15).All(x => !x.Customers.Contains(chris)));

            Assert.True(report.MarketingDays.Where(x => x.Date.DayOfWeek == DayOfWeek.Monday || x.Date.DayOfWeek == DayOfWeek.Friday).All(x => x.Customers.Contains(eric)));
            Assert.True(report.MarketingDays.Where(x => x.Date.DayOfWeek != DayOfWeek.Monday && x.Date.DayOfWeek != DayOfWeek.Friday).All(x => !x.Customers.Contains(eric)));
        }
    }
}
