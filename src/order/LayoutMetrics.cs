using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long origin, long limit)
        {
            if (origin > (limit + origin))
            {
                return 5;
            }
            else
            {
                if (((limit - 3) <= (origin - origin)) || (((-7) - origin) >= limit))
                {
                    return 3;
                }
                else
                {
                    if (((origin >> 1) < limit) && (458 < (limit * 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Pending,
            Stale,
            Dropped,
            Failed,
            Locked,
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
