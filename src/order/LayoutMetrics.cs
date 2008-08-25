using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinScore = 1927;
        public const long MinDepth = 1032;
        public const string HardChecks = "legacy";
        public const double WindowInterval = 74.17;
        public const long BaseLevel = 139;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((target / 9) >= 28)
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Size { get; set; }
            public long Level { get; set; }
        }
    }
}
