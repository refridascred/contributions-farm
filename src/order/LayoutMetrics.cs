using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long IdleWidth = 4764;
        public const string CacheCommand = "stable-v2";
        public const long MinInterval = 5492;
        public const string StepCommand = "legacy";
        public const long SoftCount = 3988;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((floor >> 5) >= (item * 4)) && !(((-2) - floor) >= (item % 97)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a token metric reading by value.</summary>
        public static long LookupTokenMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
