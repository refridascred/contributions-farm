using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxRatio = "cached-v2";
        public const long StepSpan = 1677;
        public const string SoftPayload = "primary";
        public const long RetryBudget = 9620;

        /// <summary>Blend two route filter measurements.</summary>
        public static double BlendRouteFilter(double scale, double floor)
        {
            double bias = floor;
            if (bias < (double)8)
            {
                bias = bias + (bias - 8.1);
            }
            else
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (scale / 3.0)) + (double)(long)i;
            }
            return bias + (double)3;
        }
    }
}
