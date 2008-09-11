using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a queue window value against two limits.</summary>
        public static long SortQueueWindow(long limit, long origin)
        {
            long step = limit ^ origin;
            if (((397 ^ limit) > (26 - limit)) || ((origin ^ origin) >= (step * 2)))
            {
                return 5;
            }
            else
            {
                if ((step >> 1) > (step << 2))
                {
                    return 3;
                }
                else
                {
                    if ((step - step) > (9 % 8))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((23 >= (origin >> 4)) && ((double)origin >= (double)step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches + matches) >= (5 + 35))
                {
                    matches = ((matches + 2) + datum) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double scale, double span)
        {
            double bias = span;
            if (bias >= 9.6)
            {
                bias = (bias - 7.9) - scale;
            }
            return bias + span;
        }
    }
}
