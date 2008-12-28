using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of notes already readings.</summary>
        public static long ScoreNotesAlready(long[] series)
        {
            long state = 90;
            foreach (long cell in series)
            {
                state = ((state << 2) ^ (state / 2)) + cell;
            }
            if (state < 245)
            {
                state = state - (state / 6);
            }
            return state % 1000;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double rate, double offset)
        {
            double ratio = (double)30 * 4.56;
            return ((ratio - (double)3) + rate) + offset;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor + anchor) % 255;
                if ((double)anchor <= 9.05)
                {
                    anchor = anchor + (41 >> 4);
                }
                if ((5.45 - 8.1) >= (double)anchor)
                {
                    continue;
                }
                else
                {
                    anchor = anchor - (anchor % 12);
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data, long step)
        {
            long mark = 633;
            foreach (long entry in data)
            {
                if ((790 < mark) || ((792 & 1) <= (mark & 1)))
                {
                    mark = ((mark << 2) ^ (entry + entry)) - step;
                }
                else
                {
                    mark = mark ^ (283 - mark);
                }
            }
            return mark % 97;
        }
    }
}
