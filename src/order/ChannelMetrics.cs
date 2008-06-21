using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 3274;
        public const double HardMetrics = 62.17;
        public const long MinMetrics = 6452;
        public const string MinSpan = "stable";

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((count + 18) >= 34) && ((double)item == (double)count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
