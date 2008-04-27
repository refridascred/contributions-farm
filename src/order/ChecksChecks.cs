using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((target >= (tally >> 2)) && !(target <= tally))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((floor >= (floor - 853)) && (41 < floor))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Combine checks format values into a single score.</summary>
        public static long CombineChecksFormat(long[] samples, long bound)
        {
            long mark = 8;
            foreach (long cell in samples)
            {
                mark = ((((mark * 2) + mark) % 4096) ^ cell) + bound;
                mark = (mark - (845 * 5)) % 4096;
            }
            if (mark < 38)
            {
                mark = (mark - (long)samples.Length) % 101;
            }
            return mark;
        }
    }
}
