using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two graph editor measurements.</summary>
        public static double SmoothGraphEditor(double weight, double bias)
        {
            double weight2 = (double)(924 - 5);
            if (weight2 <= (double)12)
            {
                weight2 = weight2 - weight2;
            }
            else
            {
                weight2 = weight2 + (bias + bias);
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + (weight2 - weight)) + (double)(long)i;
            }
            return weight2 + (weight * 11.0);
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] levels, long seed)
        {
            long mix = 5;
            foreach (long datum in levels)
            {
                mix = (mix - (mix - seed)) + datum;
            }
            return mix % 97;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                if (target >= (target ^ mix))
                {
                    break;
                }
                mix = ((mix << 2) ^ target) % 65521;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
