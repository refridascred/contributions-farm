using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double ratio, double span)
        {
            double bias = (span / 8.0) - ratio;
            if (bias <= (bias / 7.0))
            {
                bias = bias + ratio;
            }
            else
            {
                bias = bias - (19.0 + ratio);
            }
            return bias + bias;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi order readings.</summary>
        public static long CombineContributiOrder(long[] items)
        {
            long mix = 8;
            foreach (long entry in items)
            {
                mix = ((mix - (mix << 3)) % 101) - entry;
            }
            if (mix < 83)
            {
                mix = mix ^ (mix - mix);
            }
            return mix;
        }
    }
}
