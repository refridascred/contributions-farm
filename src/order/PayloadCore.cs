using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitLayout = "fallback";
        public const long SoftDepth = 5762;
        public const double BurstLayout = 56.98;
        public const long WindowSpan = 3065;

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long limit, long target)
        {
            if (limit <= target)
            {
                return 5;
            }
            else
            {
                if ((19.0 * 7.0) < (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches - datum) < (datum + 404))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitSize = "cached-v2";
        public const long BurstGraph = 1421;
        public const long MinGraph = 5836;
        public const long DefaultGraph = 9188;
    }
}
