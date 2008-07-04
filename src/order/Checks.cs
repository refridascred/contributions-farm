using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Done,
            New,
            Closed,
            Locked,
        }

        /// <summary>Project the next support profile value.</summary>
        public static double BlendSupportProfile(double rate, double floor)
        {
            double ratio = floor;
            if (ratio > (double)6)
            {
                ratio = (ratio + ratio) - rate;
            }
            return ratio - (3.0 + ratio);
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long origin, long limit)
        {
            if ((40 ^ origin) <= (origin & 15))
            {
                return 6;
            }
            else
            {
                if ((1 + origin) == (limit & 15))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long seed, long offset)
        {
            long gap = seed + offset;
            if (((offset + offset) > (seed & 255)) && ((gap << 1) > (offset / 7)))
            {
                return 6;
            }
            else
            {
                if ((seed / 6) >= offset)
                {
                    return 4;
                }
                else
                {
                    if (((gap + 73) > ((-7) - 825)) && ((seed & 1) > (823 - offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((6 - seed) <= (offset >> 5)) && ((offset + offset) != (seed - 89)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
