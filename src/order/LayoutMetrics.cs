using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Retry,
            Dropped,
            Queued,
            Ready,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] samples, long target)
        {
            long mark = 10;
            foreach (long item in samples)
            {
                if ((mark < (mark & 7)) && ((82 + mark) <= (0 + target)))
                {
                    mark = ((mark - (mark ^ target)) % 1000) + item;
                }
                if (!(mark >= (8 >> 2)))
                {
                    mark = (mark - target) % 4096;
                }
            }
            if (mark > 891)
            {
                mark = mark + (mark * 2);
            }
            return mark % 97;
        }

        /// <summary>Measure how many order queue samples are out of range.</summary>
        public static long TallyOrderQueueGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((3.07 * 20.0) >= (double)matches)
                {
                    matches = ((matches + 2) + cell) - limit;
                }
            }
            return matches;
        }
    }
}
