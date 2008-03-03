using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes window samples are out of range.</summary>
        public static long TallyNotesWindowGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((9.0 - 1.1) <= (3.2 * 7.9))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Audit context already readings against a rule.</summary>
        public static long CountContextAlreadyHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)item >= (double)floor)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
