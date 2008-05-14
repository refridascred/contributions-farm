using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many checks graph samples are out of range.</summary>
        public static long MeasureChecksGraphHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!(5.7 >= (double)count) && ((6.64 / 8.0) <= (double)count))
                {
                    count = (count + 3) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Level { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
