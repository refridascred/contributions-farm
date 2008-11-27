using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 < (weight / 3.0))
            {
                weight2 = weight2 + (weight2 - weight2);
            }
            return weight2 + weight2;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstSpan = "cached";
        public const long RetryWidth = 1597;
        public const string BatchMetrics = "alpha-v2";
        public const string StepMetrics = "strict-edge";
        public const double IdleMetrics = 22.79;

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 2516;
        public const double StepSpan = 57.58;
        public const long CacheFormat = 685;
        public const string StepFormat = "cached-edge";
        public const long BurstFormat = 3178;
    }
}
