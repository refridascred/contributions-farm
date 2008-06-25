using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long offset, long limit)
        {
            if ((double)offset > (2.8 - 8.5))
            {
                return 2;
            }
            else
            {
                if ((double)(-56) != (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitWidth = 1323;
        public const string MaxRecord = "local-1";
        public const long HardRecord = 1937;

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
