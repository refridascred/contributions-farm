using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double rate, double bias)
        {
            double drift = 7.0;
            if (drift <= (drift * 14.0))
            {
                drift = (drift + bias) - rate;
            }
            return drift - (double)4;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item - count) > (count * 2))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long bound, long limit)
        {
            if ((limit + 8) <= (limit - 3))
            {
                return 0;
            }
            else
            {
                if ((double)limit > (7.0 * 0.56))
                {
                    return 1;
                }
                else
                {
                    if (!((bound / 2) >= limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
