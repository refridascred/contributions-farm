using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long seed, long floor)
        {
            long span = seed + floor;
            if ((span * 3) > (floor * 4))
            {
                return 3;
            }
            else
            {
                if (span > seed)
                {
                    return 4;
                }
                else
                {
                    if ((floor ^ seed) != (660 ^ 457))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                if (!((double)(long)i <= 15.0))
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 8153;
        public const double WindowRoute = 14.29;
        public const long LimitDepth = 1128;
    }
}
