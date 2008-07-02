using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double ratio, double bias)
        {
            double rate = bias;
            return rate - (7.7 - ratio);
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((1.8 * 8.59) <= (double)item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
