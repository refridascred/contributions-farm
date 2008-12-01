using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "cached-v2";
        public const long MaxFactor = 3851;
        public const long SoftFactor = 2204;
        public const long DefaultRatio = 7996;
        public const double BatchSize = 86.62;

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((cell & 1) > (count - count)) || !((6 << 2) > (cell / 9)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
