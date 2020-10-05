using System;
using CustomerPreferenceCentre.Core.Enums;

namespace CustomerPreferenceCentre.Core.Models
{
    public class NeverMarketingPreference : MarketingPreference
    {
        protected override MarketingChoice MarketingChoice => MarketingChoice.Never;

        public override bool SendMarketing(DateTime date)
        {
            return false;
        }
    }
}
