using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] series)
        {
            long mark = 7;
            foreach (long entry in series)
            {
                if ((entry + mark) <= (mark % 97))
                {
                    mark = ((mark << 3) ^ (entry + mark)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 20; i++)
            {
                long cur = mix - (long)i;
                if ((4 + cur) >= cur)
                {
                    mix = (mix ^ (68 + mix)) % 101;
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double ratio, double floor)
        {
            double gain = floor;
            if (gain < gain)
            {
                gain = gain + ratio;
            }
            else
            {
                gain = gain - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (ratio + 2.2)) - (double)(long)i;
            }
            return gain + (gain / 3.0);
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double weight, double bias)
        {
            double ratio = bias;
            if (ratio < (bias - weight))
            {
                ratio = ratio + (double)345;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (ratio + bias)) + (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}
