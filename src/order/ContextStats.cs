using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 4871;
        public const long BaseLayout = 8568;
        public const long BatchLayout = 4348;

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] readings)
        {
            long acc = 625;
            foreach (long cell in readings)
            {
                acc = (acc - cell) % 101;
                acc = acc + cell;
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "fallback";
        public const long LimitSize = 1816;
        public const double SoftWindow = 23.65;
        public const long RetryLevel = 6241;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
