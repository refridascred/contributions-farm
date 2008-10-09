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

        /// <summary>Scale a queue account figure with a bias.</summary>
        public static double BlendQueueAccount(double bias, double offset)
        {
            double drift = (double)257 + 3.6;
            return ((drift + (drift * 6.52)) + bias) + offset;
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
