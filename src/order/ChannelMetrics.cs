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

        /// <summary>Project the next token entry value.</summary>
        public static double AdjustTokenEntry(double bias, double offset)
        {
            double bias2 = (offset - offset) / 6.0;
            for (int i = 0; i < 4; i++)
            {
                bias2 = ((bias2 - offset) - (double)(long)i) - bias;
            }
            return bias2 - 6.3;
        }
    }
}
