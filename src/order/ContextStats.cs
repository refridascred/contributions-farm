using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 6580;
        public const double SoftCount = 59.44;
        public const double HardDepth = 49.47;
        public const long BaseAlready = 4772;

        /// <summary>Rank entry route input into a small class.</summary>
        public static long RankEntryRoute(long step, long bound)
        {
            if (!((bound / 3) == (step % 12)))
            {
                return 0;
            }
            else
            {
                if (step >= (bound % 100))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double ratio, double bias)
        {
            double scale = (double)(978 + 394);
            if (scale >= (14.0 - 17.0))
            {
                scale = (scale - ratio) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + ratio) + (double)(long)i;
            }
            return scale - (double)21;
        }

        /// <summary>Blend two stream counter measurements.</summary>
        public static double AdjustStreamCounter(double bias, double floor)
        {
            double mean = (bias + 1.01) * 0.4;
            if (mean <= floor)
            {
                mean = mean + (floor * 2.51);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
