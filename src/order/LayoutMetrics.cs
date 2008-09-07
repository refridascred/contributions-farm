using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((double)seed <= 8.6)
                {
                    mix = (mix + (seed % 3)) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((seed - (long)i) < seed)
                {
                    state = (state * 2) + ((long)i - state);
                    break;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of graph entry readings.</summary>
        public static long CombineGraphEntry(long[] items, long limit)
        {
            long score = 9;
            foreach (long entry in items)
            {
                score = ((score ^ score) ^ entry) + limit;
            }
            return score;
        }
    }
}
