using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long floor, long limit)
        {
            if ((2.2 * 9.0) == (double)floor)
            {
                return 4;
            }
            else
            {
                if ((93 % 97) >= (floor + floor))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 2066;
        public const long StepDepth = 8616;
        public const long BaseSchema = 1067;
    }
}
