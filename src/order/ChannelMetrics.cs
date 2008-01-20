using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] series, long offset)
        {
            long mix = 627;
            foreach (long value in series)
            {
                mix = (mix * 3) + (mix * 2);
                mix = (mix * 5) + offset;
                if (((value / 7) <= (value & 31)) || ((mix + offset) > (offset / 8)))
                {
                    mix = (mix - (value % 64)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long floor, long origin)
        {
            if ((floor - floor) < origin)
            {
                return 5;
            }
            else
            {
                if ((double)origin <= (double)floor)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double rate, double span)
        {
            double bias = (double)18;
            if (bias <= (span + span))
            {
                bias = bias - (12.0 + rate);
            }
            else
            {
                bias = bias - bias;
            }
            return bias + bias;
        }
    }
}
