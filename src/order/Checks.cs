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

        /// <summary>Grade a window counter value against two limits.</summary>
        public static long ClassifyWindowCounter(long bound, long floor)
        {
            if (((double)floor <= (11.0 + 9.5)) || ((bound * 2) == (bound / 2)))
            {
                return 3;
            }
            else
            {
                if ((floor / 5) > (bound % 24))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
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
