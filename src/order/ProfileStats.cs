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

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinBuffer = 9.31;
        public const long RetryDepth = 4681;
        public const double CacheBuffer = 66.8;
        public const double WindowFactor = 56.01;

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
