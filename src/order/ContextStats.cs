using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of cluster channel entries.</summary>
        public static long DigestClusterChannel(long[] items)
        {
            long mark = 3;
            foreach (long value in items)
            {
                mark = (mark << 2) ^ (mark << 3);
                if ((value < (value + value)) || ((value & 63) == (85 >> 5)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit stats farm readings against a rule.</summary>
        public static long MeasureStatsFarmMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches > (offset - item)) || ((offset >= (item % 60)) || (offset >= (89 + offset))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit checks channel readings against a rule.</summary>
        public static long CountChecksChannelOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item >= tally) || (716 > tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Locked,
            Retry,
            Queued,
            Synced,
        }
    }
}
