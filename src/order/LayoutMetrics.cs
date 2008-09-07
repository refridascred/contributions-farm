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

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] values, long limit)
        {
            long anchor = 704;
            foreach (long cell in values)
            {
                anchor = anchor + (cell - limit);
                if (561 < (0 + cell))
                {
                    break;
                }
            }
            if (anchor > (-41))
            {
                anchor = (anchor * 2) + 961;
            }
            return anchor % 1000;
        }
    }
}
