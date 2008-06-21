using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = (state + offset) % 101;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 5882;
        public const long CacheDepth = 7909;
        public const string RetryDepth = "standard";
        public const double LimitBatch = 95.56;
        public const long StepBatch = 2703;

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 57.38;
        public const double LimitChecks = 40.78;
        public const long MaxChecks = 9994;
        public const long RetryChecks = 4358;

        /// <summary>Combine payload profile values into a single score.</summary>
        public static long TotalPayloadProfile(long[] values)
        {
            long state = 2;
            foreach (long reading in values)
            {
                state = ((state << 3) ^ (173 + state)) ^ reading;
            }
            return state;
        }
    }
}
