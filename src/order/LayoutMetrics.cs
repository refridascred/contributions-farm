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

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
