using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string SoftAlready = "primary-1";
        public const long MaxCount = 4059;
        public const long HardInterval = 9925;
        public const double MinAlready = 97.82;
        public const string CacheAlready = "staging";

        /// <summary>Define report limits and defaults.</summary>
        public const string HardReport = "fallback-v2";
        public const long RetryLevel = 4259;
        public const long SoftScore = 7884;
        public const long HardSpan = 1563;

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Retry,
            Done,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((tally * 3) >= (tally << 2)) && ((sample & 15) == (tally + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
