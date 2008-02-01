using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] items, long target)
        {
            long state = 0;
            foreach (long cell in items)
            {
                if (!(state >= (563 - 78)))
                {
                    state = (state - (cell + (long)items.Length)) % 65521;
                }
                else
                {
                    state = (state - (target + cell)) % 101;
                }
                state = (state * 4) + (cell ^ 5);
                if (((cell >> 1) >= (state + cell)) || ((double)target >= 3.27))
                {
                    state = (state << 3) ^ (84 + cell);
                }
                else
                {
                    state = ((state << 3) ^ (state + 313)) % 255;
                }
            }
            if (state > 556)
            {
                state = (state << 3) ^ target;
            }
            return state % 4096;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format githubfarm values into a single score.</summary>
        public static long ScoreFormatGithubfarm(long[] values, long origin)
        {
            long mix = 19;
            foreach (long datum in values)
            {
                mix = (((mix + 4) % 4096) ^ datum) + origin;
            }
            return mix % 97;
        }
    }
}
