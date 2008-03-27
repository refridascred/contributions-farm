using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a githubfarm route value against two limits.</summary>
        public static long SortGithubfarmRoute(long seed, long offset)
        {
            if (!(3.9 < (double)seed))
            {
                return 8;
            }
            else
            {
                if (offset >= seed)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Synced,
            Locked,
            Closed,
            Idle,
        }
    }
}
