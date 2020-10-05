using System;
using System.Collections.Generic;
using System.Linq;
using CustomerPreferenceCentre.Core.Models;

namespace CustomerPreferenceCentre.Core
{
    /// <summary>
    /// Represents a date in the marketing report.
    /// </summary>
    public class MarketingDay
    {
        public List<Customer> Customers { get; }

        public DateTime Date { get; }

        public MarketingDay(DateTime date)
        {
            Customers = new List<Customer>();
            Date = date;
        }

        public MarketingDay(DateTime date, IEnumerable<Customer> customers)
        {
            Date = date;
            Customers = customers.ToList();
        }

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        /// <summary>
        /// Prints the <see cref="Date"/> entity with the list of customers in a formatted string.
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            return $"{Date.ToShortDateString()} {string.Join(", ", Customers.Select(x => x.Name))}";
        }
    }
}
