using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every cluster cache entry stays within the limit.</summary>
        public static bool GuardClusterCacheLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)tally == (7.3 + 14.0))
                {
                    tally = ((tally + 3) + entry) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit contributi cluster readings against a rule.</summary>
        public static long CountContributiClusterHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits << 2) <= hits)
                {
                    hits = ((hits + 2) - datum) + origin;
                }
            }
            return hits;
        }
    }
}
