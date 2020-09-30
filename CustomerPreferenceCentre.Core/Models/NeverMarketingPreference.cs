using System;

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
