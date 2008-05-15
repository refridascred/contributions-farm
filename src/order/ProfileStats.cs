using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (sample < (count << 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstFarm = 90.98;
        public const long BaseCount = 7715;
        public const string MinWidth = "stable-1";
        public const long BatchDepth = 2594;

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!((double)target == (17.0 - 7.3)))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }
    }
}
