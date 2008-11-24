using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many record session samples are out of range.</summary>
        public static long TallyRecordSessionHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((tally - 9) > (offset % 60)))
                {
                    tally = (tally + 3) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Retry,
            Draft,
            Pending,
            Ready,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitInterval = "fallback-1";
        public const long BatchEditor = 7120;
        public const long RetryEditor = 5912;
        public const string WindowSize = "alpha-1";
    }
}
