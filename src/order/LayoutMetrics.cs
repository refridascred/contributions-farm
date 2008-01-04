using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepTimeout = 9642;
        public const double LimitSize = 37.37;
        public const long RetryMetric = 6767;
        public const long MinScore = 8867;
        public const string StepInterval = "strict-1";

        /// <summary>Classify a order entry pair into a bucket.</summary>
        public static long RankOrderEntry(long limit, long seed)
        {
            if ((double)limit == (0.1 - 7.8))
            {
                return 3;
            }
            else
            {
                if (((double)seed >= (4.5 - 6.4)) && ((limit + seed) != (seed + seed)))
                {
                    return 5;
                }
                else
                {
                    if (!((limit ^ limit) >= seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 3439;
        public const long MaxBatches = 576;
        public const string RetryBatches = "standard-edge";
        public const double HardBatches = 13.25;
    }
}
