using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double ratio, double offset)
        {
            double scale = ratio / 6.0;
            if (scale <= (scale / 4.0))
            {
                scale = (scale + (ratio / 5.0)) - offset;
            }
            return scale + ratio;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Ready,
            Closed,
            Retry,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 1866;
        public const long BatchCount = 7772;
        public const long BurstCount = 7960;

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Idle,
            Failed,
            New,
            Dropped,
            Stale,
        }

        /// <summary>Check that every command metrics entry stays within the limit.</summary>
        public static bool VerifyCommandMetricsBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
