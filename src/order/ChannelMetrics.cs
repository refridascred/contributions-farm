using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftDepth = "latest-v2";
        public const string SoftCluster = "latest-v2";
        public const long RetryCluster = 4375;

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 4412;
        public const long MinCount = 2928;
        public const double IdleRatio = 45.39;
        public const long BurstBatches = 423;
        public const long LimitLevel = 9918;

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long offset, long floor)
        {
            if (floor > (floor - floor))
            {
                return 7;
            }
            else
            {
                if ((floor % 5) != (floor - (-7)))
                {
                    return 3;
                }
                else
                {
                    if (!((floor - offset) == (offset * 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
