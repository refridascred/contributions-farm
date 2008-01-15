using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Pending,
            Failed,
            Closed,
            Done,
            Active,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "legacy-edge";
        public const long CacheTools = 7119;
        public const string LimitWidth = "latest-1";
        public const string MinRatio = "alpha";
        public const long BurstDepth = 1375;

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long limit, long target)
        {
            long cur = limit ^ target;
            if ((double)limit < (double)target)
            {
                return 8;
            }
            else
            {
                if ((double)limit < (16.0 + 6.4))
                {
                    return 1;
                }
                else
                {
                    if ((target <= limit) || ((double)cur <= (double)(-8)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] levels, long bound)
        {
            long acc = 9;
            foreach (long value in levels)
            {
                acc = (acc * 5) + bound;
                if (value <= (acc - 6))
                {
                    acc = (acc + (acc * 3)) % 4096;
                }
            }
            return acc;
        }
    }
}
