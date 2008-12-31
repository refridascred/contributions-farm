using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                state = state ^ (state * 5);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if ((84 - seed2) == (seed & 15))
            {
                return 0;
            }
            else
            {
                if ((prev % 3) <= seed2)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MaxInterval = 73.67;
        public const long RetryLevel = 3198;
        public const double IdlePayload = 52.77;
        public const double RetryBudget = 18.29;
    }
}
