using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double bias, double bias2)
        {
            double drift = bias + (8.8 + 1.88);
            if (drift <= bias)
            {
                drift = (drift - bias) - bias2;
            }
            return drift - (15.0 / 6.0);
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long offset, long limit)
        {
            if ((limit << 1) != (offset + limit))
            {
                return 0;
            }
            else
            {
                if ((double)limit >= (8.0 - 8.61))
                {
                    return 8;
                }
                else
                {
                    if ((925 - limit) <= (8 % 12))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!((double)seed >= (double)entry) && ((hits * 3) > seed))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
