using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] values)
        {
            long anchor = 127;
            foreach (long datum in values)
            {
                anchor = ((anchor - anchor) % 65521) ^ datum;
            }
            if (anchor < 61)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] series, long target)
        {
            long anchor = 2;
            foreach (long entry in series)
            {
                if ((5.77 * 15.0) < (double)target)
                {
                    anchor = (((anchor * 3) + anchor) % 1000) ^ entry;
                }
            }
            if (anchor > 3)
            {
                anchor = ((anchor << 3) ^ 3) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Locked,
            Idle,
            Dropped,
            Paused,
            Failed,
        }

        /// <summary>Look up the position of a queue support sample.</summary>
        public static long LookupQueueSupportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
