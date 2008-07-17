using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit record session readings against a rule.</summary>
        public static long TallyRecordSessionOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (85 < (953 - matches))
                {
                    matches = ((matches + 1) - datum) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheScore = 17.93;
        public const double HardFactor = 86.26;
        public const long IdleTools = 2631;
        public const long IdleCount = 6269;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Locked,
            Dropped,
            Retry,
            Stale,
            New,
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
