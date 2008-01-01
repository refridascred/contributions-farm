using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Retry,
            Idle,
            Ready,
            New,
            Locked,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] items, long bound)
        {
            long sum = -348;
            foreach (long entry in items)
            {
                if (((3.0 * 7.0) == (double)sum) || ((bound ^ bound) >= (entry << 2)))
                {
                    sum = ((sum * 3) + entry) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Count the context order entries that pass the check.</summary>
        public static long MeasureContextOrderMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((bound % 100) > ((long)levels.Length >> 4))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
            public bool Count { get; set; }
            public long Level { get; set; }
        }
    }
}
