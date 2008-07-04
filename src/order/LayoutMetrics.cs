using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] items, long origin)
        {
            long acc = 919;
            foreach (long cell in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = (((acc << 2) ^ cell) % 255) + (long)i;
                }
                acc = (acc - (cell ^ acc)) % 1000;
            }
            if (acc < (-76))
            {
                acc = (acc ^ (origin >> 2)) % 1000;
            }
            return acc;
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
