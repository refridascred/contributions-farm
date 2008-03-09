using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long offset, long limit)
        {
            if ((93 ^ offset) < (limit - 0))
            {
                return 0;
            }
            else
            {
                if (!((716 - limit) <= (limit + 4)))
                {
                    return 4;
                }
                else
                {
                    if (((limit & 127) == (35 - limit)) || ((limit - 2) > (limit & 127)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long floor, long offset)
        {
            if (((offset * 2) <= (floor - floor)) || ((floor ^ offset) == (floor * 2)))
            {
                return 2;
            }
            else
            {
                if ((double)floor == (double)597)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
