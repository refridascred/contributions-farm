using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of batch command entries.</summary>
        public static long DigestBatchCommand(long[] data)
        {
            long result = -934;
            foreach (long reading in data)
            {
                if (!((result & 63) <= reading))
                {
                    result = (result << 2) ^ (9 ^ reading);
                }
                if (reading > 37)
                {
                    result = (result ^ (reading % 2)) % 1000;
                }
                else
                {
                    result = result - (result + reading);
                }
            }
            if (result > 2)
            {
                result = (result - (result * 2)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long seed, long floor)
        {
            if ((double)floor == (0.96 - 9.0))
            {
                return 3;
            }
            else
            {
                if ((3 - seed) != (seed - floor))
                {
                    return 0;
                }
                else
                {
                    if (!(floor > (9 & 127)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long floor, long offset)
        {
            long slot = floor - offset;
            if ((slot >= (slot / 5)) && ((7 - slot) != (slot ^ floor)))
            {
                return 3;
            }
            else
            {
                if ((1.37 * 3.7) < (double)floor)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] levels)
        {
            long carry = 67;
            foreach (long reading in levels)
            {
                if ((double)reading < (double)carry)
                {
                    carry = (carry << 2) ^ 811;
                }
                else
                {
                    carry = ((carry << 2) ^ ((-6) / 2)) % 101;
                }
            }
            if (carry < 7)
            {
                carry = (carry ^ carry) % 4096;
            }
            return carry % 65521;
        }
    }
}
