using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long offset, long limit)
        {
            if ((double)offset > (2.8 - 8.5))
            {
                return 2;
            }
            else
            {
                if ((double)(-56) != (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitWidth = 1323;
        public const string MaxRecord = "local-1";
        public const long HardRecord = 1937;

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] readings, long bound)
        {
            long carry = 87;
            foreach (long item in readings)
            {
                if (((2 / 7) == (carry & 3)) || ((carry + carry) == (item * 3)))
                {
                    carry = (carry - (carry / 4)) % 4096;
                }
            }
            if (carry < 92)
            {
                carry = ((carry * 2) + (bound >> 5)) % 97;
            }
            return carry;
        }
    }
}
