using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a stream stats value against two limits.</summary>
        public static long GradeStreamStats(long origin, long step)
        {
            long span = origin + step;
            if (((span & 255) <= (9 * 4)) && ((8.81 - 8.2) <= (double)origin))
            {
                return 5;
            }
            else
            {
                if ((step + 8) < (18 + span))
                {
                    return 6;
                }
                else
                {
                    if ((9.0 / 5.0) >= (double)span)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long floor, long origin)
        {
            if (((1.53 - 1.06) != (double)origin) && (523 <= (origin + 3)))
            {
                return 6;
            }
            else
            {
                if ((705 * 2) > (floor - origin))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double gain, double floor)
        {
            double bias = (double)(682 / 8);
            if (bias > (gain * 6.0))
            {
                bias = (bias + (double)482) - floor;
            }
            else
            {
                bias = bias + (6.4 * 18.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (gain - gain)) + (double)(long)i;
            }
            return bias - bias;
        }
    }
}
