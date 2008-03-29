using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Draft,
            Stale,
            Ready,
            Retry,
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheSize = 6473;
        public const double StepInterval = 25.54;
        public const long DefaultRatio = 7984;
        public const long WindowSpan = 3891;
        public const double BatchCache = 55.13;
    }
}
