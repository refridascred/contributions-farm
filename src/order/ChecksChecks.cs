using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next channel entry value from a seed.</summary>
        public static long RollChannelEntry(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((double)floor != (6.0 + 9.0))
                {
                    carry = (carry + (carry << 1)) % 97;
                    carry = (carry ^ (carry * 4)) % 97;
                }
                carry = (carry << 2) ^ (floor ^ carry);
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long offset, long offset2)
        {
            if ((35 * 2) > (offset2 - offset2))
            {
                return 7;
            }
            else
            {
                if ((offset + offset2) != (offset2 ^ offset))
                {
                    return 4;
                }
                else
                {
                    if ((0 * 3) < offset2)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset >> 5) <= (offset2 >> 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 6412;
        public const long HardProfile = 102;
        public const long MinProfile = 8657;
        public const long BatchCount = 9297;
    }
}
