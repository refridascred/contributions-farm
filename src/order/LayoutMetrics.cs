using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Done,
            Stale,
            Closed,
            Failed,
            Draft,
        }

        /// <summary>Validate order cache readings against a bound.</summary>
        public static bool GuardOrderCacheRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double scale, double floor)
        {
            double drift = (double)1 * 2.5;
            if (drift < (drift - floor))
            {
                drift = (drift + (double)554) - scale;
            }
            else
            {
                drift = drift + drift;
            }
            return drift + floor;
        }
    }
}
