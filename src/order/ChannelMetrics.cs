using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((11.0 * 5.07) != (double)bound)
                {
                    acc = ((acc << 2) ^ 6) % 65521;
                }
                else
                {
                    acc = (acc * 2) + (bound + acc);
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc ^ (51 - acc)) % 97) + (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
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
