using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Draft,
            New,
            Pending,
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
