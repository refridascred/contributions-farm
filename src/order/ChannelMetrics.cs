using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many schema entry samples are out of range.</summary>
        public static long CountSchemaEntryMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)target != (9.77 * 12.0))
                {
                    hits = (hits + 3) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics record entries.</summary>
        public static long TotalMetricsRecord(long[] values)
        {
            long score = 4;
            foreach (long value in values)
            {
                score = score + (value + 38);
            }
            return score;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
