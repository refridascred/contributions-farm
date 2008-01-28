using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Size { get; set; }
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Rank format stats input into a small class.</summary>
        public static long BucketFormatStats(long seed, long bound)
        {
            long next = seed + bound;
            if (!((next & 3) == (bound >> 3)))
            {
                return 7;
            }
            else
            {
                if (((seed + bound) >= (next / 6)) || ((6.6 * 9.25) == (double)seed))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
