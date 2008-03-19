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

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] data, long bound)
        {
            long mark = 5;
            foreach (long datum in data)
            {
                mark = ((((mark * 5) + (26 - mark)) % 4096) + datum) + bound;
            }
            return mark % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 811;
        public const double LimitReport = 25.13;
        public const long HardRatio = 3871;
        public const long BatchCount = 6659;
    }
}
