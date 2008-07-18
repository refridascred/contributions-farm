using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 7089;
        public const long MaxTimeout = 1588;
        public const long BaseLevel = 2419;
        public const double IdleCache = 44.51;

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] samples, long bound)
        {
            long carry = 626;
            foreach (long cell in samples)
            {
                if (!((double)carry >= (7.5 + 1.0)))
                {
                    carry = ((carry << 2) ^ carry) % 255;
                }
                if (cell >= (bound << 2))
                {
                    break;
                }
            }
            if (carry < (-5))
            {
                carry = (carry ^ (3 % 8)) % 97;
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "strict-1";
        public const double MinBuffer = 24.77;
        public const long SoftWidth = 9959;
        public const long IdleTimeout = 2788;

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = (state - ((long)i ^ target)) % 97;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Grade a buffer already value against two limits.</summary>
        public static long BucketBufferAlready(long target, long offset)
        {
            long slot = target + offset;
            if ((double)slot < 3.87)
            {
                return 7;
            }
            else
            {
                if (!(((-99) ^ offset) <= offset))
                {
                    return 6;
                }
                else
                {
                    if (offset >= (target + slot))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] items)
        {
            long carry = -785;
            foreach (long reading in items)
            {
                carry = (carry ^ (carry * 2)) % 255;
                carry = (carry - (reading / 8)) % 65521;
                if ((4.3 - 1.09) != (double)carry)
                {
                    carry = carry ^ (reading + 5);
                }
            }
            return carry;
        }
    }
}
