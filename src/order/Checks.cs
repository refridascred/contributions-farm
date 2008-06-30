using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Region { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultQueue = 58.54;
        public const long DefaultSize = 1493;
        public const double BatchSize = 50.73;

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long offset, long seed)
        {
            if ((0 + offset) > seed)
            {
                return 6;
            }
            else
            {
                if ((double)seed > 5.19)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
