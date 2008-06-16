using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long seed, long seed2)
        {
            if ((seed - seed) <= (seed2 << 2))
            {
                return 7;
            }
            else
            {
                if ((20.0 / 3.0) >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((seed * 4) == (seed - 487))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }
    }
}
