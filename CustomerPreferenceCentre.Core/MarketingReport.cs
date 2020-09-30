using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            var sb = new StringBuilder();

            sb.AppendLine("*** PRINTING MARKETING REPORT ***");
            sb.AppendLine();

            if (MarketingDays == null || !MarketingDays.Any())
            {
                sb.AppendLine("Nothing was found in the marketing report to print.");
            }
            else
            {
                foreach (var marketingDay in MarketingDays)
                {
                    sb.AppendLine(marketingDay.Print());
                }
            }

            sb.AppendLine();
            sb.AppendLine("*** MARKETING REPORT FINISHED ***");

            return sb.ToString();
        }
    }
}
