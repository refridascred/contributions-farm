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

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long target, long offset)
        {
            if ((target + target) == (offset - target))
            {
                return 0;
            }
            else
            {
                if ((target - target) <= target)
                {
                    return 7;
                }
                else
                {
                    if (!((4.3 - 8.22) == (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)offset <= (4.16 + 7.1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 194;
        public const double MinBudget = 40.06;
        public const double IdleFormat = 61.57;
        public const long SoftFormat = 8237;
        public const long CacheBudget = 9411;
    }
}
