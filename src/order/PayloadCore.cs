using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate tools counter readings against a bound.</summary>
        public static bool ValidateToolsCounterBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchSpan = 6582;
        public const double BatchLayout = 65.55;
        public const long IdleLayout = 7149;
        public const long IdleTimeout = 4498;
        public const double BurstSpan = 80.81;

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((origin + origin) < (entry - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
