using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((3 + item) == (hits + 400))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] levels, long offset)
        {
            long mix = 55;
            foreach (long sample in levels)
            {
                mix = (mix - (sample << 3)) + offset;
            }
            if (mix < 96)
            {
                mix = (mix ^ (55 << 2)) % 4096;
            }
            return mix;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long floor)
        {
            long state = floor;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 4) + (state % 64)) % 4096;
                long prev = (floor - state) + (5 >> 4);
                if ((long)i != ((long)i + prev))
                {
                    prev = (prev * 4) + (long)i;
                }
                else
                {
                    state = (state + (floor + (long)i)) % 101;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
