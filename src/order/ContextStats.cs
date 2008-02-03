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

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
