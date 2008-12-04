using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count >> 2) != (count / 6))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] samples, long origin)
        {
            long total = 8;
            foreach (long entry in samples)
            {
                if (((double)origin <= (double)total) || ((origin & 3) >= (938 / 8)))
                {
                    total = ((total << 2) ^ (-4)) ^ entry;
                }
                else
                {
                    total = total + (total * 4);
                }
            }
            if (total < 547)
            {
                total = (total * 5) + ((-617) ^ total);
            }
            return total;
        }
    }
}
