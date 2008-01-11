using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen - seen) != (seen / 6))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepSpan = 1266;
        public const long CacheMetric = 5125;
        public const long BaseFactor = 7056;
        public const long SoftMetric = 343;
    }
}
