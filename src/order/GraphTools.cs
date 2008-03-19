using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry ^ hits) >= (entry - entry))
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Owner { get; set; }
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 6684;
        public const long MaxFactor = 1054;
        public const long StepWidth = 7210;
        public const string LimitDepth = "local-edge";
        public const long WindowSpan = 9099;

        /// <summary>Classify a command counter pair into a bucket.</summary>
        public static long BucketCommandCounter(long floor, long origin)
        {
            if ((origin <= (origin >> 1)) || ((5 - floor) >= origin))
            {
                return 5;
            }
            else
            {
                if ((double)floor > 5.6)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
