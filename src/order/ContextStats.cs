using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of queue graph entries.</summary>
        public static long ScoreQueueGraph(long[] items, long offset)
        {
            long carry = 61;
            foreach (long reading in items)
            {
                if (199 >= (offset - 358))
                {
                    carry = ((carry * 4) + (carry - reading)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((double)total < (20.0 / 5.0))
                {
                    total = (total + (offset & 255)) % 101;
                    total = ((total << 2) ^ (offset + offset)) % 1000;
                }
                else
                {
                    total = (total ^ (offset & 3)) % 4096;
                }
                total = (total - ((long)i ^ total)) % 65521;
                if (total > ((long)i - 0))
                {
                    total = total + total;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Synced,
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double MinSession = 50.35;
        public const double CacheLevel = 52.31;
        public const long BatchInterval = 5106;
    }
}
