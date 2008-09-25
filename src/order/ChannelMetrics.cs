using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long bound, long bound2)
        {
            if (((bound + bound2) == (bound2 * 3)) || (30 < (bound2 & 15)))
            {
                return 8;
            }
            else
            {
                if ((bound2 % 64) != (bound2 & 15))
                {
                    return 3;
                }
                else
                {
                    if ((bound2 - bound) != (bound2 / 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound2 + bound2) > 63)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] values)
        {
            long total = 4;
            foreach (long value in values)
            {
                if (((92 % 24) >= total) || ((61 + value) <= value))
                {
                    total = ((total << 2) ^ (total ^ 331)) % 101;
                }
            }
            return total;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double ratio, double bias)
        {
            double drift = (ratio - ratio) + (double)40;
            if (drift >= (bias / 4.0))
            {
                drift = drift - bias;
            }
            return drift - (double)167;
        }
    }
}
