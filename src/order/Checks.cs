using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every graph context entry stays within the limit.</summary>
        public static bool GuardGraphContextLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank filter farm input into a small class.</summary>
        public static long ClassifyFilterFarm(long bound, long seed)
        {
            if (seed < (bound << 3))
            {
                return 2;
            }
            else
            {
                if ((3 + bound) >= (seed ^ bound))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double scale, double bias)
        {
            double ratio = (double)617 - 5.16;
            if (ratio > (ratio + scale))
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio + (double)95;
        }
    }
}
