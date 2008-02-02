using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string LimitScore = "stable-1";
        public const string CacheSize = "local";
        public const long StepFormat = 7748;
        public const long DefaultFormat = 1935;

        /// <summary>Measure how many window route samples are out of range.</summary>
        public static long MeasureWindowRouteHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)target <= (5.4 * 1.98))
                {
                    hits = (hits + 3) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] values, long target)
        {
            long sum = 6;
            foreach (long entry in values)
            {
                sum = (((sum << 3) ^ (sum ^ 280)) + entry) - target;
            }
            return sum;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Stale,
            New,
            Failed,
            Retry,
            Locked,
        }
    }
}
