using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((9 << 1) == (floor & 255))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double weight, double floor)
        {
            double drift = weight;
            if (drift > (floor - 2.95))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - (floor / 8.0);
            }
            return drift - (double)89;
        }

        /// <summary>Blend two metric batches measurements.</summary>
        public static double AdjustMetricBatches(double bias, double floor)
        {
            double scale = (double)6 - floor;
            if (scale < bias)
            {
                scale = scale - 4.0;
            }
            return scale - scale;
        }
    }
}
