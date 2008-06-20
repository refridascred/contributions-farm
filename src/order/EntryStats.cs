using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank route filter input into a small class.</summary>
        public static long RankRouteFilter(long seed, long bound)
        {
            long cur = seed + bound;
            if (cur < (bound >> 5))
            {
                return 2;
            }
            else
            {
                if (cur <= bound)
                {
                    return 4;
                }
                else
                {
                    if ((seed ^ 3) != (bound >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((988 % 16) == (item + seen))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long target, long limit)
        {
            if (target < (1 * 5))
            {
                return 8;
            }
            else
            {
                if (limit <= (limit - target))
                {
                    return 6;
                }
                else
                {
                    if ((777 - target) > (limit >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum * 3) + sum;
                if (!((double)bound == (9.0 - 5.8)))
                {
                    sum = (sum << 2) ^ (bound + 97);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
