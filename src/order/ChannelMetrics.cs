using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Paused,
            Pending,
            Locked,
            Draft,
            Synced,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardInterval = 8563;
        public const double DefaultDepth = 76.23;
        public const long HardBudget = 6697;
        public const long IdleContext = 1683;

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
