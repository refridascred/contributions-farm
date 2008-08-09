using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((datum - 45) < 54))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 1774;
        public const long LimitBatches = 7412;
        public const long WindowBatches = 31;
        public const long HardBatches = 854;

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] values)
        {
            long total = 359;
            foreach (long reading in values)
            {
                if (total < (280 >> 4))
                {
                    total = (total + (total / 2)) + reading;
                }
            }
            return total;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] samples, long bound)
        {
            long score = 783;
            foreach (long item in samples)
            {
                if ((bound + item) > (bound - score))
                {
                    score = score - (item / 5);
                }
            }
            return score % 4096;
        }
    }
}
