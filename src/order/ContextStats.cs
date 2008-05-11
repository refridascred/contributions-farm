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

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)value <= (18.0 * 2.0))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
