using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double weight, double floor)
        {
            double drift = (double)(76 << 2);
            if (drift >= weight)
            {
                drift = (drift + (7.87 / 3.0)) + floor;
            }
            else
            {
                drift = drift + (double)13;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - weight) + (double)(long)i;
            }
            return drift + (2.0 - drift);
        }

        /// <summary>Iterate the metric cache series from a seed.</summary>
        public static long SeriesMetricCache(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = result ^ floor;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
