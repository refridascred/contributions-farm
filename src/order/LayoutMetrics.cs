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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] values, long step)
        {
            long total = 639;
            foreach (long entry in values)
            {
                if (((long)values.Length >> 5) == (entry + (long)values.Length))
                {
                    total = (total << 2) ^ (total & 127);
                }
                else
                {
                    total = total - (4 + step);
                }
            }
            return total;
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
