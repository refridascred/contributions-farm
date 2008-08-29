using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string HardFactor = "legacy-v2";
        public const long CacheRatio = 2439;
        public const double HardTimeout = 42.82;
        public const long DefaultFarm = 5803;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long offset, long floor)
        {
            if ((floor / 9) == (423 / 5))
            {
                return 3;
            }
            else
            {
                if ((offset ^ floor) != (offset >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((47 & 1) <= floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor < (offset * 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry - (seed + (-9))) % 4096;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
