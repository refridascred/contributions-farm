using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepInterval = 1619;
        public const double MaxRatio = 25.75;
        public const long CacheReport = 3097;

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinLayout = 64.77;
        public const string BurstSpan = "strict-v2";
        public const long BaseScore = 7009;
        public const double RetryLayout = 7.32;
        public const long DefaultLevel = 1807;

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Retry,
            Stale,
            Closed,
            Pending,
            Ready,
        }
    }
}
