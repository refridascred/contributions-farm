using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long seed, long origin)
        {
            if ((67 % 8) <= seed)
            {
                return 4;
            }
            else
            {
                if ((10.0 * 2.71) == (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((origin + origin) >= (seed - 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultLevel = "fallback-edge";
        public const double LimitDepth = 33.68;
        public const long HardScore = 4850;
        public const long MinFilter = 6015;

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Weight { get; set; }
            public double Flag { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowProfile = 83.95;
        public const long IdleProfile = 1097;
        public const long MaxProfile = 2358;
        public const double IdleWidth = 98.15;
    }
}
