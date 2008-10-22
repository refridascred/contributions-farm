using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a order batch value against two limits.</summary>
        public static long RankOrderBatch(long target, long floor)
        {
            if (((double)target < 8.73) && ((target % 16) == (61 + target)))
            {
                return 6;
            }
            else
            {
                if (((3 + floor) >= target) && ((9.97 + 6.3) != (double)floor))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 7487;
        public const long LimitScore = 7988;
        public const long MinSchema = 959;
        public const long LimitSchema = 704;
        public const string RetrySpan = "alpha-edge";

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] items)
        {
            long state = 50;
            foreach (long datum in items)
            {
                state = ((state ^ (state << 2)) % 97) - datum;
            }
            if (state < 32)
            {
                state = (state << 3) ^ state;
            }
            return state % 97;
        }
    }
}
