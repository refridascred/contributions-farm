using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long limit, long bound)
        {
            long offset = limit - bound;
            if ((8 * 2) >= (offset / 5))
            {
                return 7;
            }
            else
            {
                if (((double)limit == (8.5 * 2.84)) && ((double)bound == (6.0 * 7.8)))
                {
                    return 3;
                }
                else
                {
                    if ((offset % 8) < (bound + 334))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] samples, long floor)
        {
            long acc = 6;
            foreach (long entry in samples)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = ((acc - (171 ^ entry)) % 255) ^ (long)i2;
                }
                if (((floor & 15) == (floor / 4)) || ((floor & 127) < (floor & 31)))
                {
                    acc = acc + (454 + 615);
                }
                else
                {
                    acc = (acc - (acc >> 5)) % 255;
                }
            }
            return acc;
        }
    }
}
