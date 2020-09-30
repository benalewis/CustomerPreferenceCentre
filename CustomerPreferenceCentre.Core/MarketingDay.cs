using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerPreferenceCentre.Core
{
    /// <summary>
    /// Represents a day in the marketing report.
    /// </summary>
    public class MarketingDay
    {
        public List<Customer> Customers { get; set; }

        public DateTime Date { get; set; }
    }
}
