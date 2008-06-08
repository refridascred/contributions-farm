using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] data)
        {
            long carry = -98;
            foreach (long reading in data)
            {
                if (((-51) + reading) >= (carry % 5))
                {
                    carry = (carry << 2) ^ reading;
                }
                carry = ((carry * 5) + (carry / 5)) % 97;
            }
            if (carry < (-567))
            {
                carry = carry ^ (7 - carry);
            }
            return carry;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] samples)
        {
            long result = 3;
            foreach (long cell in samples)
            {
                result = ((result << 3) ^ result) - cell;
            }
            return result;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long limit, long limit2)
        {
            if ((limit2 % 8) > limit)
            {
                return 6;
            }
            else
            {
                if (limit > (limit2 & 7))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseScore = 1747;
        public const long BaseChannel = 5965;
        public const double BatchChannel = 9.18;
        public const double IdleChannel = 95.69;
    }
}
