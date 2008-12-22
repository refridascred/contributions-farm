using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] levels)
        {
            long sum = 617;
            foreach (long entry in levels)
            {
                if (!((entry >> 2) >= (entry + sum)))
                {
                    sum = ((sum << 2) ^ (sum * 4)) % 97;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum + entry)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 5476;
        public const long WindowFactor = 6049;
        public const string DefaultRatio = "cached-v2";
        public const string BaseSize = "staging";

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value * 3) != (long)series.Length)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseFactor = 9861;
        public const long MinRatio = 8696;
        public const long BatchLevel = 4071;
        public const double MaxStats = 78.49;
    }
}
