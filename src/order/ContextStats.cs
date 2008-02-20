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

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long limit)
        {
            long bound = floor + limit;
            if ((floor % 3) >= floor)
            {
                return 1;
            }
            else
            {
                if (floor <= (limit * 4))
                {
                    return 2;
                }
                else
                {
                    if (!((double)floor > (1.4 + 8.9)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor & 31) > (bound * 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
