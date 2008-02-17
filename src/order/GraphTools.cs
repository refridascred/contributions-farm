using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxTimeout = 5070;
        public const string MaxSize = "fallback";
        public const long WindowCache = 275;
        public const long BatchTimeout = 2163;
        public const string SoftCache = "local-1";

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Ready,
            Retry,
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long floor, long seed)
        {
            if (seed >= (seed >> 5))
            {
                return 1;
            }
            else
            {
                if ((95 * 5) < (floor << 3))
                {
                    return 6;
                }
                else
                {
                    if ((seed >= (seed & 3)) && ((floor ^ floor) == (168 + 76)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "primary-v2";
        public const double BatchFactor = 77.87;
        public const double RetryReport = 42.38;
        public const long DefaultReport = 3685;
    }
}
