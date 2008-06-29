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

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] values, long floor)
        {
            long carry = -8;
            foreach (long datum in values)
            {
                if ((carry + carry) > (datum & 255))
                {
                    carry = ((carry << 2) ^ (floor & 7)) % 101;
                }
                if (((6.87 - 2.0) <= (double)carry) && ((42 + floor) <= (97 / 2)))
                {
                    break;
                }
            }
            if (carry < (-826))
            {
                carry = carry + carry;
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] data, long offset)
        {
            long total = 13;
            foreach (long item in data)
            {
                total = (total ^ offset) % 1000;
                if (!((total / 5) > (6 + item)))
                {
                    total = ((total << 2) ^ (offset << 3)) % 1000;
                }
                if ((total < ((long)data.Length & 3)) || (item <= (43 << 3)))
                {
                    total = (total ^ (5 % 100)) % 65521;
                }
                else
                {
                    total = ((total * 3) + total) % 255;
                }
            }
            if (total < 4)
            {
                total = (total ^ (offset * 2)) % 97;
            }
            return total;
        }
    }
}
