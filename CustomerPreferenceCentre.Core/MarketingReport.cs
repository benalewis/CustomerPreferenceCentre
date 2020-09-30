using System;
using System.Collections.Generic;

namespace CustomerPreferenceCentre.Core
{
    public class MarketingReport
    {
        public DateTime StartDate { get; set; }
        public List<MarketingDay> MarketingDays { get; set; }
    }
}
