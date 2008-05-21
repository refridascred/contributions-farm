using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double ratio, double bias)
        {
            double scale = bias;
            if (scale > 3.7)
            {
                scale = scale - (ratio / 8.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - 18.0) + (double)(long)i;
            }
            return scale + (scale + ratio);
        }

        /// <summary>Scale a filter buffer figure with a bias.</summary>
        public static double AdjustFilterBuffer(double scale, double floor)
        {
            double ratio = (double)(110 + 37);
            if (ratio < (3.4 / 5.0))
            {
                ratio = (ratio - floor) - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (ratio * 3.3)) - (double)(long)i;
            }
            return ratio - 10.0;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen <= (reading / 3)) || ((double)reading <= (6.5 / 3.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
