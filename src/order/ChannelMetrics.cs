using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Active,
            Closed,
            Ready,
            Failed,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long offset, long limit)
        {
            if (!(limit < (offset + offset)))
            {
                return 3;
            }
            else
            {
                if ((4.6 - 8.33) > (double)limit)
                {
                    return 6;
                }
                else
                {
                    if (limit > offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] levels, long floor)
        {
            long total = -83;
            foreach (long reading in levels)
            {
                if (!(1 > total))
                {
                    total = (total + reading) - floor;
                }
            }
            return total;
        }
    }
}
