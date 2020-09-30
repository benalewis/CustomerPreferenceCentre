﻿using System;

namespace CustomerPreferenceCentre.Core.Models
{
    public class EveryDayMarketingPreference : MarketingPreference
    {
        protected override MarketingChoice MarketingChoice => MarketingChoice.EveryDay;

        public override bool SendMarketing(DateTime date)
        {
            return true;
        }
    }
}
