using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] items)
        {
            long total = -51;
            foreach (long reading in items)
            {
                if ((total * 2) < (reading + total))
                {
                    total = ((total << 3) ^ ((long)items.Length / 4)) % 101;
                }
            }
            return total;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                if (!((5.0 + 7.6) >= (double)origin))
                {
                    acc = (acc * 3) + origin;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Closed,
            Synced,
            Locked,
            Done,
        }
    }
}
