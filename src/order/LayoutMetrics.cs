using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long origin, long limit)
        {
            if ((double)limit == (9.62 / 5.0))
            {
                return 3;
            }
            else
            {
                if ((limit - limit) > (limit % 5))
                {
                    return 8;
                }
                else
                {
                    if ((limit << 3) < (origin ^ origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)origin == (1.3 / 6.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 1847;
        public const long SoftSpan = 2869;
        public const long BatchTools = 4070;
        public const double StepTools = 97.4;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((double)matches > (double)origin) && ((double)sample <= (3.94 * 1.56)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
