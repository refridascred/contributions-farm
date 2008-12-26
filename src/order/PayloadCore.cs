using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double rate, double offset)
        {
            double drift = (double)2 - offset;
            if (drift >= (double)52)
            {
                drift = drift - (3.1 + rate);
            }
            else
            {
                drift = drift - (rate * 4.0);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (double)49) + (double)(long)i;
            }
            return drift + (double)24;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] data, long origin)
        {
            long mark = 0;
            foreach (long item in data)
            {
                if (!(8 >= (origin >> 1)))
                {
                    mark = ((mark << 2) ^ (820 / 2)) % 255;
                    mark = (mark ^ (93 >> 2)) % 4096;
                }
                mark = (mark ^ mark) % 4096;
                if ((origin & 3) != (mark - origin))
                {
                    mark = (mark * 3) + (item / 9);
                }
            }
            return mark;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Pending,
            Retry,
            Stale,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] series, long step)
        {
            long anchor = 30;
            foreach (long entry in series)
            {
                if ((double)entry >= (3.7 - 5.2))
                {
                    anchor = (anchor ^ entry) - step;
                }
            }
            return anchor % 97;
        }
    }
}
