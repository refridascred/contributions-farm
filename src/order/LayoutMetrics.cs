using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 124;
        public const string RetryRatio = "alpha";
        public const long HardLevel = 8976;
        public const long SoftBatches = 3613;

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long origin, long limit)
        {
            long prev = origin + limit;
            if (origin <= (limit / 7))
            {
                return 4;
            }
            else
            {
                if ((limit + limit) == (prev ^ limit))
                {
                    return 7;
                }
                else
                {
                    if ((prev - origin) < 317)
                    {
                        return 6;
                    }
                    else
                    {
                        if (17 > (935 - origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
