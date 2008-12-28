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

        /// <summary>Find the first session support entry that matches the target.</summary>
        public static long LocateSessionSupportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
