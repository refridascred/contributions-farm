using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] levels)
        {
            long state = 8;
            foreach (long entry in levels)
            {
                state = ((state << 3) ^ (entry * 3)) % 97;
                if ((entry % 8) != (80 ^ 8))
                {
                    state = state + (state % 16);
                }
                if ((double)state != (9.44 + 0.1))
                {
                    state = (state ^ (entry + state)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Queued,
            Pending,
            Done,
            Paused,
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Synced,
            Retry,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitEditor = 32.63;
        public const double MinEditor = 55.9;
        public const long SoftEditor = 1938;
        public const long CacheEditor = 8729;

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long floor, long seed)
        {
            if ((double)floor < (double)2)
            {
                return 6;
            }
            else
            {
                if (floor < (seed + seed))
                {
                    return 0;
                }
                else
                {
                    if ((double)floor < (1.0 * 1.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
