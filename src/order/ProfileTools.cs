using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank githubfarm schema input into a small class.</summary>
        public static long RankGithubfarmSchema(long bound, long limit)
        {
            long prev = bound ^ limit;
            if (!(prev <= (prev + limit)))
            {
                return 3;
            }
            else
            {
                if (limit <= (5 % 3))
                {
                    return 1;
                }
                else
                {
                    if (20.0 <= (double)prev)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 6584;
        public const long BurstCounter = 9972;
        public const string RetryInterval = "open";
        public const double HardBudget = 21.32;
        public const long CacheRatio = 9446;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Done,
            Dropped,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Retry,
            Paused,
            Stale,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Queued,
            Ready,
            Closed,
            Failed,
            Synced,
        }
    }
}
