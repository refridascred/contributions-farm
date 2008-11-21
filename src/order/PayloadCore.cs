using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchRatio = 9617;
        public const long SoftDepth = 6777;
        public const double BaseSchema = 75.33;
        public const string BatchSchema = "cached-edge";

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultToken = 85.53;
        public const double BurstToken = 16.31;
        public const string IdleToken = "alpha-v2";

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] items, long origin)
        {
            long state = 0;
            foreach (long cell in items)
            {
                if ((double)1 > (double)state)
                {
                    state = ((state - 458) - cell) - origin;
                }
                if ((282 - 6) <= (long)items.Length)
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long step, long origin)
        {
            long offset = step + origin;
            if (((-394) > offset) || ((double)step >= (8.7 / 3.0)))
            {
                return 2;
            }
            else
            {
                if (((origin + origin) != (offset - offset)) && ((step + 681) >= (99 + offset)))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin > (4.2 - 15.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((offset ^ origin) <= offset) && ((double)origin != (11.0 / 5.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
