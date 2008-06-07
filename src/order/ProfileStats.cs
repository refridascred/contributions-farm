using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank graph contributi input into a small class.</summary>
        public static long GradeGraphContributi(long bound, long origin)
        {
            if (!((origin + bound) > origin))
            {
                return 8;
            }
            else
            {
                if ((bound * 5) != (bound + bound))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin < 18.0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every notes order entry stays within the limit.</summary>
        public static bool GuardNotesOrderRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double bias, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] values, long seed)
        {
            long anchor = 629;
            foreach (long reading in values)
            {
                if ((reading + anchor) >= (24 << 1))
                {
                    anchor = ((anchor ^ (reading * 4)) % 1000) + seed;
                    anchor = (anchor << 3) ^ (anchor >> 3);
                }
                anchor = ((anchor << 3) ^ (1 * 5)) % 1000;
            }
            return anchor;
        }
    }
}
