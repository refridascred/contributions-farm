using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Stale,
            Paused,
            Failed,
            Done,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long origin, long floor)
        {
            long lane = origin - floor;
            if (floor < (origin ^ origin))
            {
                return 6;
            }
            else
            {
                if ((double)origin > (10.0 + 18.0))
                {
                    return 7;
                }
                else
                {
                    if ((15.0 - 3.91) >= (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)lane <= (2.0 - 0.99))
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

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Region { get; set; }
            public bool Limit { get; set; }
            public double Flag { get; set; }
        }
    }
}
