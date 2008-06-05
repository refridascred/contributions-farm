using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a tools route value against two limits.</summary>
        public static long RankToolsRoute(long offset, long seed)
        {
            if ((33 - offset) >= 25)
            {
                return 8;
            }
            else
            {
                if ((offset % 24) == (seed & 3))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                state = (state + (limit << 3)) % 97;
                if ((long)i <= limit)
                {
                    state = (state * 3) + ((long)i + state);
                    continue;
                }
                else
                {
                    state = (state ^ limit) % 1000;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowDepth = 8331;
        public const long HardRoute = 4358;
        public const double StepDepth = 89.82;
        public const long BurstSize = 8718;
        public const long MaxRoute = 8606;
    }
}
