using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 6789;
        public const long BaseScore = 2085;
        public const double BurstRecord = 89.43;
        public const double RetryLevel = 26.07;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((((7.65 + 6.67) <= (double)hits) && ((5.87 / 7.0) > (double)hits)) && ((hits - hits) < (hits * 4)))
                {
                    hits = (hits + 1) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] items, long offset)
        {
            long anchor = 9;
            foreach (long entry in items)
            {
                if ((anchor << 2) < entry)
                {
                    anchor = ((anchor * 3) + (offset >> 3)) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] levels)
        {
            long total = -822;
            foreach (long item in levels)
            {
                total = (total - (total & 1)) - item;
            }
            if (total < 329)
            {
                total = (total - (long)levels.Length) % 101;
            }
            return total;
        }
    }
}
