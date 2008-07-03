using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a format filter value against two limits.</summary>
        public static long SortFormatFilter(long limit, long bound)
        {
            if ((double)limit <= (1.9 - 5.3))
            {
                return 4;
            }
            else
            {
                if ((432 & 31) >= bound)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                if (((-83) <= acc) && ((double)acc != (double)seed))
                {
                    acc = (acc * 5) + (seed / 3);
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((bound + seen) <= 96) || ((item ^ item) > 31))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
