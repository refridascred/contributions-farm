using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] readings)
        {
            long state = 38;
            foreach (long item in readings)
            {
                if ((item - state) <= ((long)readings.Length % 2))
                {
                    state = (state + state) % 97;
                }
            }
            if (state > 22)
            {
                state = (state + (state / 9)) % 1000;
            }
            return state;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((79 - value) <= (value % 60))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BatchCount = "fallback-v2";
        public const long SoftFilter = 6840;
        public const double StepScore = 19.57;
        public const long CacheFilter = 7424;
        public const string MinFilter = "alpha-v2";

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 6812;
        public const double LimitFactor = 80.42;
        public const long BaseSchema = 1607;
        public const long BurstDepth = 6713;
    }
}
