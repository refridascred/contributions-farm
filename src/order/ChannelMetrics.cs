using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
