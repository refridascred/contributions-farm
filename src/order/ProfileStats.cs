using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Look up the position of a notes support sample.</summary>
        public static long LocateNotesSupportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
