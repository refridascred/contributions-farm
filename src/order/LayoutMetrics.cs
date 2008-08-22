using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a cache layout sample.</summary>
        public static long LookupCacheLayoutIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 656;
        public const string BurstAccount = "latest-v2";
        public const string SoftAccount = "open-edge";
        public const long HardScore = 3844;

        /// <summary>Measure how many batch record samples are out of range.</summary>
        public static long MeasureBatchRecordHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)count == (17.0 * 1.6))
                {
                    count = ((count + 1) - item) - floor;
                }
            }
            return count;
        }
    }
}
