using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (reading < tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
