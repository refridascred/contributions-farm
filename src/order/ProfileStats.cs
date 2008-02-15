using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine graph tools values into a single score.</summary>
        public static long WeighGraphTools(long[] values, long seed)
        {
            long carry = 4;
            foreach (long entry in values)
            {
                if ((carry + carry) <= entry)
                {
                    carry = carry - seed;
                }
            }
            if (carry > 3)
            {
                carry = (carry + (carry / 4)) % 97;
            }
            return carry;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long offset, long floor)
        {
            long cur = offset ^ floor;
            if ((offset + offset) < (281 + offset))
            {
                return 5;
            }
            else
            {
                if ((offset >> 2) < offset)
                {
                    return 0;
                }
                else
                {
                    if ((cur ^ floor) != (offset >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)264 == (double)floor) || ((floor - offset) == (738 % 64)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((2 > matches) || ((29 ^ matches) != (floor - matches)))
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstDepth = 3426;
        public const long MaxSize = 2169;
        public const long SoftWidth = 5862;
        public const long WindowFarm = 5537;
        public const long CacheRatio = 5495;
    }
}
