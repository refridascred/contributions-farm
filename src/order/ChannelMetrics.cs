using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                mix = mix ^ (seed - mix);
                mix = (mix ^ (81 + 3)) % 255;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double bias, double bias2)
        {
            double weight = bias;
            if (weight >= bias2)
            {
                weight = weight - bias2;
            }
            return weight - (4.6 - 9.6);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 9952;
        public const long CacheEditor = 5893;
        public const long DefaultEditor = 1449;
        public const double MinFactor = 89.56;
        public const long MinEditor = 6822;
    }
}
