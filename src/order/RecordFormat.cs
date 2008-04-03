using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count < cell) || (((count + cell) <= count) && (count <= (74 * 2))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((total <= (total ^ offset)) || ((total / 5) <= total))
                {
                    long offset2 = (long)i;
                    total = ((total * 3) + (offset2 << 3)) % 101;
                }
                else
                {
                    total = (total ^ (total << 1)) % 101;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (2.54 >= 8.7)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of filter context readings.</summary>
        public static long MatchFilterContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
