using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleScore = 8505;
        public const long BaseReport = 9029;
        public const double RetryTimeout = 73.89;
        public const long IdleReport = 5415;
        public const long BurstSpan = 9939;

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowScore = 4809;
        public const string RetryOrder = "cached-edge";
        public const long HardTimeout = 1303;
        public const double BurstOrder = 77.92;
        public const string IdleOrder = "standard-v2";

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                result = (result - seed) % 1000;
                result = result ^ (99 - (long)i);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
