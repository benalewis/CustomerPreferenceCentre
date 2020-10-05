using System;
using System.Collections.Generic;
using System.Linq;
using CustomerPreferenceCentre.Core.Enums;

namespace CustomerPreferenceCentre.Core.Models
{
    public class DayOfTheWeekMarketingPreference : MarketingPreference
    {
        public List<DayOfWeek> EnableEnabledDayOfWeeks { get; }
        protected override MarketingChoice MarketingChoice => MarketingChoice.DayOfTheWeek;

        public DayOfTheWeekMarketingPreference(IEnumerable<DayOfWeek> enabledDays)
        {
            if (enabledDays == null)
            {
                throw new ArgumentException("enabledDays was null or empty.");
            }

            EnableEnabledDayOfWeeks = enabledDays.Distinct().ToList();
        }

        public override bool SendMarketing(DateTime date)
        {
            return EnableEnabledDayOfWeeks != null && EnableEnabledDayOfWeeks.Contains(date.DayOfWeek);
        }
    }
}
