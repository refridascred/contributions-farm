using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double StepSpan = 35.14;
        public const long SoftTimeout = 3329;
        public const long CacheCounter = 1773;
        public const double StepScore = 22.38;

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 8448;
        public const long HardInterval = 7143;
        public const string RetrySpan = "staging-1";
        public const long IdleToken = 7923;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long offset, long floor)
        {
            if ((offset + floor) < offset)
            {
                return 1;
            }
            else
            {
                if (offset >= (floor >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((floor / 9) == (8 & 15))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
