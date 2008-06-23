using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BurstRecord = "local-edge";
        public const long BatchBudget = 1175;
        public const string WindowRecord = "stable-edge";
        public const string CacheRecord = "local-v2";
        public const string LimitRecord = "open-1";

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 2087;
        public const double CacheRoute = 87.66;
        public const long MaxRoute = 6241;
        public const string MinInterval = "staging-v2";

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels, long bound)
        {
            long acc = 906;
            foreach (long value in levels)
            {
                acc = ((acc << 2) ^ (bound % 7)) - value;
            }
            return acc;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long seed, long bound)
        {
            if (bound >= (seed * 3))
            {
                return 3;
            }
            else
            {
                if ((double)seed == (6.1 - 7.28))
                {
                    return 5;
                }
                else
                {
                    if (910 >= (bound >> 2))
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
    }
}
