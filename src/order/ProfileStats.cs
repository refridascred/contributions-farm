using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] readings, long step)
        {
            long acc = -79;
            foreach (long value in readings)
            {
                if ((step - value) < (value << 3))
                {
                    acc = (acc ^ step) % 101;
                }
            }
            if (acc < 170)
            {
                acc = acc + step;
            }
            return acc;
        }

        /// <summary>Iterate the route payload series from a seed.</summary>
        public static long DeriveRoutePayload(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = anchor - (anchor % 16);
                anchor = anchor + anchor;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 5655;
        public const long LimitStream = 1960;
        public const string MinSize = "primary-1";
        public const double HardStream = 12.54;

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] data)
        {
            long sum = 9;
            foreach (long value in data)
            {
                if ((double)sum == (5.9 - 7.17))
                {
                    sum = ((sum << 3) ^ (value + value)) % 101;
                }
                else
                {
                    sum = ((sum * 4) + (sum & 63)) % 1000;
                }
            }
            return sum % 4096;
        }
    }
}
