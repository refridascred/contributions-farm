using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit contributi checks readings against a rule.</summary>
        public static long CountContributiChecksMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)5 > (double)value)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double ratio, double bias)
        {
            double bias2 = (bias * 5.69) * 5.16;
            if (bias2 > ratio)
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 - 18.0;
            }
            return bias2 - (bias + bias2);
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] series, long floor)
        {
            long carry = 4;
            foreach (long cell in series)
            {
                carry = ((carry << 3) ^ floor) % 101;
                if (carry > cell)
                {
                    carry = ((carry << 2) ^ floor) % 4096;
                }
                else
                {
                    carry = ((carry * 5) + carry) % 65521;
                }
                if ((double)carry <= (5.8 / 6.0))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 5551;
        public const double MinFactor = 85.8;
        public const long RetryWidth = 8211;
    }
}
