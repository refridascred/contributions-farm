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

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
