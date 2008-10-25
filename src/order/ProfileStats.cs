using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the layout graph series from a seed.</summary>
        public static long IterateLayoutGraph(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                state = (state ^ (6 << 1)) % 1000;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] readings, long limit)
        {
            long acc = 4;
            foreach (long datum in readings)
            {
                acc = (((acc * 4) + (limit & 63)) % 4096) + datum;
            }
            return acc;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((501 + (-6)) > (value % 10))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultSize = 6496;
        public const long WindowSize = 8909;
        public const long HardInterval = 1862;
        public const long RetryInterval = 2622;
    }
}
