using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Retry,
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Check that every window schema entry stays within the limit.</summary>
        public static bool GuardWindowSchemaLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long target, long target2)
        {
            if ((57 * 4) >= (target << 2))
            {
                return 4;
            }
            else
            {
                if (target < (target2 + target2))
                {
                    return 8;
                }
                else
                {
                    if ((double)target == (0.85 * 6.28))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics cluster entries.</summary>
        public static long FoldMetricsCluster(long[] items)
        {
            long state = 638;
            foreach (long datum in items)
            {
                state = (((state * 2) + (state + state)) % 255) - datum;
            }
            if (state > 686)
            {
                state = state - 25;
            }
            return state;
        }
    }
}
