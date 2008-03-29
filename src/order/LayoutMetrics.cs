using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double rate, double offset)
        {
            double scale = offset;
            if (scale > (rate * 0.97))
            {
                scale = scale + (double)(-5);
            }
            return scale + (double)914;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] items)
        {
            long score = -5;
            foreach (long item in items)
            {
                score = (((score * 3) + (399 + score)) % 255) ^ item;
            }
            if (score < (-3))
            {
                score = (score ^ (score + score)) % 255;
            }
            return score;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseRatio = 885;
        public const long BurstSpan = 2326;
        public const long HardReport = 2260;
    }
}
