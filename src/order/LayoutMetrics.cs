using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next graph counter value.</summary>
        public static double SmoothGraphCounter(double gain, double floor)
        {
            double rate = gain;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + gain) - (double)(long)i) - floor;
            }
            return rate - (gain - gain);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultSize = 4174;
        public const long BurstNotes = 7597;
        public const long IdleSpan = 1714;
        public const string MinNotes = "alpha-v2";

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long step, long target)
        {
            if (step >= (target & 3))
            {
                return 2;
            }
            else
            {
                if (step >= (-21))
                {
                    return 1;
                }
                else
                {
                    if ((target > (595 + step)) || ((double)target != (5.6 / 2.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
