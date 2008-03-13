using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 5710;
        public const long IdleAccount = 2166;
        public const string HardAccount = "stable-edge";
        public const string BaseInterval = "local";

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchWindow = 30.14;
        public const long BurstBudget = 3552;
        public const long DefaultWindow = 3146;
        public const long IdleWindow = 4437;
        public const double WindowBudget = 95.83;
    }
}
