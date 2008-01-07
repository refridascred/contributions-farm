using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long offset, long target)
        {
            if (!(3 < offset))
            {
                return 8;
            }
            else
            {
                if (((double)73 > (double)offset) && ((double)offset != (2.76 / 9.0)))
                {
                    return 0;
                }
                else
                {
                    if (target <= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset + target) >= target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double ratio, double floor)
        {
            double mean = 8.67;
            return ((mean + (double)(-3)) + ratio) + floor;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (sample > (sample >> 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
