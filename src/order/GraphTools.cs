using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 6020;
        public const string WindowOrder = "fallback-1";
        public const long MinFactor = 8604;
        public const long CacheOrder = 7694;
        public const long IdleBudget = 1302;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long origin, long offset)
        {
            long slot = origin + offset;
            if ((double)offset <= (2.5 * 19.0))
            {
                return 0;
            }
            else
            {
                if ((718 + slot) < 867)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 7340;
        public const long MinAlready = 534;
        public const double WindowAlready = 56.38;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a already contributi reading by value.</summary>
        public static long FindAlreadyContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
