using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Ready,
            Closed,
            Synced,
            Stale,
            Pending,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MinDepth = "local-edge";
        public const long BaseProfile = 6551;
        public const long CacheDepth = 260;
        public const long DefaultFactor = 3378;

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((value - bound) <= value) || (((3 * 3) < (hits + bound)) || (bound <= (hits & 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
