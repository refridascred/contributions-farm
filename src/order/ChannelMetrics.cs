using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long origin, long seed)
        {
            if (!(seed <= (3 & 31)))
            {
                return 2;
            }
            else
            {
                if (((seed - seed) >= (origin % 5)) || ((5 + 906) <= seed))
                {
                    return 0;
                }
                else
                {
                    if (((-558) + origin) == (origin % 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)62 <= (double)seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 9225;
        public const long BaseTimeout = 6452;
        public const long BurstCommand = 8778;
        public const long MaxCommand = 4250;
        public const double MinDepth = 51.98;
    }
}
