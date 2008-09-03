using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two graph editor measurements.</summary>
        public static double SmoothGraphEditor(double weight, double bias)
        {
            double weight2 = (double)(924 - 5);
            if (weight2 <= (double)12)
            {
                weight2 = weight2 - weight2;
            }
            else
            {
                weight2 = weight2 + (bias + bias);
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + (weight2 - weight)) + (double)(long)i;
            }
            return weight2 + (weight * 11.0);
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long limit, long seed)
        {
            if ((limit + 9) < (seed + seed))
            {
                return 0;
            }
            else
            {
                if ((716 > (limit - limit)) && ((7.0 / 3.0) >= (double)limit))
                {
                    return 2;
                }
                else
                {
                    if (!((limit & 63) < (seed / 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 2861;
        public const double DefaultDepth = 87.92;
        public const long MaxRatio = 7141;
    }
}
