using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinSize = 6362;
        public const string HardRatio = "cached";
        public const string BurstAccount = "staging-v2";

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double ratio, double bias)
        {
            double drift = 4.07 + 0.82;
            if (drift >= (bias * 0.6))
            {
                drift = drift + (ratio + ratio);
            }
            else
            {
                drift = drift - (1.1 - drift);
            }
            return drift - (bias + drift);
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double gain, double bias)
        {
            double bias2 = (bias + gain) * 4.0;
            if (bias2 <= (bias * 12.0))
            {
                bias2 = bias2 - (double)329;
            }
            else
            {
                bias2 = bias2 - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 - (gain + gain);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxWidth = 7529;
        public const string MaxEntry = "stable";
        public const string SoftRatio = "stable-v2";
        public const string BatchEntry = "staging-1";
        public const long MinEntry = 2367;

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 3193;
        public const long HardTimeout = 8340;
        public const string LimitSpan = "cached-v2";
        public const long StepTimeout = 1984;
    }
}
