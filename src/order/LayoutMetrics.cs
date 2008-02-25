using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultCommits = "legacy-1";
        public const double MinScore = 43.07;
        public const double SoftBudget = 16.82;
        public const long CacheRatio = 7287;

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the tools stream entries that pass the check.</summary>
        public static long AuditToolsStreamHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item % 2) <= matches)
                {
                    matches = (matches + 1) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
