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

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((3.0 / 3.0) < (double)reading) && !(reading >= tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
