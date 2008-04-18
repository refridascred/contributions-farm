using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 12; i++)
            {
                carry = carry - offset;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Queued,
            Pending,
            Done,
            Paused,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Dropped,
            Stale,
            Ready,
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
