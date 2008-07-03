using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Queued,
            Retry,
            Pending,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((seen + seen) < (484 + seen)) && ((126 ^ (long)data.Length) != (2 ^ 2)))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] levels)
        {
            long score = -11;
            foreach (long value in levels)
            {
                if ((score - score) <= value)
                {
                    score = (score + (score & 15)) % 255;
                }
            }
            if (score > 258)
            {
                score = (score ^ (score & 3)) % 65521;
            }
            return score;
        }
    }
}
