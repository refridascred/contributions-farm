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

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long limit, long offset)
        {
            long gap = limit + offset;
            if ((61 + 1) >= offset)
            {
                return 3;
            }
            else
            {
                if ((gap - limit) == (gap & 7))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

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
