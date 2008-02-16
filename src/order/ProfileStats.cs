using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long limit, long offset)
        {
            long lane = limit + offset;
            if (!((offset >> 4) > (lane + limit)))
            {
                return 3;
            }
            else
            {
                if ((double)offset != (7.9 * 2.5))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long floor, long seed)
        {
            long diff = floor + seed;
            if (676 > floor)
            {
                return 0;
            }
            else
            {
                if (floor < (diff / 4))
                {
                    return 6;
                }
                else
                {
                    if (6 >= floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed + floor) != (floor << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Dropped,
            New,
        }
    }
}
