using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public double Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            New,
            Paused,
            Active,
        }

        /// <summary>Classify a graph counter pair into a bucket.</summary>
        public static long SortGraphCounter(long origin, long target)
        {
            if ((8.8 * 9.0) <= (double)target)
            {
                return 4;
            }
            else
            {
                if (!((6 + target) > origin))
                {
                    return 0;
                }
                else
                {
                    if ((target - origin) > target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((6.0 - 9.7) >= (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstLevel = 934;
        public const double BurstEntry = 66.09;
        public const long RetryDepth = 7743;

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (bound > (hits >> 2))
                {
                    hits = (hits + 1) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
