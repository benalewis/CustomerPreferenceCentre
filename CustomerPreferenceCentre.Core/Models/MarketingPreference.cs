using System;
using CustomerPreferenceCentre.Core.Enums;

namespace CustomerPreferenceCentre.Core.Models
{
    public abstract class MarketingPreference
    {
        protected abstract MarketingChoice MarketingChoice { get; }

        public abstract bool SendMarketing(DateTime date);
    }
}
