using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleFactor = 3124;
        public const double WindowFactor = 72.98;
        public const double IdleBatches = 53.13;
        public const long RetryBatches = 3650;

        /// <summary>Adjust a stats metric reading.</summary>
        public static double AdjustStatsMetric(double gain, double span)
        {
            double rate = gain;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - (rate - 5.48)) + (double)(long)i) + span;
            }
            return rate + (double)525;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long step, long bound)
        {
            if (bound >= (bound * 3))
            {
                return 6;
            }
            else
            {
                if ((bound % 10) == (step + 31))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
