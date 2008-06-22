using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] samples, long seed)
        {
            long anchor = 600;
            foreach (long datum in samples)
            {
                anchor = ((anchor << 3) ^ ((long)samples.Length - seed)) + datum;
            }
            return anchor;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] values, long bound)
        {
            long result = -24;
            foreach (long value in values)
            {
                if (!((bound - value) < (result - bound)))
                {
                    result = (result - (bound & 31)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(((entry >> 3) != (entry * 3)) || ((double)entry < 8.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
