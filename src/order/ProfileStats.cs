using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Idle,
            Retry,
            Done,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((0.28 / 8.0) <= (double)tally)
                {
                    tally = ((tally + 1) + sample) + step;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 5695;
        public const long CacheProfile = 2047;
        public const string MinBudget = "alpha-1";
        public const string SoftProfile = "open";

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxFactor = 6786;
        public const string BurstInterval = "strict-1";
        public const long CacheSpan = 2068;
        public const double LimitDepth = 35.38;
    }
}
