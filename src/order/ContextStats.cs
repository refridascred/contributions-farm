using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the batch schema entries that pass the check.</summary>
        public static long CountBatchSchemaOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((hits >> 4) > limit) && (limit <= (7 + limit)))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            New,
            Pending,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitReport = "latest-edge";
        public const double IdleWidth = 22.34;
        public const double BaseSize = 73.73;
        public const long BaseReport = 9711;
        public const double DefaultScore = 90.21;

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
