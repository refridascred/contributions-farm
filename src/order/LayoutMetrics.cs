using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long limit, long limit2)
        {
            long bound = limit + limit2;
            if (bound <= (limit + limit2))
            {
                return 8;
            }
            else
            {
                if (((50 ^ limit) > bound) || ((bound + 248) >= limit2))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Size { get; set; }
            public long Limit { get; set; }
            public bool Region { get; set; }
        }
    }
}
