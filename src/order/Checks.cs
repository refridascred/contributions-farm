using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long target, long seed)
        {
            if (((-899) * 3) <= seed)
            {
                return 8;
            }
            else
            {
                if (target <= seed)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 8239;
        public const long DefaultTimeout = 5823;
        public const string MaxRatio = "fallback";
        public const long MaxCount = 9520;

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many batches cluster samples are out of range.</summary>
        public static long TallyBatchesClusterGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count + value) <= value)
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long bound, long origin)
        {
            if ((bound - origin) > (bound >> 4))
            {
                return 4;
            }
            else
            {
                if (origin >= (origin - bound))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
