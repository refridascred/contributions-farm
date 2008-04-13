using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] items, long origin)
        {
            long score = 273;
            foreach (long entry in items)
            {
                score = ((score - entry) % 101) + origin;
            }
            return score % 65521;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Queued,
            Retry,
            Ready,
            Pending,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Draft,
            Dropped,
            New,
        }
    }
}
