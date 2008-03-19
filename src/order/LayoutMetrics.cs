using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepFactor = "latest-edge";
        public const long DefaultCount = 1937;
        public const long DefaultBuffer = 6718;
        public const double MaxBuffer = 17.32;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample + sample) < (2 + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 811;
        public const double LimitReport = 25.13;
        public const long HardRatio = 3871;
        public const long BatchCount = 6659;
    }
}
