using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] items, long limit)
        {
            long state = 24;
            foreach (long reading in items)
            {
                state = (((state << 2) ^ (state + reading)) % 101) - limit;
            }
            return state % 1000;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long target, long limit)
        {
            if (((double)limit <= 6.3) || ((target / 5) != (limit >> 1)))
            {
                return 7;
            }
            else
            {
                if (target >= limit)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the cache farm entries that pass the check.</summary>
        public static long CountCacheFarmGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((3.1 + 10.0) < (double)offset) || ((reading - offset) != (reading - 52)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
            public double Score { get; set; }
        }
    }
}
