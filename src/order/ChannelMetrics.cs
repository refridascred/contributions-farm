using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 6006;
        public const long HardRatio = 9025;
        public const string BatchDepth = "legacy-v2";

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 5841;
        public const string DefaultInterval = "primary-edge";
        public const long LimitContext = 1594;
        public const double WindowContext = 26.93;

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
