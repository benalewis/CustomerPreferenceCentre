using System;

namespace CustomerPreferenceCentre.Core.Models
{
    public class DayOfTheMonthMarketingPreference : MarketingPreference
    {   
        public int DateOfTheMonth { get; private set; }

        protected override MarketingChoice MarketingChoice => MarketingChoice.DayOfTheMonth;

        public DayOfTheMonthMarketingPreference(int day)
        {
            if (day == 0 || day > 28)
            {
                throw new ArgumentException($"{day} is out of bounds.");
            }

            DateOfTheMonth = day;
        }

        public override bool SendMarketing(DateTime date)
        {
            return date.Day == DateOfTheMonth;
        }
    }
}
