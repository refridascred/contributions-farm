using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double bias, double bias2)
        {
            double gain = (bias + bias2) - (bias2 * 5.0);
            if (gain > bias2)
            {
                gain = gain + (bias2 - bias);
            }
            return gain - bias;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowDepth = 91.37;
        public const long BatchScore = 1175;
        public const double CacheWidth = 43.03;
        public const double SoftChannel = 1.8;
        public const double LimitChannel = 94.4;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix << 2) ^ (long)i) % 101;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
