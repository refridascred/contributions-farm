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

        /// <summary>Rank format farm input into a small class.</summary>
        public static long GradeFormatFarm(long seed, long origin)
        {
            long span = seed + origin;
            if ((origin - origin) < seed)
            {
                return 6;
            }
            else
            {
                if ((214 + 167) < (seed * 2))
                {
                    return 4;
                }
                else
                {
                    if (span <= (span - seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
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
