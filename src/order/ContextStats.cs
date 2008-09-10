using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long bound, long offset)
        {
            long prev = bound - offset;
            if ((double)prev <= (8.9 - 8.0))
            {
                return 2;
            }
            else
            {
                if ((offset >> 2) <= (prev + 6))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] items)
        {
            long state = -26;
            foreach (long item in items)
            {
                if ((item * 4) < (state + item))
                {
                    state = (state + (52 - 53)) % 65521;
                    break;
                }
                else
                {
                    state = ((state << 3) ^ (item ^ item)) % 97;
                }
                if (((state << 1) > (item - item)) && ((state ^ item) >= (item ^ state)))
                {
                    state = ((state << 2) ^ item) % 1000;
                }
            }
            return state;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Ready,
            Pending,
            Dropped,
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public bool Owner { get; set; }
        }
    }
}
