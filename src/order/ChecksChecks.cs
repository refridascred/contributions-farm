using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first window format entry that matches the target.</summary>
        public static long FindWindowFormatIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepLevel = "alpha-v2";
        public const long BurstRecord = 1861;
        public const string StepRecord = "primary-1";
        public const long MinRecord = 3924;
        public const long BaseScore = 4709;

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
