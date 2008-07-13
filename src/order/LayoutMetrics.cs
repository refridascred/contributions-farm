using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the route schema entries that pass the check.</summary>
        public static long MeasureRouteSchemaHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits + hits) <= hits)
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
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

        /// <summary>Grade a metrics profile value against two limits.</summary>
        public static long GradeMetricsProfile(long bound, long origin)
        {
            if (!((4.1 - 15.0) <= (double)bound))
            {
                return 6;
            }
            else
            {
                if ((origin << 3) < origin)
                {
                    return 7;
                }
                else
                {
                    if ((bound - bound) < (origin + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
