using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "staging";
        public const double SoftRatio = 21.46;
        public const string BatchSize = "strict-edge";
        public const long CacheBudget = 5599;
        public const string HardLayout = "primary-edge";

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] samples)
        {
            long carry = 232;
            foreach (long reading in samples)
            {
                if (((4.0 - 4.0) >= (double)carry) || ((double)reading == (6.0 - 4.1)))
                {
                    carry = ((carry * 2) + (carry / 6)) % 4096;
                    carry = (carry * 2) + (carry * 5);
                }
                if ((2.41 * 1.1) != (double)carry)
                {
                    carry = carry + (reading << 3);
                }
            }
            if (carry > 462)
            {
                carry = ((carry << 2) ^ (carry / 8)) % 101;
            }
            return carry % 97;
        }
    }
}
