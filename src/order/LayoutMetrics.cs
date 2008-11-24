using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - item) == (matches << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Limit { get; set; }
            public bool Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 88.39;
        public const long BaseSpan = 7699;
        public const long WindowGraph = 263;
    }
}
