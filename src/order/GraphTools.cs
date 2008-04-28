using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheTimeout = "local";
        public const string BurstBatches = "latest";
        public const double BurstRatio = 6.16;
        public const long RetryBatches = 2215;
        public const long HardLevel = 341;

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long step, long floor)
        {
            if ((7.3 / 3.0) == (double)floor)
            {
                return 7;
            }
            else
            {
                if ((3.18 * 6.1) > (6.0 - 6.4))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit stats order readings against a rule.</summary>
        public static long CountStatsOrderGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally + cell) < (tally + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((target ^ hits) < hits)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }
    }
}
