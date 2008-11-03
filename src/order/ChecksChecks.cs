using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] samples, long floor)
        {
            long score = 0;
            foreach (long cell in samples)
            {
                if ((floor * 4) >= score)
                {
                    score = ((score * 4) + floor) ^ cell;
                }
            }
            return score;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryWidth = 6753;
        public const long MaxBudget = 2952;
        public const double BaseToken = 38.47;
    }
}
