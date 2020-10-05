using System;
using System.Linq;
using CustomerPreferenceCentre.Core.Models;
using CustomerPreferenceCentre.Tests.Helpers;
using NUnit.Framework;

namespace CustomerPreferenceCentre.Tests.Models
{
    [TestFixture]
    public class DayOfTheMonthMarketingPreferenceTests
    {
        [Test]
        public void CanSendMarketing()
        {
            // Arrange
            var marketing = new DayOfTheMonthMarketingPreference(15);

            // Act & Assert
            var days = Enumerable.Range(0, TestHelpers.GetTestDayCount())
                .Select(x => new DateTime(2020, 01, 01).AddDays(x))
                .ToList();

            foreach (var day in days)
            {
                Assert.True(day.Day == 15 ? marketing.SendMarketing(day) : !marketing.SendMarketing(day));
            }
        }
    }
}