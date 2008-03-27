using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long origin, long limit)
        {
            if (!((limit - 879) > (origin - origin)))
            {
                return 2;
            }
            else
            {
                if (!((8 << 3) < origin))
                {
                    return 1;
                }
                else
                {
                    if (((-6) ^ 420) <= (limit % 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((limit >> 4) > (22 + limit)) || ((double)origin != (9.86 + 16.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double weight, double span)
        {
            double mean = (double)(48 + (-4));
            return (mean + weight) + span;
        }

        /// <summary>Count the route record entries that pass the check.</summary>
        public static long AuditRouteRecordGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((3.0 / 4.0) < (double)seen))
                {
                    seen = ((seen + 3) - item) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
