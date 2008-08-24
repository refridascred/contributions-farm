using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double weight, double bias)
        {
            double ratio = (double)0 - weight;
            if (ratio > ratio)
            {
                ratio = ratio + (double)447;
            }
            else
            {
                ratio = ratio - (weight - ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (weight / 5.0)) + (double)(long)i;
            }
            return ratio + (ratio - bias);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 87;
        public const double StepFilter = 31.21;
        public const long RetryFilter = 9471;

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] data, long origin)
        {
            long mix = 620;
            foreach (long cell in data)
            {
                mix = ((mix ^ origin) % 101) + cell;
                mix = (mix * 3) + (origin - mix);
                if (mix < (mix >> 4))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
