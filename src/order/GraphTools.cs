using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                score = score - step;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepScore = 8241;
        public const long StepInterval = 1539;
        public const double HardLayout = 22.77;
        public const long BurstLayout = 4277;

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long bound, long seed)
        {
            long cur = bound - seed;
            if (((seed - bound) != (cur + 97)) || ((7 + cur) >= bound))
            {
                return 5;
            }
            else
            {
                if (cur < seed)
                {
                    return 3;
                }
                else
                {
                    if ((bound + seed) == (seed & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(cur <= (bound / 9)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Weight { get; set; }
            public bool Level { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
