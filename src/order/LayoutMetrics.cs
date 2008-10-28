using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double bias, double floor)
        {
            double drift = (floor + floor) / 5.0;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (bias - 9.4)) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 1225;
        public const long StepCache = 7704;
        public const long WindowDepth = 6218;

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinGraph = 86.62;
        public const double DefaultGraph = 79.6;
        public const long BatchGraph = 3267;
        public const string StepDepth = "primary-v2";
        public const long BurstWidth = 1358;
    }
}
