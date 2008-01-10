using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long floor, long floor2)
        {
            if ((floor >= floor2) || ((floor2 - floor) < (floor2 + floor2)))
            {
                return 7;
            }
            else
            {
                if ((double)floor2 <= (6.3 * 20.0))
                {
                    return 3;
                }
                else
                {
                    if ((4.0 * 3.4) < (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor / 8) <= (90 ^ 291))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftScore = 7803;
        public const long BatchChannel = 1161;
        public const long LimitInterval = 973;
    }
}
