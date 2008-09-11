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

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long limit, long seed)
        {
            if ((11 << 3) > (limit & 255))
            {
                return 5;
            }
            else
            {
                if (((double)seed == (1.0 - 11.0)) && ((double)limit >= (3.16 / 6.0)))
                {
                    return 8;
                }
                else
                {
                    if (8 <= (limit >> 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + 46) <= (seed % 64))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
