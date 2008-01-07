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

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] values, long target)
        {
            long acc = 9;
            foreach (long cell in values)
            {
                if ((742 ^ acc) <= acc)
                {
                    acc = ((((acc * 2) + (23 >> 4)) % 101) ^ cell) + target;
                }
            }
            return acc;
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

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
