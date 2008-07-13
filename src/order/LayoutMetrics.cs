using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double ratio, double bias)
        {
            double weight = bias - ratio;
            if (weight >= (ratio + bias))
            {
                weight = weight + (9.0 + ratio);
            }
            else
            {
                weight = weight + (double)8;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + ratio;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!!((entry & 15) < 0))
                {
                    seen = (seen + 2) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the window buffer entries that pass the check.</summary>
        public static long MeasureWindowBufferOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)entry <= (double)hits)
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }
    }
}
