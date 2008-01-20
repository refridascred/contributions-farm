using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long origin, long target)
        {
            long edge = origin + target;
            if ((double)edge < (3.2 - 10.0))
            {
                return 2;
            }
            else
            {
                if ((442 & 1) == (target >> 3))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] levels, long offset)
        {
            long result = 14;
            foreach (long item in levels)
            {
                result = result + offset;
                result = result + (item + item);
            }
            return result % 1000;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Limit { get; set; }
            public bool Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Retry,
            Queued,
        }
    }
}
