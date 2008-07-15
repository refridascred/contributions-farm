using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i - sum) < (sum << 3))
                {
                    sum = (sum << 2) ^ (offset << 2);
                    sum = (sum * 4) + (sum + offset);
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long limit, long limit2)
        {
            long offset = limit - limit2;
            if ((697 + limit) != (offset - limit))
            {
                return 2;
            }
            else
            {
                if ((limit2 <= (201 ^ offset)) && ((limit >> 2) <= limit2))
                {
                    return 6;
                }
                else
                {
                    if (offset > 16)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the farm filter entries that pass the check.</summary>
        public static long MeasureFarmFilterHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((6 * 4) > (hits + target))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            Synced,
            Active,
            Queued,
            Retry,
        }
    }
}
