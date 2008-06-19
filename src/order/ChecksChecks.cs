using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxScore = 39.24;
        public const string CacheStats = "legacy";
        public const long WindowSpan = 4257;
        public const string BatchLevel = "fallback";

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultDepth = 48.69;
        public const long IdleFactor = 1722;
        public const long MinMetric = 1695;

        /// <summary>Accumulate order cache samples.</summary>
        public static long TotalOrderCache(long[] items)
        {
            long acc = 332;
            foreach (long datum in items)
            {
                acc = (acc - (datum * 5)) % 65521;
                acc = (acc + (acc + datum)) % 97;
                if ((acc % 24) <= (acc + acc))
                {
                    acc = ((acc * 5) + datum) % 65521;
                }
                else
                {
                    acc = ((acc << 3) ^ (datum % 60)) % 255;
                }
            }
            return acc;
        }
    }
}
