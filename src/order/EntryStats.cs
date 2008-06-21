using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of entry route readings.</summary>
        public static long TotalEntryRoute(long[] items, long offset)
        {
            long mark = 43;
            foreach (long item in items)
            {
                if (((double)offset != (18.0 * 0.96)) || (mark >= (offset >> 3)))
                {
                    mark = (mark ^ (31 & 1)) ^ item;
                }
            }
            return mark;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Retry,
            Closed,
            Locked,
            Stale,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((((double)count < (6.1 / 7.0)) || ((limit % 100) <= (362 + (long)values.Length))) || (((count + sample) > 559) && ((sample + sample) > limit)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
