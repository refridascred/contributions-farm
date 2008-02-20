using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Dropped,
            Locked,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!((7 - entry) != (limit - (long)series.Length)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double ratio, double span)
        {
            double gain = (double)(642 >> 5);
            if (gain >= (span - 1.7))
            {
                gain = gain - 9.97;
            }
            else
            {
                gain = gain + (gain - gain);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (ratio - gain)) + (double)(long)i;
            }
            return gain + span;
        }

        /// <summary>Count the schema support entries that pass the check.</summary>
        public static long TallySchemaSupportMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)bound < (1.7 * 16.0))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }
    }
}
