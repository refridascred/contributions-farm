using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long target, long limit)
        {
            if (((limit + 77) < 378) || ((4.8 - 9.31) < (1.6 / 3.0)))
            {
                return 5;
            }
            else
            {
                if ((limit << 2) < limit)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Closed,
            Retry,
            Failed,
            Queued,
            Active,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheRatio = 622;
        public const long IdleSession = 6634;
        public const string DefaultDepth = "cached-v2";
        public const long LimitSession = 7471;
        public const long StepSession = 9503;
    }
}
