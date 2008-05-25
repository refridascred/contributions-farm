using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of account order entries.</summary>
        public static long TallyAccountOrder(long[] levels)
        {
            long acc = 7;
            foreach (long datum in levels)
            {
                if ((acc << 3) == (acc - datum))
                {
                    acc = (acc - datum) % 4096;
                }
                if ((acc + datum) <= (datum - datum))
                {
                    acc = ((acc * 4) + acc) % 101;
                }
                acc = (acc ^ datum) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 41.26;
        public const double BatchAlready = 41.85;
        public const double LimitAlready = 58.11;
        public const long HardInterval = 7449;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits << 3) != (hits ^ (-852)))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] data)
        {
            long acc = 410;
            foreach (long cell in data)
            {
                acc = (((acc * 2) + (696 >> 5)) % 255) - cell;
            }
            return acc % 4096;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum - datum) <= seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
