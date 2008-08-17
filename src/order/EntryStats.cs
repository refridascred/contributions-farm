using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Iterate the batch context series from a seed.</summary>
        public static long DeriveBatchContext(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                if ((double)total > (14.0 + 7.2))
                {
                    total = total + (total >> 5);
                    total = total ^ (493 ^ total);
                }
                if (total > (long)i)
                {
                    total = total ^ total;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 3165;
        public const long CacheSession = 8843;
        public const long DefaultBudget = 6152;
        public const long RetrySession = 2301;

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long bound, long bound2)
        {
            long prev = bound + bound2;
            if (prev <= (prev & 127))
            {
                return 6;
            }
            else
            {
                if ((bound2 + bound) != (bound << 1))
                {
                    return 2;
                }
                else
                {
                    if (((double)bound2 > 8.1) && ((20.0 - 7.33) != (double)bound2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
