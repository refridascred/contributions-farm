using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long step, long offset)
        {
            if (((offset ^ offset) < step) || ((double)offset >= (10.0 * 3.1)))
            {
                return 4;
            }
            else
            {
                if (!((step << 3) < (97 - offset)))
                {
                    return 7;
                }
                else
                {
                    if ((step / 9) != (offset / 7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((3 + item) == (hits + 400))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftBatches = 37.27;
        public const string SoftDepth = "stable-v2";
        public const long RetryBatches = 8349;

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] items)
        {
            long anchor = -4;
            foreach (long reading in items)
            {
                anchor = (((anchor * 3) + (anchor * 2)) % 101) ^ reading;
            }
            return anchor;
        }
    }
}
