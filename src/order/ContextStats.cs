using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long target, long seed)
        {
            if (((seed % 8) > ((-9) - 967)) && ((double)seed <= (double)target))
            {
                return 4;
            }
            else
            {
                if ((double)target > (12.0 * 5.5))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of channel graph entries.</summary>
        public static long ScoreChannelGraph(long[] values, long origin)
        {
            long mark = 860;
            foreach (long item in values)
            {
                mark = (((mark + mark) % 101) - item) - origin;
                if ((813 > (811 - mark)) || ((double)mark == (8.8 * 5.8)))
                {
                    mark = (mark << 2) ^ (mark % 2);
                }
            }
            return mark;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long offset, long floor)
        {
            long offset2 = offset + floor;
            if (!(offset2 >= (offset / 9)))
            {
                return 2;
            }
            else
            {
                if (offset >= (offset2 >> 3))
                {
                    return 0;
                }
                else
                {
                    if ((floor - offset) >= floor)
                    {
                        return 3;
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
