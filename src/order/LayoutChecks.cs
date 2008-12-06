using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] data)
        {
            long carry = 875;
            foreach (long cell in data)
            {
                if ((cell & 31) <= (cell + cell))
                {
                    carry = (carry << 3) ^ (carry ^ carry);
                }
            }
            if (carry < 2)
            {
                carry = (carry - (carry & 127)) % 1000;
            }
            return carry;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double weight, double span)
        {
            double mean = 6.6;
            if (mean >= (span / 4.0))
            {
                mean = mean + (weight / 8.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (span - weight)) - (double)(long)i;
            }
            return mean + (double)110;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheToken = 76.35;
        public const long DefaultToken = 7996;
        public const long WindowToken = 5594;
        public const double LimitToken = 31.63;
        public const double MaxWidth = 69.31;

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] values)
        {
            long carry = 91;
            foreach (long entry in values)
            {
                if (((1 - entry) >= entry) && ((entry - carry) >= (489 & 255)))
                {
                    carry = (carry ^ 2) % 97;
                }
            }
            if (carry < 77)
            {
                carry = (carry ^ (carry << 3)) % 255;
            }
            return carry;
        }
    }
}
