using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            Locked,
            Done,
            Closed,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] readings, long origin)
        {
            long score = 17;
            foreach (long datum in readings)
            {
                if ((score + datum) <= (origin + 8))
                {
                    score = (score * 4) + (763 + origin);
                }
            }
            return score;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits + hits) <= (hits << 2))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }
    }
}
