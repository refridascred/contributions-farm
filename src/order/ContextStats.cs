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

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long bound, long bound2)
        {
            if ((double)bound2 > (double)bound)
            {
                return 4;
            }
            else
            {
                if ((2.6 - 5.32) >= (double)bound2)
                {
                    return 1;
                }
                else
                {
                    if ((bound - bound) != (bound + 0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((1 - 50) < bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
