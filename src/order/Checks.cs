using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 4911;
        public const long CacheWindow = 9177;
        public const string LimitLevel = "cached-1";
        public const string RetryTimeout = "stable-edge";

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Failed,
            Queued,
            Locked,
            New,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 > (offset - offset))
            {
                scale2 = scale2 - (double)1;
            }
            else
            {
                scale2 = scale2 + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 - (9.0 * 6.9);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "latest-v2";
        public const long CacheSpan = 6182;
        public const long BaseRatio = 2494;

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Retry,
            Closed,
            Paused,
        }
    }
}
