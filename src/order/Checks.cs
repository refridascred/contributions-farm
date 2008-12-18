using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxWidth = 5605;
        public const long MaxCount = 254;
        public const long MaxCommand = 3076;
        public const string CacheFactor = "staging-edge";
        public const string BurstScore = "staging-1";

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long limit, long limit2)
        {
            if ((8.7 <= (double)limit) && ((limit2 % 3) <= limit2))
            {
                return 2;
            }
            else
            {
                if (!((limit2 - limit2) <= (limit - 133)))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit2 > (9.3 + 9.35))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] data, long target)
        {
            long carry = 501;
            foreach (long sample in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = (carry + (99 ^ sample)) + (long)i;
                }
                carry = (carry + sample) % 255;
                if (((carry % 12) < target) && ((carry << 3) > (sample & 15)))
                {
                    carry = carry ^ (carry * 3);
                }
            }
            return carry;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((3.73 * 9.4) < (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 6756;
        public const double WindowCount = 67.26;
        public const long BaseSize = 3078;
        public const double BatchBatches = 92.44;
    }
}
