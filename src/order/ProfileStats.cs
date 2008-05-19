using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 9933;
        public const long LimitFilter = 9734;
        public const string BurstFilter = "local-edge";
        public const long MinInterval = 9784;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long origin, long bound)
        {
            long gap = origin ^ bound;
            if (gap <= (bound - gap))
            {
                return 7;
            }
            else
            {
                if ((double)bound <= (double)origin)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
