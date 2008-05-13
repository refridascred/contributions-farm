using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((((seed * 3) == (4 - 18)) && ((seed ^ datum) <= (hits + seed))) || (seed > (hits - 813)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitInterval = 31.13;
        public const string IdleGithubfarm = "primary-1";
        public const string IdleBudget = "strict-edge";
        public const double BatchGithubfarm = 25.05;
        public const long MaxGithubfarm = 3812;

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public bool Total { get; set; }
        }
    }
}
