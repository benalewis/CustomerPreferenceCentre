using System;
using System.Collections.Generic;

namespace CustomerPreferenceCentre.Core
{
    public class MarketingReport
    {
        public List<MarketingDay> MarketingDays { get; }

        public MarketingReport(List<MarketingDay> marketingDays)
        {
            MarketingDays = marketingDays;
        }

        public string Print()
        {
            throw new NotImplementedException();
        }
    }
}
