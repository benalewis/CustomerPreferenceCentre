using System;
using System.Collections.Generic;
using System.Linq;

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
            var totalMarketingDays = Enumerable.Range(0, days)
                .Select(x => StartDate.AddDays(x))
                .Select(day => new MarketingDay(day, Customers.Where(customer => customer.MarketingChoice.SendMarketing(day))))
                .ToList();

            return new MarketingReport(totalMarketingDays);
        }
    }
}
