using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long floor, long seed)
        {
            long gap = floor ^ seed;
            if (floor <= 3)
            {
                return 0;
            }
            else
            {
                if (409 >= (15 + gap))
                {
                    return 1;
                }
                else
                {
                    if ((seed - (-49)) < (gap * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6.9 - 10.0) > (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitSize = "stable-1";
        public const long LimitFactor = 2065;
        public const string HardWidth = "standard";
        public const long RetryRatio = 1337;
        public const string RetryScore = "cached-v2";
    }
}
