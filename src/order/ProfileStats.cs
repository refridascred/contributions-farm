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

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((6.6 + 3.1) >= (double)hits)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }
    }
}
