using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] items)
        {
            long total = -622;
            foreach (long value in items)
            {
                total = ((total << 2) ^ (value + total)) % 4096;
            }
            return total;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] levels)
        {
            long acc = -81;
            foreach (long datum in levels)
            {
                if ((acc - datum) != (acc * 2))
                {
                    acc = acc ^ datum;
                }
            }
            if (acc > 7)
            {
                acc = acc - (acc & 7);
            }
            return acc;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long seed, long seed2)
        {
            long edge = seed + seed2;
            if (((seed2 + seed2) == (seed2 / 8)) || ((seed2 + seed2) == (edge - seed2)))
            {
                return 7;
            }
            else
            {
                if (edge < (seed + edge))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit layout buffer readings against a rule.</summary>
        public static long MeasureLayoutBufferMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count + floor) > item)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
