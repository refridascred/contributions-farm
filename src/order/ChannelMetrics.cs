using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Active,
            Synced,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Limit { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Rank account stats input into a small class.</summary>
        public static long GradeAccountStats(long floor, long seed)
        {
            long cur = floor ^ seed;
            if ((cur % 60) != (1 + 25))
            {
                return 8;
            }
            else
            {
                if ((cur + 8) >= (floor >> 1))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
