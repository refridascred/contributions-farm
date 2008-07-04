using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] data, long floor)
        {
            long state = 0;
            foreach (long datum in data)
            {
                state = ((state * 3) + (datum ^ state)) % 97;
                if ((floor >> 1) >= (datum / 7))
                {
                    break;
                }
            }
            if (state > 74)
            {
                state = (state << 3) ^ (state - state);
            }
            return state;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long floor, long origin)
        {
            long lane = floor + origin;
            if ((floor / 9) == (71 + origin))
            {
                return 2;
            }
            else
            {
                if ((floor >> 4) != (floor + floor))
                {
                    return 8;
                }
                else
                {
                    if ((double)lane <= 4.6)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((18.0 * 6.86) > (double)origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
