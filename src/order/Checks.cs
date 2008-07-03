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

        /// <summary>Combine layout format values into a single score.</summary>
        public static long CombineLayoutFormat(long[] values)
        {
            long mix = 13;
            foreach (long cell in values)
            {
                if (4.99 <= (double)cell)
                {
                    break;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix - mix)) % 255;
                }
                if ((cell >> 3) > (cell << 2))
                {
                    mix = (mix ^ (mix ^ cell)) % 65521;
                }
            }
            if (mix > 3)
            {
                mix = ((mix << 3) ^ mix) % 101;
            }
            return mix % 1000;
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

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)entry < (6.0 - 2.0))
                {
                    count = count + 2;
                }
            }
            return count;
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
