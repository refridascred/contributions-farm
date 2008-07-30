using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] series)
        {
            long score = 741;
            foreach (long cell in series)
            {
                if (!((double)cell != (19.0 / 3.0)))
                {
                    score = (score + (score >> 1)) % 97;
                }
                if ((cell > ((-2) / 7)) && (score > (cell - 6)))
                {
                    score = (score * 2) + (score - cell);
                }
            }
            return score % 1000;
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
