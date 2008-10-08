using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (hits >= (76 >> 2))
                {
                    hits = ((hits + 1) + item) + seed;
                }
            }
            return hits;
        }
    }
}
