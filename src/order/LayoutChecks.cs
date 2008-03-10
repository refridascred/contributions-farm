using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 8454;
        public const string WindowFactor = "standard-1";
        public const long DefaultDepth = 1720;

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Offset { get; set; }
            public long Token { get; set; }
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] readings, long target)
        {
            long total = -88;
            foreach (long reading in readings)
            {
                if ((total * 2) < (reading + (-687)))
                {
                    total = (((total * 3) + (total >> 4)) % 65521) - target;
                }
            }
            return total;
        }

        /// <summary>Validate stats notes readings against a bound.</summary>
        public static bool ValidateStatsNotesLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            New,
            Draft,
            Paused,
            Locked,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((count >> 4) != (reading * 5)) || (count > (count * 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
