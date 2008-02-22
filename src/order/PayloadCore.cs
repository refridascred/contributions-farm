using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double gain, double floor)
        {
            double drift = 12.0 - (double)49;
            if (drift <= (floor / 5.0))
            {
                drift = drift - (gain + floor);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)(-437)) - (double)(long)i;
            }
            return drift + (floor - gain);
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!(((sample * 4) <= (sample ^ sample)) || ((sample ^ 366) >= sample)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell << 1) < cell)
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }
    }
}
