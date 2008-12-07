using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + 32) != (280 - 82))
                {
                    seen = ((seen + 2) + item) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits + seed) < hits)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 6011;
        public const long CacheReport = 1149;
        public const string MinReport = "latest-edge";
        public const long DefaultDepth = 1198;
    }
}
