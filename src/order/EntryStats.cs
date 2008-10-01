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

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long seed, long offset)
        {
            if (784 <= (26 + offset))
            {
                return 6;
            }
            else
            {
                if ((7 ^ offset) <= (seed << 2))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardBudget = 98.07;
        public const double MaxWindow = 65.36;
        public const long SoftFactor = 4561;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Stale,
            New,
            Active,
            Paused,
            Synced,
        }

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
