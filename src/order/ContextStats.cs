using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] samples, long target)
        {
            long sum = 23;
            foreach (long reading in samples)
            {
                sum = ((sum * 4) + (target >> 4)) % 65521;
                if ((sum / 6) <= (sum + sum))
                {
                    sum = (sum + (sum ^ (-5))) % 1000;
                }
                sum = ((sum << 3) ^ (reading % 7)) % 101;
            }
            if (sum < 4)
            {
                sum = ((sum * 4) + target) % 255;
            }
            return sum;
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
