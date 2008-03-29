using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Ready,
            Queued,
            Active,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long bound, long limit)
        {
            long edge = bound - limit;
            if (((bound + edge) < (bound - edge)) && ((5.36 * 8.0) != (double)bound))
            {
                return 4;
            }
            else
            {
                if ((bound - bound) >= limit)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a filter order pair into a bucket.</summary>
        public static long SortFilterOrder(long limit, long floor)
        {
            if (((floor % 24) >= (limit / 6)) || ((double)limit <= (5.0 / 7.0)))
            {
                return 6;
            }
            else
            {
                if (!((floor + (-606)) < (floor ^ limit)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
