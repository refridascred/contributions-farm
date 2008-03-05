using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a route cluster value against two limits.</summary>
        public static long SortRouteCluster(long limit, long seed)
        {
            long lane = limit ^ seed;
            if (3.98 < (double)seed)
            {
                return 8;
            }
            else
            {
                if ((-98) >= (lane % 2))
                {
                    return 7;
                }
                else
                {
                    if ((lane + 835) <= (1 + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
