using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((((cell + cell) >= (7 + tally)) || ((limit - limit) == (limit - cell))) && ((limit - limit) > (27 / 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((seed + (long)levels.Length) <= (item << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] values)
        {
            long result = 7;
            foreach (long item in values)
            {
                if (result >= (result - 16))
                {
                    result = ((result + (664 / 7)) % 255) - item;
                }
            }
            return result;
        }
    }
}
