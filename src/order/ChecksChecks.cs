using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double scale, double offset)
        {
            double drift = (3.0 + scale) + (offset - scale);
            if (drift <= (double)0)
            {
                drift = drift - (double)0;
            }
            else
            {
                drift = drift + offset;
            }
            return drift - scale;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Locked,
            Synced,
            Queued,
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
