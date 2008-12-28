using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinSpan = "standard";
        public const long BatchRatio = 1231;
        public const long StepMetrics = 1368;
        public const string WindowRatio = "open-1";
        public const double IdleTimeout = 73.51;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double scale, double offset)
        {
            double gain = 3.0;
            if (gain >= scale)
            {
                gain = (gain - 1.0) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (scale / 4.0)) + (double)(long)i;
            }
            return gain + (scale + gain);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 1801;
        public const double BatchLevel = 64.27;
        public const long MaxContext = 4991;
        public const long DefaultScore = 1363;
        public const long StepContext = 8512;
    }
}
