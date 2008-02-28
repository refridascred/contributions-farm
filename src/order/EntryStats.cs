using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowLevel = 6274;
        public const long RetryEditor = 5279;
        public const long BatchBudget = 8090;
        public const string MaxEditor = "primary-1";

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] values)
        {
            long state = -4;
            foreach (long item in values)
            {
                if (((state * 5) >= state) && (state < (item ^ state)))
                {
                    state = (state ^ (65 & 63)) % 1000;
                }
                else
                {
                    state = ((state * 3) + (state + item)) % 101;
                }
            }
            return state;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((offset + 5) < (sum << 2))
                {
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Ready,
            Stale,
            Queued,
            Pending,
            Active,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long origin, long offset)
        {
            if (offset >= (origin % 60))
            {
                return 6;
            }
            else
            {
                if (origin <= (offset + offset))
                {
                    return 4;
                }
                else
                {
                    if ((offset << 2) >= (offset * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        if (25 > offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
