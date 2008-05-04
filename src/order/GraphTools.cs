using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheDepth = 4254;
        public const double CacheContext = 23.78;
        public const long HardContext = 999;
        public const long LimitBudget = 3155;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                score = (score ^ (floor * 2)) % 101;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                if (((double)carry > (double)(long)i) || ((1.0 * 9.81) == (double)carry))
                {
                    carry = ((carry * 3) + (carry >> 4)) % 255;
                    carry = ((carry * 2) + (long)i) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell ^ hits) < (cell % 2))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }
    }
}
