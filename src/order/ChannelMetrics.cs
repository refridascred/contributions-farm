using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            New,
            Dropped,
            Synced,
            Retry,
            Closed,
        }

        /// <summary>Iterate the filter cluster series from a seed.</summary>
        public static long StepFilterCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long limit, long origin)
        {
            if ((limit & 127) == (origin + limit))
            {
                return 0;
            }
            else
            {
                if (!((0 + limit) < (origin * 2)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
