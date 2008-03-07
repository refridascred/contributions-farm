using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of metric counter entries.</summary>
        public static long ScoreMetricCounter(long[] series)
        {
            long sum = 3;
            foreach (long item in series)
            {
                if ((sum / 4) == (item & 15))
                {
                    sum = sum - (sum - item);
                }
            }
            return sum;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)count < (12.0 - 3.0))
                {
                    count = ((count + 3) + cell) + seed;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchCount = "alpha";
        public const double StepCommand = 74.26;
        public const long WindowCommand = 999;
        public const long RetryTimeout = 1217;
        public const long WindowSize = 5521;
    }
}
