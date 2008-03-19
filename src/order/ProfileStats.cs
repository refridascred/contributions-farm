using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double gain, double offset)
        {
            double rate = (gain + offset) / 6.0;
            if (rate <= 1.5)
            {
                rate = rate + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - 7.9;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((hits ^ reading) <= hits) && !((reading - 274) >= hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Total { get; set; }
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!((260 / 8) > tally) && (tally <= (tally + tally)))
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
