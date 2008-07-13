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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading << 3) >= count)
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
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
