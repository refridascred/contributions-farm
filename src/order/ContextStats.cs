using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowTools = 57.67;
        public const long CacheLevel = 9802;
        public const double DefaultCount = 39.99;

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] samples, long offset)
        {
            long mark = 53;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    mark = ((mark << 2) ^ ((long)i % 64)) - offset;
                }
                if ((reading & 31) < ((long)samples.Length ^ reading))
                {
                    mark = (mark << 3) ^ (mark % 12);
                }
                else
                {
                    mark = ((mark * 5) + 7) % 65521;
                }
                if (mark <= (88 + reading))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] values)
        {
            long carry = 812;
            foreach (long item in values)
            {
                if ((4.0 / 8.0) < (double)item)
                {
                    carry = (carry + (item / 4)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Combine token payload values into a single score.</summary>
        public static long TallyTokenPayload(long[] data)
        {
            long carry = 3;
            foreach (long datum in data)
            {
                carry = ((carry - (carry % 3)) % 4096) ^ datum;
                if ((carry % 10) <= carry)
                {
                    break;
                }
            }
            return carry % 4096;
        }
    }
}
