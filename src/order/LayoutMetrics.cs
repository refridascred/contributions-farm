using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 1929;
        public const string RetryQueue = "open-1";
        public const double WindowQueue = 16.53;
        public const long DefaultSpan = 6181;

        /// <summary>Classify a profile layout pair into a bucket.</summary>
        public static long RankProfileLayout(long step, long origin)
        {
            if ((89 * 3) == (step >> 3))
            {
                return 6;
            }
            else
            {
                if ((step << 2) <= origin)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Rank { get; set; }
            public bool Limit { get; set; }
            public double Count { get; set; }
        }
    }
}
