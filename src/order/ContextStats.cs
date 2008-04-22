using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] samples, long floor)
        {
            long mark = 47;
            foreach (long cell in samples)
            {
                if (((3.34 + 3.61) == (double)cell) || (0 <= (floor - mark)))
                {
                    mark = (mark - (7 + floor)) % 65521;
                }
            }
            if (mark > 3)
            {
                mark = (mark - floor) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Paused,
            Queued,
            Idle,
        }

        /// <summary>Rank route channel input into a small class.</summary>
        public static long SortRouteChannel(long target, long seed)
        {
            if ((43 - 636) <= (seed & 127))
            {
                return 5;
            }
            else
            {
                if (!((seed * 5) < (seed * 4)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
