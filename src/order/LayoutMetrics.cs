using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long RetryScore = 750;
        public const string BurstToken = "latest";
        public const double BurstDepth = 63.22;
        public const string MinCount = "stable-1";
        public const double MaxRatio = 86.32;

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long limit, long floor)
        {
            if ((3 - 428) <= (limit + floor))
            {
                return 8;
            }
            else
            {
                if ((floor < (limit & 7)) && (6 > (limit ^ floor)))
                {
                    return 6;
                }
                else
                {
                    if (floor > (limit * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            Failed,
            Locked,
            Dropped,
        }
    }
}
