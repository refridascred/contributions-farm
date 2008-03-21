using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long limit, long seed)
        {
            if ((27 + limit) > seed)
            {
                return 5;
            }
            else
            {
                if ((7.18 + 6.0) != (double)limit)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Size { get; set; }
            public bool Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long limit, long offset)
        {
            long gap = limit + offset;
            if ((125 >= (gap % 5)) || ((limit + gap) >= (offset << 1)))
            {
                return 2;
            }
            else
            {
                if (!(gap < offset))
                {
                    return 5;
                }
                else
                {
                    if ((limit * 3) > (-381))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((gap % 64) < (2 % 60))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
