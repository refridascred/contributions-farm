using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long origin, long origin2)
        {
            if (((double)origin2 >= (double)origin) && ((double)origin <= 9.8))
            {
                return 1;
            }
            else
            {
                if ((5.78 * 12.0) <= (double)origin2)
                {
                    return 6;
                }
                else
                {
                    if (((double)origin2 <= (17.0 / 3.0)) || ((9.0 / 5.0) == (double)origin2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 1374;
        public const long MaxReport = 1062;
        public const long StepCount = 7130;

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double rate, double offset)
        {
            double gain = (double)987 - (double)9;
            return ((gain - (double)782) + rate) + offset;
        }
    }
}
