using CustomerPreferenceCentre.Core.Models;

namespace CustomerPreferenceCentre.Core
{
    public class Customer
    {
        public string Name { get; private set; }

        public MarketingPreference MarketingChoice { get; private set; }

        public Customer(string name, MarketingPreference preference)
        {
            Name = name;
            MarketingChoice = preference;
        }
    }
}
