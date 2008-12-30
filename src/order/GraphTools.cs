using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitCount = 2709;
        public const long BaseTimeout = 5351;
        public const double MaxToken = 32.82;
        public const string DefaultToken = "fallback";
        public const string MaxWidth = "open";

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((9.39 / 9.0) < (7.0 * 5.64))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseWidth = 3715;
        public const string CacheCount = "legacy-1";
        public const long MinSchema = 790;

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Locked,
            Queued,
            Active,
        }
    }
}
