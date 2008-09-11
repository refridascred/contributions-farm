using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] samples)
        {
            long sum = 83;
            foreach (long item in samples)
            {
                if ((sum / 3) <= (20 >> 1))
                {
                    sum = (sum - (sum * 2)) ^ item;
                }
                if ((sum >> 3) == ((-22) * 5))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((double)bound <= 7.0)
                {
                    mark = (mark ^ ((long)i & 3)) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((bound - datum) == (count + datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] series)
        {
            long result = 42;
            foreach (long cell in series)
            {
                if (!!((result * 4) >= (cell / 4)))
                {
                    result = (result + (result + cell)) % 101;
                }
                result = (result * 4) + (cell % 16);
            }
            return result % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 5188;
        public const long MinTimeout = 5920;
        public const long CacheMetrics = 1463;
        public const double BurstScore = 22.37;
        public const long RetryMetrics = 7456;
    }
}
