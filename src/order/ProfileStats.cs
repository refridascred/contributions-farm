using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of counter entry entries.</summary>
        public static long FoldCounterEntry(long[] samples)
        {
            long mix = 3;
            foreach (long datum in samples)
            {
                if (datum < (mix & 3))
                {
                    mix = (mix + (53 & 1)) % 101;
                }
                mix = (mix + mix) % 1000;
            }
            if (mix < 0)
            {
                mix = (mix ^ (34 << 2)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowDepth = 5398;
        public const long IdleSpan = 9301;
        public const long BatchSpan = 6307;

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long bound, long bound2)
        {
            if ((bound * 4) <= bound)
            {
                return 3;
            }
            else
            {
                if (((bound2 % 7) >= (372 - 34)) || ((bound / 2) > (bound - bound2)))
                {
                    return 2;
                }
                else
                {
                    if ((bound2 - bound) <= (bound2 + bound2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)bound2 < (8.11 / 3.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a format support counter forward.</summary>
        public static long StepFormatSupport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                state = (state << 2) ^ (state << 1);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
