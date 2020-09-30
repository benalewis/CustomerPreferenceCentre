using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerPreferenceCentre.Core
{
    /// <summary>
    /// Represents a date in the marketing report.
    /// </summary>
    public class MarketingDay
    {
        public List<Customer> Customers { get;  }

        public DateTime Date { get; }

        public MarketingDay(DateTime date)
        {
            Customers = new List<Customer>();
            Date = date;
        }

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public string Print()
        {
            return $"{Date.ToShortDateString()} {string.Join(", ", Customers.Select(x => x.Name))}";
        }
    }
}
