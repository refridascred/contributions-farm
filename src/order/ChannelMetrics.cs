using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 17)
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
