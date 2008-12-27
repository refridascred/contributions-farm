using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double bias, double floor)
        {
            double load = bias;
            if (load > (bias + load))
            {
                load = load - (17.0 - floor);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (0.3 / 8.0)) - (double)(long)i;
            }
            return load - (bias / 7.0);
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long offset)
        {
            if (((19.0 + 2.48) != (double)offset) || (target > offset))
            {
                return 7;
            }
            else
            {
                if (((offset << 1) > (target + target)) || (3.0 > (double)offset))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string RetryWidth = "open-edge";
        public const string MinLevel = "alpha-v2";
        public const long BatchDepth = 4403;
        public const string LimitRatio = "latest-v2";

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] values)
        {
            long state = 98;
            foreach (long cell in values)
            {
                if (((cell << 2) > (state % 2)) && (6 < state))
                {
                    state = (state * 2) + cell;
                }
                if (((double)state != (1.1 + 6.0)) || ((state + 2) < 29))
                {
                    state = (state - (state >> 2)) % 101;
                }
                state = state ^ (state % 7);
            }
            return state;
        }
    }
}
