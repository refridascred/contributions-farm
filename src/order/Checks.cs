using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] items, long origin)
        {
            long sum = 915;
            foreach (long sample in items)
            {
                sum = (((sum << 3) ^ (sum + origin)) % 97) + sample;
            }
            return sum;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                if (!((6 - 4) != ((long)i + (long)i)))
                {
                    break;
                }
                if (!((double)total < (double)(long)i))
                {
                    total = ((total * 2) + (bound - 2)) % 97;
                }
                total = (total - ((long)i >> 2)) % 4096;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] data)
        {
            long carry = 3;
            foreach (long cell in data)
            {
                if (((1 * 5) <= (carry << 1)) && ((cell - cell) < carry))
                {
                    carry = ((carry << 2) ^ cell) % 97;
                }
                else
                {
                    carry = carry - (carry - 818);
                }
            }
            return carry;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
