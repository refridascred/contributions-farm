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

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
