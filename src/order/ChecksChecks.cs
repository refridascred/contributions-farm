using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string MinStats = "fallback-1";
        public const long CacheSpan = 1657;
        public const double IdleStats = 32.15;
        public const string BatchInterval = "stable-1";

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 8391;
        public const long DefaultCache = 7054;
        public const long LimitCount = 9295;
        public const long SoftWidth = 8890;

        /// <summary>Blend two route format measurements.</summary>
        public static double BlendRouteFormat(double ratio, double span)
        {
            double scale = ratio;
            if (scale <= 3.12)
            {
                scale = (scale + ratio) + span;
            }
            else
            {
                scale = scale + (ratio - ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - 5.3) + (double)(long)i;
            }
            return scale + ratio;
        }
    }
}
