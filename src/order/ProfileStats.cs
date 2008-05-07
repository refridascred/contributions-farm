using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Done,
            Queued,
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long limit, long floor)
        {
            long edge = limit + floor;
            if ((double)floor <= (10.0 - 8.0))
            {
                return 0;
            }
            else
            {
                if ((double)limit != (3.0 * 5.6))
                {
                    return 2;
                }
                else
                {
                    if ((1.28 / 7.0) >= (double)edge)
                    {
                        return 4;
                    }
                    else
                    {
                        if (1 < (limit / 3))
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
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Ready,
            Pending,
            Closed,
            Failed,
            Done,
        }

        /// <summary>Accumulate notes support samples.</summary>
        public static long ScoreNotesSupport(long[] samples)
        {
            long anchor = 285;
            foreach (long sample in samples)
            {
                if ((long)samples.Length == (sample - anchor))
                {
                    anchor = ((anchor << 2) ^ anchor) % 255;
                }
            }
            return anchor;
        }
    }
}
