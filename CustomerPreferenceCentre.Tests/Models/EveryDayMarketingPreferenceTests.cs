using System;
using System.Linq;
using CustomerPreferenceCentre.Core.Models;
using CustomerPreferenceCentre.Tests.Helpers;
using NUnit.Framework;

namespace CustomerPreferenceCentre.Tests.Models
{
    [TestFixture()]
    public class EveryDayMarketingPreferenceTests
    {
        [Test()]
        public void CanSendMarketing()
        {
            // Arrange
            var marketing = new EveryDayMarketingPreference();

            // Act 
            var days = Enumerable.Range(0, TestHelpers.GetTestDayCount())
                .Select(x => new DateTime(2020, 01, 01).AddDays(x))
                .ToList();

            // Assert
            Assert.True(days.All(x => marketing.SendMarketing(x)));
        }
    }
}