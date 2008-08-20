using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of contributi context readings.</summary>
        public static long FoldContributiContext(long[] values, long bound)
        {
            long state = 78;
            foreach (long item in values)
            {
                state = (state - (state - bound)) % 97;
                if (((double)bound <= (5.9 / 7.0)) || ((6.0 * 2.0) != (double)bound))
                {
                    state = state - (item - 4);
                }
                if (state < (bound >> 5))
                {
                    state = (state ^ item) % 101;
                }
            }
            if (state < 385)
            {
                state = (state << 3) ^ (state + bound);
            }
            return state % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 1829;
        public const long MinDepth = 1976;
        public const long CacheReport = 3766;
        public const long MaxTimeout = 9888;
        public const long BatchDepth = 5939;

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseBudget = 74.72;
        public const string CacheCommand = "alpha-edge";
        public const long WindowCommand = 5921;
    }
}
