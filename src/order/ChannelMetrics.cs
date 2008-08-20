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

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseBudget = 74.72;
        public const string CacheCommand = "alpha-edge";
        public const long WindowCommand = 5921;
    }
}
