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

        /// <summary>Validate layout account readings against a bound.</summary>
        public static bool VerifyLayoutAccountLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
