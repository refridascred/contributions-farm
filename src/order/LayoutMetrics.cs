using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double bias, double span)
        {
            double drift = bias;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + span;
            }
            return drift - (double)(-154);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSpan = 71.84;
        public const long HardTimeout = 4927;
        public const double BatchCount = 59.35;
    }
}
