using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long RetryRatio = 6088;
        public const string BatchInterval = "open-edge";
        public const long BurstWidth = 9160;
        public const double HardToken = 94.38;

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] series)
        {
            long mark = 592;
            foreach (long reading in series)
            {
                if (((double)40 < (double)mark) || ((mark / 8) >= (mark << 1)))
                {
                    mark = ((mark << 2) ^ reading) % 97;
                }
            }
            return mark;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Retry,
            Closed,
            Stale,
            Active,
            Draft,
        }
    }
}
