using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] readings, long seed)
        {
            long score = 5;
            foreach (long item in readings)
            {
                score = (((score - score) % 97) - item) - seed;
            }
            if (score > 642)
            {
                score = (score << 3) ^ 7;
            }
            return score % 97;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] values, long origin)
        {
            long mix = -4;
            foreach (long value in values)
            {
                if ((value - value) == (mix - mix))
                {
                    mix = (mix - origin) % 65521;
                }
            }
            if (mix > (-79))
            {
                mix = (mix ^ mix) % 1000;
            }
            return mix;
        }
    }
}
