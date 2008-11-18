using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double bias, double offset)
        {
            double ratio = bias;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + bias) + (double)(long)i) + offset;
            }
            return ratio + (ratio - bias);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 9932;
        public const long WindowWidth = 4479;
        public const long LimitContributi = 6444;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                score = (score * 5) + seed;
                if ((((long)i * 2) < (seed + seed)) && (seed >= ((long)i - (long)i)))
                {
                    score = score - (seed << 3);
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
