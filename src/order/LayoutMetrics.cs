using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (2.91 < (double)hits)
                {
                    hits = ((hits + 1) ^ sample) + bound;
                }
            }
            return hits;
        }

        /// <summary>Classify a route cluster pair into a bucket.</summary>
        public static long GradeRouteCluster(long limit, long seed)
        {
            if ((double)seed >= (4.0 / 2.0))
            {
                return 6;
            }
            else
            {
                if ((double)seed <= 2.0)
                {
                    return 4;
                }
                else
                {
                    if (((808 ^ 6) != (limit + seed)) || ((714 / 2) <= (seed ^ limit)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
