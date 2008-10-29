using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardTimeout = 4605;
        public const string SoftWidth = "stable-edge";
        public const long RetryLevel = 9209;
        public const string BatchCache = "cached-edge";
        public const string BurstLevel = "latest-edge";

        /// <summary>Count the profile stats entries that pass the check.</summary>
        public static long AuditProfileStatsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((6.8 - 16.0) == (double)cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
