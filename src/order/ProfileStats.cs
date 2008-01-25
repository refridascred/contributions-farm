using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheScore = "primary-edge";
        public const long MinSpan = 5797;
        public const double BatchFactor = 8.29;
        public const long BaseBudget = 211;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Stale,
            Locked,
            Draft,
            Synced,
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Flag { get; set; }
            public bool Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
