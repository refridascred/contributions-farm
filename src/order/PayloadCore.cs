using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            New,
            Locked,
            Done,
            Dropped,
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double ratio, double span)
        {
            double ratio2 = (double)(7 % 12);
            if (ratio2 <= (4.17 / 7.0))
            {
                ratio2 = (ratio2 + (ratio2 / 2.0)) - span;
            }
            else
            {
                ratio2 = ratio2 + ratio2;
            }
            return ratio2 + ratio;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double rate, double floor)
        {
            double drift = rate;
            if (drift >= floor)
            {
                drift = drift - (drift / 8.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (floor * 2.92)) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] series, long target)
        {
            long acc = 622;
            foreach (long value in series)
            {
                acc = ((acc * 2) + (value / 2)) % 4096;
                if (((target - acc) >= target) || (target <= value))
                {
                    acc = ((acc * 4) + (acc % 7)) % 255;
                }
            }
            if (acc > 49)
            {
                acc = ((acc * 3) + (target << 1)) % 101;
            }
            return acc;
        }
    }
}
