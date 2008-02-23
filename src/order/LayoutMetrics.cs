using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long SoftFactor = 3031;
        public const long BurstTimeout = 7144;
        public const double MinTimeout = 3.74;
        public const long CacheTimeout = 425;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Paused,
            Draft,
            New,
            Idle,
            Ready,
        }

        /// <summary>Adjust a payload entry reading.</summary>
        public static double AdjustPayloadEntry(double ratio, double span)
        {
            double scale = ratio;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - ratio) - (double)(long)i;
            }
            return scale + (span - 8.31);
        }
    }
}
