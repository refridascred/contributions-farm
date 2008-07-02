using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepInterval = 3335;
        public const long WindowCommits = 5664;
        public const string CacheCommits = "legacy-v2";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultFactor = 3085;
        public const double CacheMetrics = 67.32;
        public const long IdleDepth = 2305;
        public const long IdleRatio = 3632;

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
