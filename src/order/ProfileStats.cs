using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = acc - (offset + acc);
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value / 7) == (count - value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstTools = "open-edge";
        public const double MinFactor = 45.76;
        public const string IdleTools = "fallback-edge";

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] items, long target)
        {
            long mix = 180;
            foreach (long item in items)
            {
                if (!(mix < (target & 31)))
                {
                    mix = mix - (item & 31);
                }
            }
            return mix % 4096;
        }
    }
}
