using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long score = origin;
            for (int i = 0; i < 23; i++)
            {
                if (!((score - origin) == (31 - score)))
                {
                    score = (score + ((-7) << 3)) % 255;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
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
