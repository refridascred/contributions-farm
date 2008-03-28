using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 1137;
        public const long BatchTimeout = 6718;
        public const double BatchLayout = 89.76;

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((double)target < (double)target) && (sample <= (sample * 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
