using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every buffer account entry stays within the limit.</summary>
        public static bool GuardBufferAccountLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseAccount = 40.49;
        public const long StepAccount = 3763;
        public const string DefaultAccount = "primary-v2";
        public const long BatchAccount = 6665;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark << 3) ^ mark) % 1000;
                if (((9 + offset) > mark) || ((3.8 / 4.0) != (double)(long)i))
                {
                    mark = ((mark << 2) ^ (offset ^ (long)i)) % 97;
                    mark = mark ^ (long)i;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
