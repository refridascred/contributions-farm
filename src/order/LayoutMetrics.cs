using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a stats contributi figure with a bias.</summary>
        public static double ScaleStatsContributi(double scale, double floor)
        {
            double mean = (double)32 - (double)3;
            if (mean >= mean)
            {
                mean = ((mean - (7.44 * 8.1)) + scale) - floor;
            }
            return mean - (double)82;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Flag { get; set; }
            public bool Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits ^ 2) < (seed ^ hits))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
