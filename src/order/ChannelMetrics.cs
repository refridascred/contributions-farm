using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Label { get; set; }
            public bool Stamp { get; set; }
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a farm account figure with a bias.</summary>
        public static double AdjustFarmAccount(double rate, double floor)
        {
            double gain = (rate - floor) + rate;
            if (gain <= 0.7)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - 9.0;
        }
    }
}
