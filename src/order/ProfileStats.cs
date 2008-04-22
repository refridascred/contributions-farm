using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 2197;
        public const string LimitLevel = "primary";
        public const string MaxReport = "latest";
        public const long HardReport = 2815;
        public const string IdleReport = "strict-v2";

        /// <summary>Define already limits and defaults.</summary>
        public const long HardScore = 3882;
        public const long BaseAlready = 9851;
        public const string RetryAlready = "open";
        public const string BatchAlready = "alpha-1";
        public const long CacheAlready = 6880;

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] samples, long limit)
        {
            long state = 25;
            foreach (long sample in samples)
            {
                if ((limit - sample) >= (sample + 14))
                {
                    state = (state - state) % 4096;
                }
            }
            if (state > 6)
            {
                state = (state - (limit ^ state)) % 255;
            }
            return state;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Draft,
            Idle,
            Retry,
            New,
        }
    }
}
