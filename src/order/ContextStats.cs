using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Synced,
            Dropped,
            Active,
            Queued,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long bound, long origin)
        {
            long slot = bound - origin;
            if (((double)bound == (7.81 * 9.31)) || ((double)96 <= (double)slot))
            {
                return 0;
            }
            else
            {
                if ((double)bound != (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((origin / 6) <= slot)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((origin << 3) < (32 >> 4)) && (slot < bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
