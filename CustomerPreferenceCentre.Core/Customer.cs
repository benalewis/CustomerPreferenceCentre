using CustomerPreferenceCentre.Core.Models;

namespace CustomerPreferenceCentre.Core
{
    public class Customer
    {
        public string Name { get; }

        public MarketingPreference MarketingChoice { get; }

        public Customer(string name, MarketingPreference preference)
        {
            Name = name;
            MarketingChoice = preference;
        }
    }
}
