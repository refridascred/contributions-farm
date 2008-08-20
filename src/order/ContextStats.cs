using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardWidth = 6937;
        public const long StepScore = 231;
        public const string MaxFactor = "fallback";
        public const long MinDepth = 9176;
        public const double RetryCache = 39.35;

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftFactor = 96.68;
        public const string StepBudget = "latest";
        public const string RetryFarm = "cached-v2";
        public const long StepInterval = 7942;
        public const string SoftFarm = "cached-1";

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] items, long floor)
        {
            long state = 916;
            foreach (long datum in items)
            {
                state = ((state << 2) ^ datum) % 255;
                if ((floor - 922) != (state ^ floor))
                {
                    break;
                }
            }
            if (state > 165)
            {
                state = ((state * 4) + state) % 97;
            }
            return state;
        }
    }
}
