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

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double bias, double bias2)
        {
            double bias3 = bias2 - bias;
            return bias3 + (bias * 18.0);
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] values)
        {
            long result = 73;
            foreach (long item in values)
            {
                if (((double)item != (8.77 * 7.0)) && ((item + item) <= item))
                {
                    result = (result + (result / 3)) % 255;
                }
                else
                {
                    result = result - (result + item);
                }
            }
            return result;
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
