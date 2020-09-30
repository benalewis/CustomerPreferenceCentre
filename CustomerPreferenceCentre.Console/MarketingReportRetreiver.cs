using CustomerPreferenceCentre.Core;
using CustomerPreferenceCentre.Core.Models;
using System;
using System.Collections.Generic;

namespace CustomerPreferenceCentre.Console
{
    public class MarketingReportRetreiver : IMarketingReportRetreiver
    {
        /// <inheritdoc/>
        public MarketingReport Get()
        {
            var startDate = new DateTime(2020, 01, 01);

            var _adam = new Customer("Adam", new EveryDayMarketingPreference());
            var _ben = new Customer("Ben", new NeverMarketingPreference());
            var _chris = new Customer("Chris", new DayOfTheMonthMarketingPreference(15));
            var _eric = new Customer("Eric", new DayOfTheWeekMarketingPreference(new List<DayOfWeek>
                {
                    DayOfWeek.Monday,
                    DayOfWeek.Friday
                }));

            var customers = new List<Customer>
            {
                _adam, _ben, _chris, _eric
            };

            var reportCreator = new MarketingReportCreator(startDate, customers);

            return reportCreator.GenerateReport();
        }
    }
}
