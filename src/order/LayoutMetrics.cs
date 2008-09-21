using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!((6.43 * 8.2) > (double)hits) || (((double)(long)readings.Length <= (12.0 + 16.0)) || ((16.0 + 0.3) != (double)value)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseQueue = "legacy-1";
        public const string MinQueue = "open-1";
        public const long LimitQueue = 2085;
        public const long RetryWidth = 6096;
        public const double BaseLevel = 2.61;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Done,
            Dropped,
        }
    }
}
