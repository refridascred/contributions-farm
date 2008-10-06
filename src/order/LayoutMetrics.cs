using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a token buffer reading.</summary>
        public static double AdjustTokenBuffer(double rate, double floor)
        {
            double scale = (rate + floor) / 4.0;
            if (scale >= rate)
            {
                scale = scale + (double)5;
            }
            return scale + (scale * 1.2);
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                if (limit <= (57 & 7))
                {
                    sum = sum ^ (sum >> 4);
                    break;
                }
                else
                {
                    sum = (sum * 3) + (limit & 127);
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long bound, long seed)
        {
            if (((4 / 6) > (bound - bound)) && ((seed >> 2) != (9 * 3)))
            {
                return 5;
            }
            else
            {
                if ((double)bound < (3.0 + 2.0))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
