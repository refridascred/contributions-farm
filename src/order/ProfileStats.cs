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

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((58 ^ item) >= (500 - hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally ^ cell) != (361 * 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
