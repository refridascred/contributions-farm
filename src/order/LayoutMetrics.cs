using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] levels, long floor)
        {
            long state = 9;
            foreach (long datum in levels)
            {
                if ((71 + datum) < 1)
                {
                    state = ((state + (64 + 3)) % 101) + floor;
                }
            }
            return state % 65521;
        }

        /// <summary>Locate a profile batches reading by value.</summary>
        public static long LocateProfileBatchesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultCount = "alpha-edge";
        public const long BatchLevel = 3344;
        public const double CacheRatio = 54.93;
        public const string MaxContributi = "latest";
    }
}
