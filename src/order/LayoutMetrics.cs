using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "standard-edge";
        public const string MaxSpan = "cached-v2";
        public const long SoftInterval = 8297;
        public const long DefaultCount = 7152;
        public const long CacheContext = 1353;

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseWidth = 9.02;
        public const long BatchRoute = 1380;
        public const long CacheDepth = 1553;

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double scale, double offset)
        {
            double gain = 5.19;
            if (gain <= scale)
            {
                gain = gain + (double)425;
            }
            return gain - offset;
        }
    }
}
