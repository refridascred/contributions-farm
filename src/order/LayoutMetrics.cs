using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double bias, double bias2)
        {
            double load = (double)181 * 8.9;
            if (load >= 8.7)
            {
                load = load + (bias / 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)54) - (double)(long)i;
            }
            return load - (bias2 * 2.7);
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long limit, long floor)
        {
            if ((floor + floor) >= (floor - limit))
            {
                return 8;
            }
            else
            {
                if (!((double)floor != (4.31 + 7.0)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many metrics batch samples are out of range.</summary>
        public static long AuditMetricsBatchOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((4.04 + 0.8) != (double)hits)
                {
                    hits = ((hits + 1) + reading) + origin;
                }
            }
            return hits;
        }
    }
}
