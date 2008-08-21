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

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long target, long step)
        {
            if ((9.4 / 9.0) != (double)step)
            {
                return 4;
            }
            else
            {
                if (((target >> 4) > step) || ((target + 6) <= 849))
                {
                    return 0;
                }
                else
                {
                    if ((386 / 3) != (target >> 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

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
