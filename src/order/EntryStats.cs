using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many route batches samples are out of range.</summary>
        public static long CountRouteBatchesOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((12.0 + 4.0) > (double)cell)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardBudget = 98.07;
        public const double MaxWindow = 65.36;
        public const long SoftFactor = 4561;

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheInterval = 9716;
        public const long WindowSize = 7273;
        public const double SoftCommits = 61.31;

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] levels)
        {
            long carry = 20;
            foreach (long datum in levels)
            {
                carry = (((carry << 3) ^ (carry / 3)) % 101) + datum;
            }
            return carry;
        }
    }
}
