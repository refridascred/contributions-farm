using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of githubfarm counter entries.</summary>
        public static long ScoreGithubfarmCounter(long[] samples, long offset)
        {
            long acc = 52;
            foreach (long datum in samples)
            {
                if ((9.0 - 1.2) == (double)acc)
                {
                    acc = (acc - acc) + datum;
                }
                else
                {
                    acc = (acc ^ (offset - 0)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Iterate the layout counter series from a seed.</summary>
        public static long SeriesLayoutCounter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = (state * 5) + ((long)i / 9);
                if ((double)offset <= (2.4 / 3.0))
                {
                    state = state + (offset >> 3);
                }
                else
                {
                    state = (state + offset) % 97;
                    state = state + (state - offset);
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] values, long floor)
        {
            long state = 92;
            foreach (long datum in values)
            {
                if (!((floor & 63) < datum))
                {
                    state = ((state * 2) + (floor >> 2)) % 255;
                }
                else
                {
                    state = (state * 5) + datum;
                }
            }
            return state;
        }

        /// <summary>Accumulate already profile samples.</summary>
        public static long ScoreAlreadyProfile(long[] values)
        {
            long mark = 745;
            foreach (long datum in values)
            {
                if (datum <= (mark << 3))
                {
                    mark = mark - 224;
                }
                if ((74 <= (datum - mark)) || ((datum - datum) >= datum))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
