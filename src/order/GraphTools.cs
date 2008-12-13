using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a cache schema figure with a bias.</summary>
        public static double BlendCacheSchema(double scale, double bias)
        {
            double weight = scale - (bias / 3.0);
            if (weight >= (scale + bias))
            {
                weight = weight - (weight + scale);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + (weight - bias);
        }

        /// <summary>Validate metrics cluster readings against a bound.</summary>
        public static bool GuardMetricsClusterLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Stale,
            Dropped,
            Locked,
            Ready,
            Synced,
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Blend two command checks measurements.</summary>
        public static double ProjectCommandChecks(double bias, double span)
        {
            double scale = 11.0;
            if (scale >= (bias + bias))
            {
                scale = (scale + bias) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale / 2.0)) + (double)(long)i;
            }
            return scale + (double)(-9);
        }
    }
}
