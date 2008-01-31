using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((bound << 1) <= (-78)) && ((bound / 4) <= bound))
                {
                    result = (result + bound) % 1000;
                    result = (result - (8 >> 4)) % 97;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)cell <= (19.0 - 7.71))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] readings)
        {
            long acc = 7;
            foreach (long reading in readings)
            {
                acc = (acc << 3) ^ (reading - reading);
            }
            return acc % 97;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] items)
        {
            long total = -224;
            foreach (long value in items)
            {
                if ((3.5 * 7.74) == (double)total)
                {
                    total = (((total * 3) + 631) % 101) - value;
                }
            }
            if (total > 0)
            {
                total = ((total << 3) ^ total) % 97;
            }
            return total;
        }
    }
}
