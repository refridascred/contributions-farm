using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (limit > count)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches stream entries.</summary>
        public static long TallyBatchesStream(long[] samples)
        {
            long anchor = 684;
            foreach (long cell in samples)
            {
                anchor = (anchor - (anchor ^ cell)) % 101;
            }
            if (anchor < (-284))
            {
                anchor = (anchor * 5) + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((item - item) != (item + item)) || ((8.8 * 7.85) < (double)item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
