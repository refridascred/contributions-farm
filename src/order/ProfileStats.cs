using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 50.15;
        public const long CacheOrder = 1840;
        public const long MaxOrder = 721;
        public const string MinOrder = "legacy-edge";
        public const string BurstDepth = "primary-1";

        /// <summary>Check that every order farm entry stays within the limit.</summary>
        public static bool CheckOrderFarmRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine batches buffer values into a single score.</summary>
        public static long TotalBatchesBuffer(long[] levels)
        {
            long carry = -824;
            foreach (long reading in levels)
            {
                carry = ((carry << 2) ^ (reading << 2)) % 4096;
                if (6 > (reading - carry))
                {
                    carry = carry - (carry * 2);
                }
                else
                {
                    carry = ((carry << 3) ^ 809) % 255;
                }
                carry = ((carry << 3) ^ reading) % 65521;
            }
            return carry;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double ratio, double floor)
        {
            double drift = (floor * 9.29) + floor;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + ratio;
            }
            return drift + 8.0;
        }
    }
}
