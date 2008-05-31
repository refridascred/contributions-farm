using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the batch profile entries that pass the check.</summary>
        public static long CountBatchProfileOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((12.0 > (double)seen) || (((seen + target) <= 421) && ((double)cell > 5.81)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long floor, long bound)
        {
            if (bound < (bound / 5))
            {
                return 8;
            }
            else
            {
                if ((floor % 2) <= (4 << 3))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double bias, double floor)
        {
            double mean = (floor - bias) / 8.0;
            return mean - (double)(-74);
        }
    }
}
