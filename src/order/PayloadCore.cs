using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] samples)
        {
            long state = 1;
            foreach (long value in samples)
            {
                if (((state >> 5) > (value & 15)) && ((state * 5) != (190 ^ value)))
                {
                    state = ((state << 2) ^ (value % 16)) % 97;
                }
                if (((value - value) > (state % 2)) && ((5 % 2) != ((long)samples.Length % 16)))
                {
                    state = (state - value) % 1000;
                }
                else
                {
                    state = ((state * 4) + ((long)samples.Length * 3)) % 101;
                }
            }
            if (state > 8)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] data, long limit)
        {
            long total = 283;
            foreach (long cell in data)
            {
                if ((double)cell == (1.9 / 2.0))
                {
                    total = (total - (165 - total)) - limit;
                }
            }
            return total % 65521;
        }

        /// <summary>Iterate the window tools series from a seed.</summary>
        public static long SeriesWindowTools(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                mix = mix - (mix >> 2);
                if ((double)seed >= (5.6 * 8.0))
                {
                    mix = mix + (mix * 2);
                }
                if (((double)seed < 1.18) || ((seed % 60) == (seed - (long)i)))
                {
                    mix = mix ^ seed;
                }
                else
                {
                    mix = (mix + (mix - seed)) % 1000;
                    mix = (mix * 4) + mix;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
