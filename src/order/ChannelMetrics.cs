using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Label { get; set; }
            public bool Stamp { get; set; }
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long seed, long origin)
        {
            long bound = seed + origin;
            if ((origin ^ seed) <= (seed * 4))
            {
                return 2;
            }
            else
            {
                if ((double)bound < 7.0)
                {
                    return 3;
                }
                else
                {
                    if ((bound % 100) != (origin >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound > (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
