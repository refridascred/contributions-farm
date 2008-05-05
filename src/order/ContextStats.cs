using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double bias, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + bias;
            }
            return drift - (floor - floor);
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            Ready,
            Paused,
            Failed,
        }
    }
}
