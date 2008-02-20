using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Dropped,
            Locked,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!((7 - entry) != (limit - (long)series.Length)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc * 5) + 9;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Derive the next window checks value from a seed.</summary>
        public static long IterateWindowChecks(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
