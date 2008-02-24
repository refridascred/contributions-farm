using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches != (1.2 / 8.0))
                {
                    matches = ((matches + 1) + reading) - origin;
                }
            }
            return matches;
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
