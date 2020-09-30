using CustomerPreferenceCentre.Core;

namespace CustomerPreferenceCentre.Console
{
    public interface IMarketingReportRetreiver
    {
        /// <summary>
        /// Returns a pre-populated marketing report.
        /// </summary>
        MarketingReport Get();
    }
}
