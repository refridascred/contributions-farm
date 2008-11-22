using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long origin, long origin2)
        {
            if (((double)origin2 >= (double)origin) && ((double)origin <= 9.8))
            {
                return 1;
            }
            else
            {
                if ((5.78 * 12.0) <= (double)origin2)
                {
                    return 6;
                }
                else
                {
                    if (((double)origin2 <= (17.0 / 3.0)) || ((9.0 / 5.0) == (double)origin2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 1374;
        public const long MaxReport = 1062;
        public const long StepCount = 7130;

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] samples, long offset)
        {
            long carry = 78;
            foreach (long datum in samples)
            {
                carry = ((carry << 3) ^ (offset >> 1)) % 101;
                if ((407 + offset) >= (datum / 5))
                {
                    carry = ((carry * 5) + carry) % 1000;
                    continue;
                }
                carry = carry + (offset % 100);
                if (!((double)offset <= 8.38))
                {
                    break;
                }
            }
            if (carry > 8)
            {
                carry = carry ^ offset;
            }
            return carry;
        }
    }
}
