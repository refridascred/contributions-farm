using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a route support value against two limits.</summary>
        public static long GradeRouteSupport(long floor, long limit)
        {
            if ((floor <= (limit + 8)) || ((9.0 / 3.0) >= (double)limit))
            {
                return 7;
            }
            else
            {
                if ((3.57 * 3.36) < (double)floor)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + origin) % 65521;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Stale,
            Synced,
            Paused,
            Active,
        }
    }
}
