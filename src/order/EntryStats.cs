using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Ready,
            Synced,
            Stale,
            Draft,
            New,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long origin, long limit)
        {
            long gap = origin ^ limit;
            if ((9.6 + 2.61) >= (double)gap)
            {
                return 3;
            }
            else
            {
                if ((gap * 4) > (limit << 3))
                {
                    return 0;
                }
                else
                {
                    if ((gap % 2) > (gap - origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                long matches = (mark - origin) + 75;
                if ((matches - (long)i) <= matches)
                {
                    mark = (mark + (origin - mark)) % 101;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
            public double Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Score { get; set; }
            public long Total { get; set; }
        }
    }
}
