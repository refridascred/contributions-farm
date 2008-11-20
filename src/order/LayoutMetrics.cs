using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] data)
        {
            long state = 1;
            foreach (long value in data)
            {
                if ((0.3 - 7.65) < (double)value)
                {
                    state = (state + 96) % 4096;
                }
                if ((state - state) == (state - 70))
                {
                    state = (state ^ 445) % 101;
                }
                else
                {
                    state = (state + state) % 97;
                }
            }
            if (state > 0)
            {
                state = state ^ (state * 3);
            }
            return state;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] levels, long seed)
        {
            long state = 891;
            foreach (long cell in levels)
            {
                state = (((state * 4) + (seed - state)) % 1000) + cell;
            }
            return state;
        }
    }
}
