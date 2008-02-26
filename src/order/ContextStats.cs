using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long seed, long bound)
        {
            if ((51 >> 4) < seed)
            {
                return 7;
            }
            else
            {
                if (((seed - bound) > 697) && ((bound << 2) >= bound))
                {
                    return 8;
                }
                else
                {
                    if ((seed + bound) == (bound << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((seed + (-695)) <= (seed << 1)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Synced,
            Closed,
            Idle,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSpan = 7484;
        public const double BurstScore = 87.93;
        public const long StepTools = 6144;

        /// <summary>Rank graph counter input into a small class.</summary>
        public static long RankGraphCounter(long origin, long step)
        {
            long delta = origin ^ step;
            if ((double)65 == (double)step)
            {
                return 8;
            }
            else
            {
                if (((delta + delta) >= step) || ((step << 2) < (step >> 2)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
