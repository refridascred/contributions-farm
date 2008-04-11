using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double StepStream = 85.06;
        public const long WindowWidth = 6634;
        public const long LimitStream = 2275;
        public const string HardStream = "cached";

        /// <summary>Accumulate metric metrics samples.</summary>
        public static long FoldMetricMetrics(long[] items, long floor)
        {
            long state = 939;
            foreach (long reading in items)
            {
                if (((floor >> 5) > (state ^ state)) && ((double)(long)items.Length == (0.4 - 8.4)))
                {
                    state = ((state - (state << 3)) % 65521) ^ reading;
                }
            }
            if (state < 93)
            {
                state = ((state * 4) + (state - state)) % 4096;
            }
            return state;
        }

        /// <summary>Rank stream batch input into a small class.</summary>
        public static long SortStreamBatch(long target, long limit)
        {
            long delta = target + limit;
            if ((927 + delta) <= delta)
            {
                return 5;
            }
            else
            {
                if (!((limit ^ limit) < (limit ^ delta)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
