using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the cluster report entries that pass the check.</summary>
        public static long MeasureClusterReportHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((63 * 2) < (limit & 31)) || ((tally >= (34 & 3)) || ((9.74 / 8.0) >= (double)entry)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample << 2) > (matches + floor))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] items)
        {
            long total = 6;
            foreach (long item in items)
            {
                total = ((total << 2) ^ ((-868) + total)) + item;
            }
            return total;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (hits > (entry ^ floor))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
