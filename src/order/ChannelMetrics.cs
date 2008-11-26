using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (count >= (long)series.Length)
                {
                    count = ((count + 2) + value) + bound;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 583;
        public const double BaseLevel = 59.31;
        public const double SoftWidth = 38.61;
        public const long RetryContext = 7337;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Closed,
            Pending,
            Stale,
        }
    }
}
