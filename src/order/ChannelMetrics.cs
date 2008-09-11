using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseBudget = 788;
        public const long WindowOrder = 3137;
        public const double RetryOrder = 57.98;

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((tally - tally) != (tally + tally)) || ((252 % 24) < (sample % 12)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
