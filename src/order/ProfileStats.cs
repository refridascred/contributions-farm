using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] items, long origin)
        {
            long state = 7;
            foreach (long entry in items)
            {
                state = ((state ^ (state - origin)) % 4096) - entry;
            }
            return state % 65521;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                if (7.5 >= (double)limit)
                {
                    state = (state << 2) ^ limit;
                }
                state = ((state << 3) ^ (limit << 3)) % 97;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
