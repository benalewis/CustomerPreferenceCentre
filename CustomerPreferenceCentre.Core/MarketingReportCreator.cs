using System;
using System.Collections.Generic;

namespace CustomerPreferenceCentre.Core
{
    public class MarketingReportCreator
    {
        public DateTime StartDate { get; set; }

        public List<Customer> Customers { get; set; }

        public MarketingReportCreator(DateTime startDate, List<Customer> customers)
        {
            StartDate = startDate;
            Customers = customers;
        }

        public MarketingReport GenerateReport(int days = 90)
        {
            var totalMarketingDays = new List<MarketingDay>();

            foreach (var day in EachDay(StartDate, StartDate.AddDays(days)))
            {
                var marketingDay = new MarketingDay(day);

                foreach (var customer in Customers)
                {
                    if (customer.MarketingChoice.SendMarketing(day))
                    {
                        marketingDay.AddCustomer(customer);
                    }
                }

                totalMarketingDays.Add(marketingDay);
            }

            return new MarketingReport(totalMarketingDays);
        }

        /// <summary>
        /// Returns a date range between two dates.
        /// </summary>
        /// <remarks>Lifted from: https://stackoverflow.com/a/1847601 </remarks>
        private static IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }
    }
}
