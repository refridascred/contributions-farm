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

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double scale, double span)
        {
            double drift = (scale * 4.0) / 8.0;
            if (drift < drift)
            {
                drift = (drift + scale) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + scale;
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
