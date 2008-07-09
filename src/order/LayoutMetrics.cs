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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((value >> 4) > 870) || ((double)step >= (9.0 - 3.49)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
