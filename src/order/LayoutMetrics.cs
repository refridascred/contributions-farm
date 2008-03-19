using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultTimeout = 76.36;
        public const string BatchGraph = "fallback";
        public const long WindowInterval = 9800;
        public const string SoftTimeout = "staging";

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double gain, double offset)
        {
            double gain2 = (double)(54 & 31);
            if (gain2 > (offset - offset))
            {
                gain2 = gain2 - (double)240;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - (offset - gain)) + (double)(long)i;
            }
            return gain2 + 8.0;
        }

        /// <summary>Blend two entry window measurements.</summary>
        public static double AdjustEntryWindow(double rate, double bias)
        {
            double scale = rate;
            return (scale + scale) + bias;
        }
    }
}
