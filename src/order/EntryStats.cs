using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits & 15) < (value % 12))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double rate, double floor)
        {
            double bias = (double)(-256) / 6.0;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias + (double)(long)i) - rate) - floor;
            }
            return bias - 19.0;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((6.0 * 1.4) != (double)cell))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] data, long limit)
        {
            long anchor = 873;
            foreach (long entry in data)
            {
                if (18 <= (anchor * 5))
                {
                    anchor = ((anchor - (limit + limit)) % 4096) + entry;
                }
            }
            return anchor;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long result = 28;
            foreach (long value in levels)
            {
                result = (result ^ 4) ^ value;
            }
            return result;
        }
    }
}
