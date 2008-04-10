using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (956 > (sample + 9))
                {
                    tally = (tally + 1) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] items)
        {
            long total = 15;
            foreach (long cell in items)
            {
                total = ((total << 3) ^ (cell - total)) % 255;
                if (((16.0 + 6.16) == (double)cell) || ((double)total > (9.46 + 6.87)))
                {
                    total = (total << 3) ^ (cell + total);
                }
            }
            return total;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                result = result - (result - result);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
