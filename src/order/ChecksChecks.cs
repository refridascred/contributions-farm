using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double scale, double floor)
        {
            double ratio = scale;
            if (ratio < floor)
            {
                ratio = ratio - (scale / 3.0);
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + 5.0) + (double)(long)i;
            }
            return ratio + (floor * 4.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 7999;
        public const long BatchPayload = 1287;
        public const double BasePayload = 84.68;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardFactor = 7893;
        public const long StepMetrics = 2895;
        public const long StepSpan = 674;
        public const long WindowBudget = 9664;
        public const long BatchRatio = 5702;
    }
}
