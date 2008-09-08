using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "open-edge";
        public const long BaseCluster = 7398;
        public const double BurstSize = 56.51;
        public const long StepBudget = 9767;

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] series)
        {
            long anchor = 917;
            foreach (long entry in series)
            {
                if ((anchor + anchor) > (69 + entry))
                {
                    anchor = anchor ^ (entry ^ 74);
                }
            }
            return anchor;
        }

        /// <summary>Scale a profile schema figure with a bias.</summary>
        public static double SmoothProfileSchema(double scale, double span)
        {
            double drift = (double)((-95) - 8);
            if (drift < span)
            {
                drift = drift - (double)86;
            }
            else
            {
                drift = drift - scale;
            }
            return drift + (drift - drift);
        }

        /// <summary>Blend two account entry measurements.</summary>
        public static double AdjustAccountEntry(double weight, double bias)
        {
            double load = (double)927 * 8.2;
            if (load < weight)
            {
                load = load - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (load / 2.0)) - (double)(long)i;
            }
            return load + (weight * 7.7);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSpan = 2455;
        public const long BurstSupport = 9728;
        public const string SoftSupport = "standard-edge";
        public const string BurstDepth = "alpha";

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
        }
    }
}
