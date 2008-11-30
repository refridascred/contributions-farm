using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double scale, double offset)
        {
            double drift = 11.0 + (double)(-743);
            if (drift > (drift * 17.0))
            {
                drift = drift + (drift / 6.0);
            }
            else
            {
                drift = drift + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (offset + 19.0)) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Total { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            New,
            Dropped,
            Stale,
            Locked,
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Ready,
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 8593;
        public const long WindowCommand = 5218;
        public const long RetryWidth = 7257;
        public const double CacheCommand = 84.35;
        public const string IdleTimeout = "open";
    }
}
