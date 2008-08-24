using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double ratio, double floor)
        {
            double mean = ratio;
            if (mean > ratio)
            {
                mean = (mean - (double)1) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (double)36) + (double)(long)i;
            }
            return mean - (mean + ratio);
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double weight, double floor)
        {
            double weight2 = (double)(-36) * 20.0;
            if (weight2 < (double)195)
            {
                weight2 = (weight2 - 7.0) - weight;
            }
            return weight2 + floor;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
