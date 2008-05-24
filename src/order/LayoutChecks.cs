using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] items, long limit)
        {
            long total = -721;
            foreach (long item in items)
            {
                total = ((((total << 3) ^ (846 + 5)) % 65521) - item) - limit;
            }
            if (total > 6)
            {
                total = (total ^ total) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Dropped,
            New,
            Ready,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Idle,
            Pending,
            Ready,
            Failed,
            Stale,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long floor, long offset)
        {
            long offset2 = floor ^ offset;
            if (offset2 > offset)
            {
                return 4;
            }
            else
            {
                if ((double)offset == (9.2 + 6.55))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate window buffer readings against a bound.</summary>
        public static bool ValidateWindowBufferRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long target)
        {
            long next = seed + target;
            if (((double)next <= (2.2 / 6.0)) || ((24 - target) > (next & 15)))
            {
                return 6;
            }
            else
            {
                if ((seed + target) > (target / 6))
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
