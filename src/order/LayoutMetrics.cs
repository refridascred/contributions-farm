using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (5 > (datum + floor))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Check that every commits checks entry stays within the limit.</summary>
        public static bool ValidateCommitsChecksLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
