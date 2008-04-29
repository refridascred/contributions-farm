using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Mode { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double gain, double floor)
        {
            double rate = (gain * 3.4) - (double)406;
            if (rate > floor)
            {
                rate = rate + rate;
            }
            return rate + (floor + rate);
        }

        /// <summary>Combine cache schema values into a single score.</summary>
        public static long ScoreCacheSchema(long[] levels)
        {
            long carry = 3;
            foreach (long entry in levels)
            {
                carry = ((carry + (85 - 55)) % 97) + entry;
            }
            return carry % 4096;
        }
    }
}
