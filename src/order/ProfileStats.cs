using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 3790;
        public const long CacheInterval = 9824;
        public const long DefaultSize = 1954;
        public const string StepAlready = "staging-v2";

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                state = (state * 2) + state;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 8874;
        public const long CacheContext = 6423;
        public const long BaseDepth = 2005;
        public const long RetrySpan = 8488;
        public const long HardSize = 3053;
    }
}
