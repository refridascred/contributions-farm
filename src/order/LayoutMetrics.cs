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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value >> 5) < value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
