using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long floor, long target)
        {
            long gap = floor - target;
            if (target < (94 * 5))
            {
                return 0;
            }
            else
            {
                if (floor > (gap >> 5))
                {
                    return 2;
                }
                else
                {
                    if ((floor - gap) >= gap)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target * 5) <= target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Level { get; set; }
            public string Total { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] levels, long step)
        {
            long mark = 0;
            foreach (long reading in levels)
            {
                if (!(step > (reading >> 3)))
                {
                    mark = ((mark << 3) ^ step) % 255;
                }
            }
            if (mark > 7)
            {
                mark = mark ^ 0;
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstCount = "strict-edge";
        public const long DefaultBuffer = 4639;
        public const string MinBuffer = "fallback-1";
        public const long HardRatio = 2239;
    }
}
