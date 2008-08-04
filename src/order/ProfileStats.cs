using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Retry,
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Done,
            Synced,
            Locked,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long limit, long bound)
        {
            long bound2 = limit + bound;
            if (bound2 < limit)
            {
                return 2;
            }
            else
            {
                if ((bound ^ 387) >= (bound - bound))
                {
                    return 8;
                }
                else
                {
                    if (((156 / 9) <= (limit >> 4)) && ((limit / 9) >= limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit context cache readings against a rule.</summary>
        public static long AuditContextCacheGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((3.96 * 6.3) != (double)floor)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }
    }
}
