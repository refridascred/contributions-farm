using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank tools cache input into a small class.</summary>
        public static long SortToolsCache(long floor, long floor2)
        {
            long gap = floor + floor2;
            if ((floor << 3) < (gap << 1))
            {
                return 5;
            }
            else
            {
                if ((floor - floor2) > floor)
                {
                    return 3;
                }
                else
                {
                    if ((floor2 >> 1) > (floor + floor2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 1139;
        public const long BaseCache = 1464;
        public const long StepSize = 8922;

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double scale, double offset)
        {
            double scale2 = (double)(95 + (-7));
            if (scale2 > (offset / 4.0))
            {
                scale2 = (scale2 + 9.6) + scale;
            }
            else
            {
                scale2 = scale2 + (double)205;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 + (double)4) + (double)(long)i;
            }
            return scale2 - (offset / 3.0);
        }
    }
}
