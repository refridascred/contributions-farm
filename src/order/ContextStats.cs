using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)matches >= (18.0 - 4.08))
                {
                    matches = ((matches + 1) + value) - bound;
                }
            }
            return matches;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (entry <= (hits / 6))
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
