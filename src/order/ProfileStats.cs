using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long seed, long limit)
        {
            long delta = seed ^ limit;
            if ((seed << 2) <= (seed + delta))
            {
                return 2;
            }
            else
            {
                if ((double)seed > (5.2 / 6.0))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long bound, long offset)
        {
            long step = bound - offset;
            if ((step >> 2) < (step + bound))
            {
                return 1;
            }
            else
            {
                if (bound <= (offset + step))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
