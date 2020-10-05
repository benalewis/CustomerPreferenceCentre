using System;
using System.Collections.Generic;
using System.Linq;
using CustomerPreferenceCentre.Core.Models;
using CustomerPreferenceCentre.Tests.Helpers;
using NUnit.Framework;

namespace CustomerPreferenceCentre.Tests.Models
{
    [TestFixture]
    public class DayOfTheWeekMarketingPreferenceTests
    {
        [Test]
        public void CanSendMarketing()
        {
            // Arrange
            var daysOfTheWeek = new List<DayOfWeek>
            {
                DayOfWeek.Monday,
                DayOfWeek.Friday
            };

            // Act
            var marketing = new DayOfTheWeekMarketingPreference(daysOfTheWeek);
            var days = Enumerable.Range(0, TestHelpers.GetTestDayCount()).Select(x => new DateTime(2020, 10, 05).AddDays(x)).ToList();

            // Assert
            foreach (var day in days)
            {
                Assert.True(daysOfTheWeek.Contains(day.DayOfWeek) ? marketing.SendMarketing(day) : !marketing.SendMarketing(day));
            }
        }
    }
}