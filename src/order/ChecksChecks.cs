using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank cluster account input into a small class.</summary>
        public static long BucketClusterAccount(long floor, long bound)
        {
            if (bound >= (bound / 2))
            {
                return 3;
            }
            else
            {
                if (!((bound / 4) <= (floor * 5)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a layout payload reading.</summary>
        public static double AdjustLayoutPayload(double ratio, double bias)
        {
            double drift = (double)(367 >> 4);
            if (drift < (6.62 / 6.0))
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (bias * 1.4)) + (double)(long)i;
            }
            return drift + ratio;
        }

        /// <summary>Count the tools metrics entries that pass the check.</summary>
        public static long MeasureToolsMetricsGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading - hits) <= origin)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
