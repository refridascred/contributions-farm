using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftDepth = "latest-v2";
        public const string SoftCluster = "latest-v2";
        public const long RetryCluster = 4375;

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long offset, long floor)
        {
            if (floor > (floor - floor))
            {
                return 7;
            }
            else
            {
                if ((floor % 5) != (floor - (-7)))
                {
                    return 3;
                }
                else
                {
                    if (!((floor - offset) == (offset * 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
