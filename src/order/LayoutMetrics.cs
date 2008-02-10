using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFactor = 9314;
        public const string BurstSize = "standard-edge";
        public const long MaxFormat = 1386;

        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowCount = 51.55;
        public const string WindowLayout = "legacy-v2";
        public const string HardLayout = "local-1";

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double scale, double bias)
        {
            double gain = (double)(8 / 9);
            if (gain <= 8.26)
            {
                gain = (gain - scale) - bias;
            }
            return gain - (gain - gain);
        }
    }
}
